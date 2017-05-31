using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIGenerator
{
    public partial class Form1 : Form
    {
        String store = "";
        String api = "";
        String apiName = "";
        List<String> listRawParams;
        List<String> listApiParams;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listRawParams = new List<string>();
            listApiParams = new List<string>();
            store = rt_Store.Text;
            getAPIName();
            rt_API.Text = generateAPI();
        }

        public String getAPIName()
        {
            int position = store.LastIndexOf("PROCEDURE");
            // position + 11 => begin store name
            int storeCount = store.Count();
            int index = 0;
            while (store[position + 11 + index] != '`')
            {
                index++;
            }
            apiName = store.Substring(position + 11, index);
            return apiName;
        }
        public String generateAPI()
        {
            List<String> paramList = getParamList();
            String paramLine = "";
            for (int i = 0; i < paramList.Count; i++)
            {
                paramLine += genVariables(paramList[i]);
            }
            String rawFunctionSyntax = "";
            if (listRawParams.Count > 0)
            {
                rawFunctionSyntax = "public function " + apiName + "(){\n$this->load->database();\n  " + paramLine + "\n" + genStoreCallQuerry() + "\n$result = $this->db->query($query,array(" + genQuerryArray() + "));\n  echo json_encode($result->result_array());\n $this->db->close();\n }";
            }else
            {
                rawFunctionSyntax = "public function " + apiName + "(){\n$this->load->database();\n  " + paramLine + "\n" + genStoreCallQuerry() + "\n$result = $this->db->query($query);\n  echo json_encode($result->result_array());\n $this->db->close();\n }";
            }
            
            return rawFunctionSyntax;
        }
        
        public String genVariables(String paramName)
        {
            String t = "$"+paramName+" = $this->input->post('"+paramName+ "');\n";
            return t;
        }

        public String genQuerryArray()
        {
            String querry = "";
            for(int i = 0; i< listApiParams.Count;i++)
            {
                querry += "\'" + listRawParams[i] + "\'" + "=> $" + listApiParams[i]+",";
            }
            if (querry != "")
            {
                querry = querry.Substring(0, querry.Count() - 1);
            }
            return querry;
        }
        public String genStoreCallQuerry()
        {
            string question = "";
            for (int i = 0; i < listApiParams.Count(); i++)
            {
                question += "?,";
            }
            if(question!="")
            question = question.Substring(0, question.Count() - 1);
            String s = "$query = \"CALL "+getAPIName()+"("+question+")\";";
            return s;
        }
        public List<String> getParamList()
        {

            List<int> listParam = AllIndexesOf(store, "IN ");
            foreach(int pos in listParam)
            {
                int i = 0; // get position of param
                while(store[pos+3+i]!=' ')
                {
                    i++;
                }
                listRawParams.Add(store.Substring(pos + 3, i));
                listApiParams.Add(store.Substring(pos + 3, i).Substring(2));
            }
            return listApiParams;
        }
        public List<int> AllIndexesOf(string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }
    }
}

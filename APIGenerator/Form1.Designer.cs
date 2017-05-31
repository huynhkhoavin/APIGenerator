namespace APIGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.rt_Store = new System.Windows.Forms.RichTextBox();
            this.rt_API = new System.Windows.Forms.RichTextBox();
            this.sqlPrototype = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Just Do It";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rt_Store
            // 
            this.rt_Store.Location = new System.Drawing.Point(12, 38);
            this.rt_Store.Name = "rt_Store";
            this.rt_Store.Size = new System.Drawing.Size(378, 233);
            this.rt_Store.TabIndex = 1;
            this.rt_Store.Text = "";
            // 
            // rt_API
            // 
            this.rt_API.Location = new System.Drawing.Point(426, 38);
            this.rt_API.Name = "rt_API";
            this.rt_API.Size = new System.Drawing.Size(386, 233);
            this.rt_API.TabIndex = 1;
            this.rt_API.Text = "";
            // 
            // sqlPrototype
            // 
            this.sqlPrototype.AutoSize = true;
            this.sqlPrototype.Location = new System.Drawing.Point(12, 12);
            this.sqlPrototype.Name = "sqlPrototype";
            this.sqlPrototype.Size = new System.Drawing.Size(81, 13);
            this.sqlPrototype.TabIndex = 2;
            this.sqlPrototype.Text = "StoreProcedure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "API";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sqlPrototype);
            this.Controls.Add(this.rt_API);
            this.Controls.Add(this.rt_Store);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rt_Store;
        private System.Windows.Forms.RichTextBox rt_API;
        private System.Windows.Forms.Label sqlPrototype;
        private System.Windows.Forms.Label label2;
    }
}


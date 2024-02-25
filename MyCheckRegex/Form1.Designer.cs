namespace MyCheckRegex
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
            System.Windows.Forms.RichTextBox richTextBox3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = System.Drawing.Color.DarkGray;
            richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox3.DetectUrls = false;
            resources.ApplyResources(richTextBox3, "richTextBox3");
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // richTextBox2
            // 
            resources.ApplyResources(this.richTextBox2, "richTextBox2");
            this.richTextBox2.Name = "richTextBox2";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox4, "richTextBox4");
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox5, "richTextBox5");
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox6, "richTextBox6");
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Button button1;
    }
}


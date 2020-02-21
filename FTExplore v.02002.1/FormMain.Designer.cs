namespace FileTypeExplorer
{
    partial class FormMain
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
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_process = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_mostSimilar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(52, 14);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(322, 20);
            this.textBox_Path.TabIndex = 0;
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(380, 12);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 1;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button_process
            // 
            this.button_process.Location = new System.Drawing.Point(380, 41);
            this.button_process.Name = "button_process";
            this.button_process.Size = new System.Drawing.Size(75, 23);
            this.button_process.TabIndex = 2;
            this.button_process.Text = "Process";
            this.button_process.UseVisualStyleBackColor = true;
            this.button_process.Click += new System.EventHandler(this.button_process_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(52, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(322, 186);
            this.listBox1.TabIndex = 3;
            // 
            // label_mostSimilar
            // 
            this.label_mostSimilar.AutoSize = true;
            this.label_mostSimilar.Location = new System.Drawing.Point(49, 46);
            this.label_mostSimilar.Name = "label_mostSimilar";
            this.label_mostSimilar.Size = new System.Drawing.Size(92, 13);
            this.label_mostSimilar.TabIndex = 4;
            this.label_mostSimilar.Text = "Most similar types:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 280);
            this.Controls.Add(this.label_mostSimilar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_process);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.textBox_Path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "FileTypeExplorer [FTExplore v.02002.1]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button_process;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_mostSimilar;
    }
}


namespace WindowsFormsApplication1
{
    partial class EditFile
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
            this.textBox_Edit_File = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Edit_File
            // 
            this.textBox_Edit_File.Location = new System.Drawing.Point(13, 12);
            this.textBox_Edit_File.Multiline = true;
            this.textBox_Edit_File.Name = "textBox_Edit_File";
            this.textBox_Edit_File.Size = new System.Drawing.Size(455, 264);
            this.textBox_Edit_File.TabIndex = 1;
            this.textBox_Edit_File.TextChanged += new System.EventHandler(this.textBox_Edit_File_TextChanged);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(13, 282);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(95, 26);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(373, 282);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(95, 26);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "Отменить";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // EditFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_Edit_File);
            this.Name = "EditFile";
            this.Text = "EditFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Edit_File;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Exit;
    }
}
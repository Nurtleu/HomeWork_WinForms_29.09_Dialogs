namespace WindowsFormsApplication1
{
    partial class Open_File
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(12, 34);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(127, 30);
            this.button_OpenFile.TabIndex = 1;
            this.button_OpenFile.Text = "Загрузить файл";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(154, 34);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(127, 31);
            this.button_Edit.TabIndex = 2;
            this.button_Edit.Text = "Редактировать";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // Open_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 87);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_OpenFile);
            this.Name = "Open_File";
            this.Text = "Open File";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.Button button_Edit;
    }
}


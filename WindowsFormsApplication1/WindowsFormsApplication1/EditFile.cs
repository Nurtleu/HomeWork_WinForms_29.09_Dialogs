using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EditFile : Form
    {
        public EditFile()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
        }

        private void button_EditFile_Click(object sender, EventArgs e)
        {
            this.textBox_Edit_File.Text.ToString();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Edit_File_TextChanged(object sender, EventArgs e)
        { 
            if (!File.Exists("textboxFile.txt"))
                File.Create("textboxFile.txt").Close();
            File.WriteAllText("textboxFile.txt", textBox_Edit_File.Text);
        }
    }
}   

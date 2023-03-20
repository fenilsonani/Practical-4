using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
            else
            {
                MessageBox.Show("Please select a font");
            }
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save the file and text with .txt 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //save the file and text with .txt
                saveFileDialog1.Filter= "Text Files (.txt)|*.txt|Rich Text Files (.rtf)|*.rtf";
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
            else
            {
                MessageBox.Show("Dont Save The File");
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cut the selected font

            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Filter = "Text Files (.txt)|*.txt|Rich Text Files (.rtf)|*.rtf";
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Dont Saved The File");
            }
        }
    }
}

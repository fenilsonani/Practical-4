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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //add some fonts to the combobox1
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name);
            }
            for (int i = 8; i <= 72; i++)
            {
                comboBox2.Items.Add(i);
                i++;
                i++;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change the font size
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, float.Parse(comboBox2.Text), richTextBox1.SelectionFont.Style);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bold the selected text
            if (richTextBox1.SelectionFont.Bold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change the font family
            richTextBox1.SelectionFont = new Font(comboBox1.Text, richTextBox1.SelectionFont.Size);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //italic the font
            if (richTextBox1.SelectionFont.Italic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //underline the font
            if (richTextBox1.SelectionFont.Underline)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor= colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("Please select a color");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(colorDialog2.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog2.Color;
            }
            else
            {
                MessageBox.Show("please select In any Color");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //align all text in left
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}

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
    public partial class Form3 : Form
    {
        int count=0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0 )
            {
                MessageBox.Show("Please enter a name");
            }
            else
            {
                treeView1.Nodes.Add(textBox1.Text);
                count++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Length == 0 )
            {
                MessageBox.Show("Enter a Name");
            }
            else
            {
                treeView1.SelectedNode.Nodes.Add(textBox2.Text);
                count++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //move the selected node the up
            TreeNode node = treeView1.SelectedNode;

            if (node != null)
            {
                TreeNodeCollection nodes = node.Parent.Nodes;
                int index = nodes.IndexOf(node);
                if (index > 0)
                {
                    nodes.Remove(node);
                    nodes.Insert(index - 1, node);
                    treeView1.SelectedNode = node;
                }
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //move the selected node the down
            TreeNode node = treeView1.SelectedNode;
            if (node != null)
            {
                TreeNodeCollection nodes = node.Parent.Nodes;
                int index = nodes.IndexOf(node);
                if (index < nodes.Count - 1)
                {
                    nodes.Remove(node);
                    nodes.Insert(index + 1, node);
                    treeView1.SelectedNode = node;
                }
            }
        }
    }
}

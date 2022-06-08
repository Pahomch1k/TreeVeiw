using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_14_TreeVeiw
{
    public partial class Form1 : Form
    {
        private TreeView treeView1;
        public TreeNode node, node2;
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int x3 { get; set; }
        public Form1()
        {
            InitializeComponent(); 
            treeView1 = new TreeView(); 
            SuspendLayout();
             
            treeView1.Location = new Point(10, 40); 
            treeView1.Size = new Size(292, 248); 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
             
            //treeView1.MouseDown += new MouseEventHandler(treeView1_MouseDown); 
            //treeView1.AfterSelect += new TreeViewEventHandler(treeView1_AfterSelect);

            string[] s1 = new string[3] { "TV", "Ноут", "Холодильник" };
            string[,] s2 = new string[3,3] { { "Sony", "Samsung", "LG" }, { "Asus", "Acer", "HP" }, { "Indesit", "Samsung", "LG" } };
            x1 = 1; x2 = 1; x3 = 1;
             
            node = treeView1.Nodes.Add($"{x1}. Электроника"); 
            comboBox1.Items.Add("Электроника"); 
            node2 = node;

            for (int x = 0; x < 3; x++)
            {
                if (x2 == 3)
                {
                    node = node2.Nodes.Add($"{x1}.{x2}. {s1[x]}");
                    comboBox2.Items.Add(s1[x]);
                    for (int y = 0; y < 3; y++)
                    {
                        node.Nodes.Add($"{x1}.{x2}.{x3}. {s2[x, y]}");
                        x3++;
                    }
                }

                if (x2 == 2)
                {
                    node = node2.Nodes.Add($"{x1}.{x2}. {s1[x]}");
                    comboBox2.Items.Add(s1[x]);
                    for (int y = 0; y < 3; y++)
                    {
                        node.Nodes.Add($"{x1}.{x2}.{x3}. {s2[x, y]}");
                        x3++;
                    } 
                }

                if (x2 == 1)
                {
                    node = node.Nodes.Add($"{x1}.{x2}. {s1[x]}");
                    comboBox2.Items.Add(s1[x]);
                    for (int y = 0; y < 3; y++)
                    {
                        node.Nodes.Add($"{x1}.{x2}.{x3}. {s2[x, y]}");
                        x3++;
                    }
                } 
                x2++;
                x3 = 1;
            }
            x1++;
            node = treeView1.Nodes.Add($"{x1}. Одежда");
            comboBox1.Items.Add("Одежда");
            x1++;
             

            // Добавление элементов управления в коллекцию Controls
            Controls.Add(treeView1);
            // Настройки для всех элементов формы одновременно вступают в силу
            ResumeLayout(false); 
        }

        //private void treeView1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right)
        //    { 
        //        TreeNode node = treeView1.GetNodeAt(e.X, e.Y); 
        //        if (node != null) node.Remove();
        //    }
        //}

        //private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        //{ 
        //    Text = e.Node.Text;
        //}

        private void bAddPodKat_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) MessageBox.Show("выберите категорию");
            else
            {
                if (textBox2.Text == "") MessageBox.Show("Заполните поле");
                else
                {
                    for (int i = 0; i < 10; i++)
                    { 
                        if (comboBox1.SelectedIndex == i)
                        {
                            node = node2.Nodes.Add($"{comboBox1.SelectedIndex + 1}.{x2}. {textBox2.Text}");
                            x2++;
                            comboBox2.Items.Add(textBox2.Text);
                            break;
                        }
                    } 
                }
            } 
        }

        private void bAddName_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) MessageBox.Show("Выберите категорию");
            else
            {
                if (comboBox2.SelectedItem == null) MessageBox.Show("Выберите подкатегорию");
                else
                {
                    if (textBox3.Text == "") MessageBox.Show("Заполните поле");
                    else
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            node.Nodes.Add($"{comboBox1.SelectedIndex}.{x2}.{x3}. {textBox3.Text}");
                            x3++;
                            comboBox1.Items.Add(textBox2.Text);
                        }
                    } 
                }
            }
        }

        private void bAddKat_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Заполните поле");
            else
            {
                node = treeView1.Nodes.Add($"{x1}. {textBox1.Text}");
                x1++;
                comboBox1.Items.Add(textBox1.Text);
            } 
        }
    }
}

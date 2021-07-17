using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using EasyExploits;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Slasher
{
    public partial class Form1 : Form
    {
        Point lastPoint;
        EasyExploits.Module module = new EasyExploits.Module();

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            PopulateListBox(listBox1, "./Scripts", "*.txt");
            PopulateListBox(listBox1, "./Scripts", "*.lua");
        }
        public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Join Our Discord For Support https://discord.gg/cQFjjshcSY");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("File Does Not Exist");
            }
            else
            {
                fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream s = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(s);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            module.ExecuteScript(fastColoredTextBox1.Text);
        }



        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

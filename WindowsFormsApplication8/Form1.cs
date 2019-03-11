using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Diagnostics;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void aÇToolStripMenuItem1_Click(object sender, EventArgs e)
        {                
                ofd.ShowDialog();
                richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
        }

        private void dÜZENToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kAYDETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(ofd.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();

        }

        private void fARKLIKAYDETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Metin Dosyası|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
            }
        }

        private void yAZDIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(yAZDIRToolStripMenuItem_Click);

            try
            {
                pd.Print();
            }
            catch
            {
                Console.WriteLine("Yazıcı Çıktısı Çıkarılamıyor.");
            }
            finally
            {
                pd.Dispose();
            }
        }

        private void çIKIÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bULToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = 0;
            string metin = richTextBox1.Text;
            richTextBox1.Text = "";
            richTextBox1.Text = metin;
            while (index < richTextBox1.Text.LastIndexOf(textBox1.Text))
            {
                richTextBox1.Find(textBox1.Text, index, richTextBox1.TextLength, RichTextBoxFinds.None);
                richTextBox1.SelectionBackColor = Color.Yellow;
                index = richTextBox1.Text.IndexOf(textBox1.Text, index) + 1;
            }
        }

        private void bULDEĞİŞTİRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = 0;
            string metin = richTextBox1.Text;
            richTextBox1.Text = "";
            richTextBox1.Text = metin;
            while (index < richTextBox1.Text.LastIndexOf(textBox1.Text))
            {
                richTextBox1.Find(textBox1.Text, index, richTextBox1.TextLength, RichTextBoxFinds.None);
                richTextBox1.SelectedText = textBox2.Text;
                index = richTextBox1.Text.IndexOf(textBox1.Text, index) + 1;
            }
        }

        private void yAZITİPİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void cÜToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.cumhuriyet.edu.tr/");
        }

        private void yAZITİPİ2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}

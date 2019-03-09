using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            listBox2.Items.Add(FontStyle.Bold);
            listBox2.Items.Add(FontStyle.Italic);
            listBox2.Items.Add(FontStyle.Underline);
            listBox2.Items.Add(FontStyle.Regular);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

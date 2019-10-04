using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szinbekeres
{
    public partial class Form1 : Form
    {   public int a, b;
        
        public Form1()
        {
            InitializeComponent();



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = hatterSzin.ShowDialog();
            if (result==DialogResult.OK)
            {
                this.BackColor = hatterSzin.Color;
                label1.BackColor = Color.White;
                label2.BackColor = Color.White;
                label3.BackColor = Color.White;
                
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            eredmeny.ReadOnly = true;

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {   
            
            eredmeny.Text = Convert.ToString(a+b);

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt32(textBox2.Text);

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
        }
    }
}

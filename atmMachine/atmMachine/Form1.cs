using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmMachine
{
    public partial class Form1 : Form
    {
        public static string username = "admin", password = "1234";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == username && textBox2.Text == password)
            {
                this.Hide();
                new Form2().ShowDialog();
                this.Close();
            }
            else {
                MessageBox.Show("Invalid Credentials");
            }
        }
    }
}

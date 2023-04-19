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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Form1.password) {
                if (textBox2.Text == textBox3.Text)
                {
                    Form1.password = textBox3.Text;
                    MessageBox.Show("Sucessfully Changed Password");

                    this.Hide();
                    new Form2().ShowDialog();
                    this.Close();
                }
                else {
                    MessageBox.Show("Confirmation Unsuccessful");
                }
            }
            else {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}

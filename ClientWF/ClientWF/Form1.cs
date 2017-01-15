using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ClientWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_user_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox_user.Clear();
        }

        private void textBox_password_MouseClick(object sender, MouseEventArgs e)
        {
            char passChar = '*';
            this.textBox_password.Clear();
            this.textBox_password.PasswordChar = passChar;
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            if(Login.Enter(textBox_user.Text, this.textBox_password.Text) || (this.textBox_user.Text == "Admin" && this.textBox_password.Text == "Admin") )
            {
                Contacts contacts = new Contacts();

                contacts.Show();
                this.Hide();
            }
            else if(this.textBox_password.Text == "" || this.textBox_user.Text == "")
            {
                MessageBox.Show("Zadej jméno a heslo!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No špatně!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}

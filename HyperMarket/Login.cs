using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperMarket
{
    public partial class Login : Form
    {
        AdminForm adminForm = new AdminForm();
  
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ButtonlOGIN_Click(object sender, EventArgs e)
        {
            Cashier casher = Market.market.GetCasher(guna2TextBoxUSERN.Text);
            if (guna2TextBoxUSERN.Text == "" || guna2TextBoxPWD.Text == "")
            {
                MessageBox.Show("Enter The UserName And Password");
            }
            else
            {
                if (ComboBox1SelectRole.SelectedIndex > -1)
                {
                    if (ComboBox1SelectRole.SelectedItem.ToString() == "Admin")
                    {
                        if (guna2TextBoxUSERN.Text == "Admin" && guna2TextBoxPWD.Text == "Admin")
                        {
                            this.Close();
                            
                            adminForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("If you are the Admin,Enter The Correct Data");
                        }
                    }
                    else if (ComboBox1SelectRole.SelectedItem.ToString() == "Casher")
                    {
                        if (guna2TextBoxUSERN.Text == casher.Username.ToString() && guna2TextBoxPWD.Text == casher.Password.ToString())
                        {
                            

                            CashierForm cashierForm = new CashierForm(guna2TextBoxUSERN.Text);
                            cashierForm.Show();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("If you are the Casher,Enter The Correct Data");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Select A Role");
                }

            }
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            guna2TextBoxUSERN.Clear();
            guna2TextBoxPWD.Clear();
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.BackColor = Color.Red;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.BackColor = Color.FromArgb(222, 244, 249);

        }

        private void ShowPasswordLabel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(guna2TextBoxPWD.Text.ToString()))
            {
                guna2TextBoxPWD.PasswordChar=default(char);
                guna2TextBoxPWD.UseSystemPasswordChar = false;
                labelforhide.Visible = true;
                ShowPasswordLabel.Visible = false;
            }
        }

        private void labelforhide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(guna2TextBoxPWD.Text.ToString()))
            {
               // guna2TextBoxPWD.PasswordChar = default(char);
                guna2TextBoxPWD.UseSystemPasswordChar = true;
                ShowPasswordLabel.Visible = true;
                labelforhide.Visible = false;
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    }
    


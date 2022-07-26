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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int StartPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPoint += 5;
            MyProgressBar.Value = StartPoint;
            PresentgeLabel.Text = StartPoint + "%";
            if (MyProgressBar.Value == 100)
            {
                MyProgressBar.Value = 0;
                timer1.Stop();
              
                Login login = new Login();
                login.Show();
                this.Hide();

            }
        }
       
        private void MyProgressBar_Click(object sender, EventArgs e)
        {
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

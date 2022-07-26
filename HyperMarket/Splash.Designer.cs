namespace HyperMarket
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.PresentgeLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1Loading = new Guna.UI.WinForms.GunaLabel();
            this.MyProgressBar = new Guna.UI.WinForms.GunaProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 12;
            resources.ApplyResources(this.guna2PictureBox1, "guna2PictureBox1");
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // gunaLabel2
            // 
            resources.ApplyResources(this.gunaLabel2, "gunaLabel2");
            this.gunaLabel2.ForeColor = System.Drawing.Color.Green;
            this.gunaLabel2.Name = "gunaLabel2";
            // 
            // PresentgeLabel
            // 
            resources.ApplyResources(this.PresentgeLabel, "PresentgeLabel");
            this.PresentgeLabel.ForeColor = System.Drawing.Color.Green;
            this.PresentgeLabel.Name = "PresentgeLabel";
            // 
            // gunaLabel1Loading
            // 
            resources.ApplyResources(this.gunaLabel1Loading, "gunaLabel1Loading");
            this.gunaLabel1Loading.ForeColor = System.Drawing.Color.Green;
            this.gunaLabel1Loading.Name = "gunaLabel1Loading";
            // 
            // MyProgressBar
            // 
            this.MyProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.MyProgressBar.BorderColor = System.Drawing.Color.Black;
            this.MyProgressBar.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.MyProgressBar.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.MyProgressBar, "MyProgressBar");
            this.MyProgressBar.Name = "MyProgressBar";
            this.MyProgressBar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.MyProgressBar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.MyProgressBar.Radius = 5;
            this.MyProgressBar.Click += new System.EventHandler(this.MyProgressBar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            resources.ApplyResources(this.guna2CircleButton1, "guna2CircleButton1");
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            // 
            // gunaLabel1
            // 
            resources.ApplyResources(this.gunaLabel1, "gunaLabel1");
            this.gunaLabel1.ForeColor = System.Drawing.Color.Green;
            this.gunaLabel1.Name = "gunaLabel1";
            // 
            // Splash
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.PresentgeLabel);
            this.Controls.Add(this.gunaLabel1Loading);
            this.Controls.Add(this.MyProgressBar);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel PresentgeLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1Loading;
        private Guna.UI.WinForms.GunaProgressBar MyProgressBar;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
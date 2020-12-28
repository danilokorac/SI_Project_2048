using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        private readonly BLayer b1;
        public MainForm()
        {
            this.b1 = new BLayer();
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            panelForms.Visible = false;
        }
        private void NavbarTop_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }
        Point lastPoint;
        private void NavbarTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void FormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            MaximizeForm.Visible = false;
            NormalForm.Visible = true;
        }

        private void MinimizeForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void NormalForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            NormalForm.Visible = false;
            MaximizeForm.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SideWrapper.Width = 90;
                LineSidebar.Width = 50;
                AnimationSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SideWrapper.Width = 300;
                LineSidebar.Width = 252;
                AnimationSidebarBack.Show(Sidebar);
            }
        }
        public static RegistrationForm registrationForm = new RegistrationForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public static LogInForm loginForm = new LogInForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public static Game playGame = new Game() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public static PersonalScores personalScores = new PersonalScores() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public static TopPlayers topPlayers = new TopPlayers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public static Achievements achiv = new Achievements() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private void bunifuFlatButtonRegister_Click(object sender, EventArgs e)
        {
            panelForms.Visible = true;
            this.panelForms.Controls.Add(registrationForm);
            loginForm.Visible = false;
            playGame.Visible = false;
            registrationForm.Show();
            labelMainFormText.Visible = false;
            label2MainForm.Visible = false;
            label3MainForm.Visible = false;
        }
        private void bunifuFlatButtonLogIn_Click(object sender, EventArgs e)
        {
            panelForms.Visible = true;
            this.panelForms.Controls.Add(loginForm);
            registrationForm.Visible = false;
            playGame.Visible = false;
            loginForm.Show();
            if(loginForm.login == true)
            {
                panelForms.Visible = true;
                this.panelForms.Controls.Add(playGame);
                registrationForm.Visible = false;
                loginForm.Visible = false;
                playGame.Show();
                labelMainFormText.Visible = false;
                label2MainForm.Visible = false;
                label3MainForm.Visible = false;
            }
            labelMainFormText.Visible = false;
            label2MainForm.Visible = false;
            label3MainForm.Visible = false;
            bunifuFlatButtonLogIn.Enabled = false;

        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelForms.Visible = true;
            this.panelForms.Controls.Add(playGame);
            registrationForm.Visible = false;
            loginForm.Visible = false;
            playGame.Show();
            labelMainFormText.Visible = false;
            label2MainForm.Visible = false;
            label3MainForm.Visible = false;

        }

        private void bunifuFlatButtonPersonalScores_Click(object sender, EventArgs e)
        {
            if (loginForm.login == true)
            {
                panelForms.Visible = true;
                this.panelForms.Controls.Add(personalScores);
                registrationForm.Visible = false;
                loginForm.Visible = false;
                playGame.Visible = false;
                personalScores.Show();
                labelMainFormText.Visible = false;
                label2MainForm.Visible = false;
                label3MainForm.Visible = false;
            }
            else
                MessageBox.Show("You must ne logged in to se your personal scores!");
            

        }

        private void bunifuFlatButtonTopPlayers_Click(object sender, EventArgs e)
        {
            panelForms.Visible = true;
            this.panelForms.Controls.Add(topPlayers);
            registrationForm.Visible = false;
            loginForm.Visible = false;
            playGame.Visible = false;
            personalScores.Visible = false;
            topPlayers.Show();
            labelMainFormText.Visible = false;
            label2MainForm.Visible = false;
            label3MainForm.Visible = false;
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (loginForm.login == true)
            {
                panelForms.Visible = true;
                this.panelForms.Controls.Add(achiv);
                registrationForm.Visible = false;
                loginForm.Visible = false;
                playGame.Visible = false;
                personalScores.Visible = false;
                topPlayers.Visible = false;
                achiv.Show();
                labelMainFormText.Visible = false;
                label2MainForm.Visible = false;
                label3MainForm.Visible = false;
            }
            else
                MessageBox.Show("You need to login first to see your Achievements!");
           
        }
    }
}

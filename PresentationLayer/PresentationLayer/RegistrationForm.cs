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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void txtUsername(object sender, EventArgs e)
        {
            bunifuTextboxUsername.text = "";
        }
        private void leaveUsername(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bunifuTextboxUsername.text))
                bunifuTextboxUsername.text = "Username";
        }
        private void txtPassword(object sender, EventArgs e)
        {
            bunifuTextboxPassword.text = "";
        }
        private void leavePassword(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bunifuTextboxPassword.text))
                bunifuTextboxPassword.text = "Password";
        }
        private void txtIGN(object sender, EventArgs e)
        {
            bunifuTextboxIGN.text = "";
        }
        private void leaveIGN(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(bunifuTextboxIGN.text))
                bunifuTextboxIGN.text = "IGN (In Game Name)";
        }
    }
}

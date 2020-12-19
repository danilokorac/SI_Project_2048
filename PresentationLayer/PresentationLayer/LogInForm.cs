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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void txtLogIn(object sender, EventArgs e)
        {
            bunifuTextboxUsernameLogIn.text = "";
        }

        private void leaveLogIn(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bunifuTextboxUsernameLogIn.text))
                bunifuTextboxUsernameLogIn.text = "Username";
        }

        private void passLogIn(object sender, EventArgs e)
        {
            bunifuTextboxPasswordLogIn.text = "";
        }

        private void leavepassLogIn(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bunifuTextboxPasswordLogIn.text))
                bunifuTextboxPasswordLogIn.text = "Password";
        }
    }
}

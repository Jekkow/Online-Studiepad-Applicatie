using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Studiepad.Logic;

namespace Studiepad.GUI
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            
        }

        // Login
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
         
        }

        // Invalid login error message will be hidden if user changes username/password
        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        int roleID = 0;

        private void StudentLoginButton_Click(object sender, EventArgs e)
        {
            roleID = 1;
            this.Hide();
            Main mainscreen = new Main(roleID);
            mainscreen.Show();
        }

        private void StudyCoachLoginButton_Click(object sender, EventArgs e)
        {
            roleID = 2;
            this.Hide();
            Main mainscreen = new Main(roleID);
            mainscreen.Show();
        }

        private void TeamleaderLoginButton_Click(object sender, EventArgs e)
        {
            roleID = 3;
            this.Hide();
            Main mainscreen = new Main(roleID);
            mainscreen.Show();
        }
    }
}

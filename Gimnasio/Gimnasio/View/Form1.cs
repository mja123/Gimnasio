using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gimnasio.Presenter;


namespace Gimnasio
{
    public partial class Form1 : Form, ILog
    {
        PresenterManage presenterManager = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogUp_Click(object sender, EventArgs e)
        {
            presenterManager = new PresenterManage(this, true);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            presenterManager = new PresenterManage(this, false);
        }

        string[] ILog.dataUser()
        {
            string[] userInformation = new string[2];
            userInformation[0] = txtUsername.Text;
            userInformation[1] = txtPassword.Text;
            Console.WriteLine(userInformation[0]);
            Console.WriteLine(userInformation[1]);
            return userInformation;
        }
        void ILog.createdUser(string result)
        {
            lblLogUp.Text = result;
        }
        void ILog.getUser(string result)
        {
            lblLogIn.Text = result;
        }
    }
}

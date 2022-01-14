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
    public partial class frmLog : Form, ILog
    {
        Presenter.LogManage logManager = null;
        View.frmTurns turns = null; 
        public frmLog()
        {
            InitializeComponent();
        }

        private void btnLogUp_Click(object sender, EventArgs e)
        {
            logManager = new LogManage(this, true);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            logManager = new LogManage(this, false);
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
        void ILog.createdUser(int result)
        {
            if (result == 409)
            {
                MessageBox.Show("Error al crear el usuario. Intente nuevamente", "Logup", MessageBoxButtons.OK);
            } else
            {
                MessageBox.Show("Usuario creado correctamente!", "Logup", MessageBoxButtons.OK);
            }
            
        }
        void ILog.getUser(int result)
        {
            if (result == 200)
            {
                turns = new View.frmTurns();
                this.Hide();
                turns.Show();
            } else
            {
                MessageBox.Show("Usuario no encontrado", "Login", MessageBoxButtons.OK);
            }
        }
    }
}

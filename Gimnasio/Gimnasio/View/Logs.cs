﻿using System;
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
        Presenter.LogManage logManager;              
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

            return userInformation;
        }
        void ILog.createdUser(int result)
        {
            switch (result)
            {
                case 201:
                    MessageBox.Show("Usuario creado correctamente!", "Logup", MessageBoxButtons.OK);
                    break;
                case 406:
                    MessageBox.Show("El usuario y la contraseña deben tener más de 3 caracteres", "Logup", MessageBoxButtons.OK);
                    break;
                case 409:
                    MessageBox.Show("Usuario no disponible", "Logup", MessageBoxButtons.OK);
                    break;
                case 414:
                    MessageBox.Show("Los datos exceden el número máximo de caracteres", "Logup", MessageBoxButtons.OK);
                    break;
                default:
                    MessageBox.Show("Error al crear el usuario. Intente nuevamente", "Logup", MessageBoxButtons.OK);
                    break;
            }
            
        }
        void ILog.getUser(int result)
        {
            switch(result)
            {
                case 404:
                    MessageBox.Show("Usuario no encontrado", "Login", MessageBoxButtons.OK);
                    break;
                case 406:
                    MessageBox.Show("El usuario y la contraseña deben tener más de 3 caracteres", "Login", MessageBoxButtons.OK);
                    break;
                case 500:
                    MessageBox.Show("Error en el sistema", "Login", MessageBoxButtons.OK);
                    break;
                default:
                    Console.WriteLine("userId in Logs {0}", result);
                    View.frmHome frmHome = new View.frmHome(txtUsername.Text, result);
                    this.Hide();
                    frmHome.Show();
                    break;
            }

        }
    }
}

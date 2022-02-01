using Gimnasio.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio.View
{
    public partial class frmHome : Form
    {
        private string username;
        private View.frmTurns turns;
        private View.frmPB pb;
        private int userId;
        public frmHome(string username, int userId)
        {
            //Se inicializan las variables y se concatena el nombre del usuario en el label de bienvenida.
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            lblWelcome.Text = "Bienvenido/a " + username;
        }

        private void btnTurns_Click(object sender, EventArgs e)
        {
            //Se transfiere el control a Turns
            turns = new frmTurns(username, userId);
            this.Hide();
            turns.Show();
        }

        private void btnPB_Click(object sender, EventArgs e)
        {
            //Se transfiere el control a PB
            pb = new frmPB(username, userId);
            this.Hide();
            pb.Show();
        }
    }
}

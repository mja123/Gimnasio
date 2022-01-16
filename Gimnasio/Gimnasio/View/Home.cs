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
        public frmHome(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void btnTurns_Click(object sender, EventArgs e)
        {
            turns = new frmTurns(username);
            this.Hide();
            turns.Show();
        }
    }
}

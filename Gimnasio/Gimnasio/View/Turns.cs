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
    public partial class frmTurns : Form, ITurns
    {
        private string username;
        private Presenter.TunsManage turnsManager;
        public frmTurns(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnMakeAnAppointment_Click(object sender, EventArgs e)
        {
            turnsManager = new Presenter.TunsManage(this);
        }

        int ITurns.appointmentTime()
        {
            return 0;
        }
    }
}

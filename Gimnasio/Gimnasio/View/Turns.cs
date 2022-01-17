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
        private Presenter.TunsManage turnsManager;
        private int userId;
        public frmTurns(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            Console.WriteLine(userId + " userId");
        }

        private void btnMakeAnAppointment_Click(object sender, EventArgs e)
        {
            
        }

        string ITurns.appointmentTime()
        {
            int indexHour;
            string turnHour;

            indexHour = cmbSchedule.SelectedIndex;
            if (indexHour == -1)
            {
                return "-1";
            }
            turnHour = cmbSchedule.Items[indexHour].ToString();

            Console.WriteLine(turnHour);
            return turnHour; 
        }

        void ITurns.createdTurn(int result)
        {
            switch(result)
            {
                case 201:
                    MessageBox.Show("Turno reservado correctamente!", "Reservar turno", MessageBoxButtons.OKCancel);
                    break;
                case 400:
                    MessageBox.Show("Debe ingresar un horario.", "Reservar turno", MessageBoxButtons.OKCancel);
                    break;
                default:
                    MessageBox.Show("Errro de servidor", "Reservar turno", MessageBoxButtons.OKCancel);
                    break;
            }
        }
        private void btnConfirmTurn_Click(object sender, EventArgs e)
        {

            turnsManager = new TunsManage(this, userId);
            turnsManager.createAppointment();
        }
    }
}

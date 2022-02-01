using Gimnasio.Presenter;
using System;
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
        private string username;
        private int userId;       
        public frmTurns(string username, int userId)
        {
            //Se inicializan las variables y se muestran los turnos que el usuario tiene reservados.
            InitializeComponent();
            turnsManager = new TunsManage(this, userId);
            this.username = username;
            this.userId = userId;
            turnsManager.getAllOfAppointments(userId);
        }

        string ITurns.appointmentDay()
        {
            //Obtiene el día del turno
            string selectedDay = cldTurnsCalendar.SelectionStart.ToShortDateString();
            return selectedDay;            
        }

        string ITurns.appointmentTime()
        {
            //Obtiene la hora del turno, valida si ha seleccionado alguna, de se así, la convierte a string.
            int indexHour;
            string turnHour;

            indexHour = cmbSchedule.SelectedIndex;
            if (indexHour == -1)
            {
                return "-1";
            }
            turnHour = cmbSchedule.Items[indexHour].ToString();
          
            return turnHour; 
        }

        void ITurns.createdTurn(int result)
        {
            //Responde al usuario según cómo se llevó a cabo la reserva del turno.
            switch(result)
            {
                case 201:
                    MessageBox.Show("Turno reservado correctamente!", "Reservar turno", MessageBoxButtons.OKCancel);
                    break;
                case 400:
                    MessageBox.Show("Debe ingresar un horario.", "Reservar turno", MessageBoxButtons.OKCancel);
                    break;
                case 409:
                    MessageBox.Show("El turno ya existe", "Reservar turno", MessageBoxButtons.OKCancel);
                    break;
                default:
                    MessageBox.Show("Errro de servidor", "Reservar turno", MessageBoxButtons.OKCancel);
                    break;
            }
        }

        void ITurns.getTurns(DataTable appointments)
        {
            //Muestra los turnos del usuario.
            dgvTunsHistorial.DataSource = appointments;
        }

        void ITurns.deletedTurn(int result)
        {
            //Responde al usuario según cómo se llevó a cabo la eliminación del turno.
            switch (result)
            {
                case 200:
                    MessageBox.Show("Turno eliminado correctamente!", "Eliminar turno", MessageBoxButtons.OKCancel);
                    break;
                case 404:
                    MessageBox.Show("Turno no encontrado.", "Eliminar turno", MessageBoxButtons.OKCancel);
                    break;
                default:
                    MessageBox.Show("Errro de servidor", "Eliminar turno", MessageBoxButtons.OKCancel);
                    break;
            }
        }
        private void btnConfirmTurn_Click(object sender, EventArgs e)
        {
            //Se llama al método del Presenter encargado de la creación del turno.
            turnsManager.createAppointment();
        }

        private void btnTurnCancel_Click(object sender, EventArgs e)
        {
            //Confirma si se quiere eliminar el turno.
            DialogResult confirm;
            confirm = MessageBox.Show("Se eliminará un turno", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm ==  DialogResult.Yes)
            {
                turnsManager.deleteAppointment();
            }
        }

        private void btnHistorialRefresh_Click(object sender, EventArgs e)
        {
            //Actualiza la tabla de turnos.
            turnsManager.getAllOfAppointments(userId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Vuelve al Home.
            View.frmHome home = new View.frmHome(username, userId);
            this.Hide();
            home.Show();
        }
        private void TODO()
        {
            /*
            TODO:
                DONE- Hashear contraseña
                
                - Frontend
                DONE- Validaciones de si el turno existe
                DONE- Validaciones en presenters
                DONE- Vaciar los txt luego de ingresados en pb
                DONE- Validación de máximo número de caracteres en la contraseña
                DONE- Confirmar eliminar
             */
        }
    }
}

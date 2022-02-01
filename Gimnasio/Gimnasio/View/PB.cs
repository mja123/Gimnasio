using Gimnasio.Presenter;
using System;
using System.Collections;
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
    public partial class frmPB : Form, IPB
    {
        private int userId;
        private string username;
        private Presenter.PBsManage pbManager;       
        public frmPB(string username, int userId)
        {
            //Se inicializan las variables y se muestran los PB del usuario.
            InitializeComponent();
            pbManager = new Presenter.PBsManage(this, userId);
            pbManager.getAllOfPBs();
            this.userId = userId;
            this.username = username;
        }

        ArrayList IPB.createData()
        {
            //Crea un ArrayList con los datos necesarios del PB.
            ArrayList pbData = new ArrayList();

            pbData.Add(txtExercise.Text);
            txtExercise.Text = ""; 
            try
            {
                //Valida si el texto ingresado es un entero y si no está vacío.
                pbData.Add(Convert.ToInt32(txtWeight.Text));
                txtWeight.Text = "";

                pbData.Add(Convert.ToInt32(txtReps.Text));
                txtReps.Text = "";

                return pbData;
            } catch (Exception e)
            {
                txtWeight.Text = "";
                txtReps.Text = "";
                Console.WriteLine(e.Message);               
            }
            return pbData;            
        }
        void IPB.pbCreated(int result)
        {
            //Responde al usuario según cómo se llevó a cabo la creación del PB.
            switch (result)
            {
                case 201:
                    MessageBox.Show("PB creado correctamente!", "Crear PB", MessageBoxButtons.OKCancel);
                    break;
                case 400:
                    MessageBox.Show("El PB ingresado ya existe!", "Crear PB", MessageBoxButtons.OKCancel);
                    break;
                case 404:
                    MessageBox.Show("Debe ingresar todos los datos.", "Crear PB", MessageBoxButtons.OKCancel);
                    break;
                case 409:
                    MessageBox.Show("El peso y las repeticiones deben ser números enteros.", "Crear PB", MessageBoxButtons.OKCancel);
                    break;
                case 414:
                    MessageBox.Show("El número de caracteres excede el máximo", "Crear PB", MessageBoxButtons.OKCancel);
                    break;
                default:
                    MessageBox.Show("Errro de servidor", "Crear PB", MessageBoxButtons.OKCancel);
                    break;
            }
        }
        string IPB.filterDelete()
        {
            //Obtiene el ejercicio que se desea filtrar.
            string execise = txtFilter.Text;
            txtFilter.Text = "";
            return execise;
        }
        void IPB.pbsGet(DataTable pbs)
        {
            //Muestra los PBs del usuario.
            dgvPbs.DataSource = pbs;          
        }
        void IPB.pbGet(DataTable pb)
        {
            //Muestra los PB de un ejercicio en específico.
            if (pb.Rows.Count > 0)
            {
                dgvPbs.DataSource = pb;
            } else
            {
                MessageBox.Show("PB no encontrado.", "Filtrar PB", MessageBoxButtons.OKCancel);
            }
        }
        void IPB.pbsDeleted(int result)
        {
            //Responde al usuario según cómo se llevó a cabo la eliminación del PB.
            switch (result)
            {
                case 200:
                    MessageBox.Show("PB eliminado correctamente!", "Eliminar PB", MessageBoxButtons.OKCancel);
                    break;
                case 404:
                    MessageBox.Show("PB no encontrado.", "Eliminar PB", MessageBoxButtons.OKCancel);
                    break;
                default:
                    MessageBox.Show("Errro de servidor", "Eliminar PB", MessageBoxButtons.OKCancel);
                    break;
            }
        }

        void IPB.pbDeleted(int result)
        {
            if (result == 200)
            {
                dgvPbs.Rows.Remove(dgvPbs.CurrentRow);
            } else
            {
                MessageBox.Show("Errro de servidor", "Eliminar PB", MessageBoxButtons.OKCancel);
            }           
        }
        ArrayList IPB.pbDataToDelete()
        {
            ArrayList pbSelected = new ArrayList();
            int rowSelected = dgvPbs.CurrentRow.Index;

            for (int i = 0; i < dgvPbs.Rows[rowSelected].Cells.Count; i++)
            {               
                pbSelected.Add(dgvPbs.Rows[rowSelected].Cells[i].Value);
            }

            return pbSelected;
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Llama al método del Presenter que crea el PB.
            pbManager.createPB();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //Llama al método del Presenter que filtra el PB.
            pbManager.filterPB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Prgunta si desea eliminar el ejercicio.
            DialogResult confirm = MessageBox.Show("Se eliminaran todos los PBs del ejercicio", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                pbManager.deletePBExercise();
            }           
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Actualiza la tabla.
            pbManager.getAllOfPBs();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            //Se pasa el control a Home.
            View.frmHome home = new frmHome(username, userId);
            this.Hide();
            home.Show();
        }

        private void btnDeleteOneRow_Click(object sender, EventArgs e)
        {
            //Prgunta si desea eliminar el PB.
            DialogResult confirm = MessageBox.Show("Se eliminará un PB", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                pbManager.deletePb();
            }
             
        }
    }
}

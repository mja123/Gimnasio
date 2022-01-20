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
            InitializeComponent();
            pbManager = new Presenter.PBsManage(this, userId);
            pbManager.getAllOfPBs();
            this.userId = userId;
            this.username = username;
        }

        ArrayList IPB.createData()
        {
            ArrayList pbData = new ArrayList();

            pbData.Add(txtExercise.Text);
            txtExercise.Text = ""; 
            pbData.Add(txtWeight.Text);
            txtWeight.Text = "";
            pbData.Add(txtReps.Text);
            txtReps.Text = "";

            return pbData;
        }
        void IPB.pbCreated(int result)
        {
            switch (result)
            {
                case 201:
                    MessageBox.Show("PB creado correctamente!", "Crear PB", MessageBoxButtons.OKCancel);
                    break;
                case 404:
                    MessageBox.Show("Debe ingresar todos los datos.", "Crear PB", MessageBoxButtons.OKCancel);
                    break;
                default:
                    MessageBox.Show("Errro de servidor", "Crear PB", MessageBoxButtons.OKCancel);
                    break;
            }
        }
        string IPB.filterDelete()
        {
            string execise = txtFilter.Text;
            txtFilter.Text = "";
            return execise;
        }
        void IPB.pbGet(DataTable pb)
        {
            if (pb.Rows.Count > 0)
            {
                dgvPbs.DataSource = pb;
            } else
            {
                MessageBox.Show("PB no encontrado.", "Filtrar PB", MessageBoxButtons.OKCancel);
            }
        }
        void IPB.pbDeleted(int result)
        {
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

        void IPB.pbsGet(DataTable pbs)
        {
            dgvPbs.DataSource = pbs;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            pbManager.createPB();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            pbManager.filterPB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult confirm = MessageBox.Show("Se eliminará un PB", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                pbManager.deletePB();
            }
            
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            View.frmHome home = new frmHome(username, userId);
            this.Hide();
            home.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            pbManager.getAllOfPBs();
        }
    }
}


namespace Gimnasio.View
{
    partial class frmTurns
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.btnMakeAnAppointment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Location = new System.Drawing.Point(122, 47);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(274, 13);
            this.lblWelcomeTitle.TabIndex = 0;
            this.lblWelcomeTitle.Text = "Bienvenido/a a nuestro gestor de turnos para Gym UDA!";
            // 
            // btnMakeAnAppointment
            // 
            this.btnMakeAnAppointment.Location = new System.Drawing.Point(65, 98);
            this.btnMakeAnAppointment.Name = "btnMakeAnAppointment";
            this.btnMakeAnAppointment.Size = new System.Drawing.Size(91, 23);
            this.btnMakeAnAppointment.TabIndex = 1;
            this.btnMakeAnAppointment.Text = "Reservar turno";
            this.btnMakeAnAppointment.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Historial de reservas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(367, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar reserva";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmTurns
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(516, 171);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMakeAnAppointment);
            this.Controls.Add(this.lblWelcomeTitle);
            this.Name = "frmTurns";
            this.Text = "Gestor de turnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeTitle;
        private System.Windows.Forms.Button btnMakeAnAppointment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
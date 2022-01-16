
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
            this.btnMakeAnAppointment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnMakeAnAppointment
            // 
            this.btnMakeAnAppointment.Location = new System.Drawing.Point(12, 40);
            this.btnMakeAnAppointment.Name = "btnMakeAnAppointment";
            this.btnMakeAnAppointment.Size = new System.Drawing.Size(119, 23);
            this.btnMakeAnAppointment.TabIndex = 1;
            this.btnMakeAnAppointment.Text = "Reservar turno";
            this.btnMakeAnAppointment.UseVisualStyleBackColor = true;
            this.btnMakeAnAppointment.Click += new System.EventHandler(this.btnMakeAnAppointment_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Historial de reservas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar reserva";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.cmbSchedule.Location = new System.Drawing.Point(12, 80);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(121, 21);
            this.cmbSchedule.TabIndex = 4;
            this.cmbSchedule.Text = "Horarios";
            // 
            // frmTurns
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(637, 355);
            this.Controls.Add(this.cmbSchedule);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMakeAnAppointment);
            this.Name = "frmTurns";
            this.Text = "Gestor de turnos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMakeAnAppointment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbSchedule;
    }
}
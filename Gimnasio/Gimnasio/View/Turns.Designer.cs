
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
            this.btnHistorialRefresh = new System.Windows.Forms.Button();
            this.btnTurnCancel = new System.Windows.Forms.Button();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.btnConfirmTurn = new System.Windows.Forms.Button();
            this.dgvTunsHistorial = new System.Windows.Forms.DataGridView();
            this.lblReserve = new System.Windows.Forms.Label();
            this.cldTurnsCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTunsHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHistorialRefresh
            // 
            this.btnHistorialRefresh.Location = new System.Drawing.Point(607, 452);
            this.btnHistorialRefresh.Name = "btnHistorialRefresh";
            this.btnHistorialRefresh.Size = new System.Drawing.Size(119, 23);
            this.btnHistorialRefresh.TabIndex = 2;
            this.btnHistorialRefresh.Text = "Actualizar";
            this.btnHistorialRefresh.UseVisualStyleBackColor = true;
            this.btnHistorialRefresh.Click += new System.EventHandler(this.btnHistorialRefresh_Click);
            // 
            // btnTurnCancel
            // 
            this.btnTurnCancel.Location = new System.Drawing.Point(170, 294);
            this.btnTurnCancel.Name = "btnTurnCancel";
            this.btnTurnCancel.Size = new System.Drawing.Size(119, 26);
            this.btnTurnCancel.TabIndex = 3;
            this.btnTurnCancel.Text = "Cancelar reserva";
            this.btnTurnCancel.UseVisualStyleBackColor = true;
            this.btnTurnCancel.Click += new System.EventHandler(this.btnTurnCancel_Click);
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
            this.cmbSchedule.Location = new System.Drawing.Point(41, 92);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(121, 21);
            this.cmbSchedule.TabIndex = 4;
            this.cmbSchedule.Text = "Horarios";
            // 
            // btnConfirmTurn
            // 
            this.btnConfirmTurn.Location = new System.Drawing.Point(41, 294);
            this.btnConfirmTurn.Name = "btnConfirmTurn";
            this.btnConfirmTurn.Size = new System.Drawing.Size(94, 26);
            this.btnConfirmTurn.TabIndex = 5;
            this.btnConfirmTurn.Text = "Confirmar";
            this.btnConfirmTurn.UseVisualStyleBackColor = true;
            this.btnConfirmTurn.Click += new System.EventHandler(this.btnConfirmTurn_Click);
            // 
            // dgvTunsHistorial
            // 
            this.dgvTunsHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTunsHistorial.Location = new System.Drawing.Point(523, 92);
            this.dgvTunsHistorial.Name = "dgvTunsHistorial";
            this.dgvTunsHistorial.Size = new System.Drawing.Size(243, 344);
            this.dgvTunsHistorial.TabIndex = 6;
            // 
            // lblReserve
            // 
            this.lblReserve.AutoSize = true;
            this.lblReserve.Location = new System.Drawing.Point(140, 54);
            this.lblReserve.Name = "lblReserve";
            this.lblReserve.Size = new System.Drawing.Size(50, 13);
            this.lblReserve.TabIndex = 7;
            this.lblReserve.Text = "Reservar";
            // 
            // cldTurnsCalendar
            // 
            this.cldTurnsCalendar.Location = new System.Drawing.Point(41, 125);
            this.cldTurnsCalendar.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.cldTurnsCalendar.MaxSelectionCount = 1;
            this.cldTurnsCalendar.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.cldTurnsCalendar.Name = "cldTurnsCalendar";
            this.cldTurnsCalendar.TabIndex = 8;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(604, 54);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(102, 13);
            this.lblHistorial.TabIndex = 9;
            this.lblHistorial.Text = "Historial de reservas";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(41, 452);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTurns
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(842, 503);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.cldTurnsCalendar);
            this.Controls.Add(this.lblReserve);
            this.Controls.Add(this.dgvTunsHistorial);
            this.Controls.Add(this.btnConfirmTurn);
            this.Controls.Add(this.cmbSchedule);
            this.Controls.Add(this.btnTurnCancel);
            this.Controls.Add(this.btnHistorialRefresh);
            this.Name = "frmTurns";
            this.Text = "Gestor de turnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTunsHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHistorialRefresh;
        private System.Windows.Forms.Button btnTurnCancel;
        private System.Windows.Forms.ComboBox cmbSchedule;
        private System.Windows.Forms.Button btnConfirmTurn;
        private System.Windows.Forms.DataGridView dgvTunsHistorial;
        private System.Windows.Forms.Label lblReserve;
        private System.Windows.Forms.MonthCalendar cldTurnsCalendar;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button btnBack;
    }
}

namespace Gimnasio.View
{
    partial class frmPB
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
            this.dgvPbs = new System.Windows.Forms.DataGridView();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblExercise = new System.Windows.Forms.Label();
            this.lblReps = new System.Windows.Forms.Label();
            this.txtExercise = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtReps = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gpbPBAdd = new System.Windows.Forms.GroupBox();
            this.gpbPBFilter = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteOneRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPbs)).BeginInit();
            this.gpbPBAdd.SuspendLayout();
            this.gpbPBFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPbs
            // 
            this.dgvPbs.AllowUserToAddRows = false;
            this.dgvPbs.AllowUserToDeleteRows = false;
            this.dgvPbs.AllowUserToResizeColumns = false;
            this.dgvPbs.AllowUserToResizeRows = false;
            this.dgvPbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPbs.Location = new System.Drawing.Point(112, 24);
            this.dgvPbs.Name = "dgvPbs";
            this.dgvPbs.ReadOnly = true;
            this.dgvPbs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPbs.Size = new System.Drawing.Size(343, 150);
            this.dgvPbs.TabIndex = 0;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(180, 27);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(31, 13);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Peso";
            // 
            // lblExercise
            // 
            this.lblExercise.AutoSize = true;
            this.lblExercise.Location = new System.Drawing.Point(43, 27);
            this.lblExercise.Name = "lblExercise";
            this.lblExercise.Size = new System.Drawing.Size(47, 13);
            this.lblExercise.TabIndex = 2;
            this.lblExercise.Text = "Ejercicio";
            // 
            // lblReps
            // 
            this.lblReps.AutoSize = true;
            this.lblReps.Location = new System.Drawing.Point(311, 27);
            this.lblReps.Name = "lblReps";
            this.lblReps.Size = new System.Drawing.Size(69, 13);
            this.lblReps.TabIndex = 3;
            this.lblReps.Text = "Repeticiones";
            // 
            // txtExercise
            // 
            this.txtExercise.Location = new System.Drawing.Point(46, 43);
            this.txtExercise.Name = "txtExercise";
            this.txtExercise.Size = new System.Drawing.Size(100, 20);
            this.txtExercise.TabIndex = 4;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(183, 43);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 5;
            // 
            // txtReps
            // 
            this.txtReps.Location = new System.Drawing.Point(314, 43);
            this.txtReps.Name = "txtReps";
            this.txtReps.Size = new System.Drawing.Size(100, 20);
            this.txtReps.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmit.Location = new System.Drawing.Point(183, 80);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Agregar";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gpbPBAdd
            // 
            this.gpbPBAdd.Controls.Add(this.btnSubmit);
            this.gpbPBAdd.Controls.Add(this.txtReps);
            this.gpbPBAdd.Controls.Add(this.txtWeight);
            this.gpbPBAdd.Controls.Add(this.txtExercise);
            this.gpbPBAdd.Controls.Add(this.lblReps);
            this.gpbPBAdd.Controls.Add(this.lblExercise);
            this.gpbPBAdd.Controls.Add(this.lblWeight);
            this.gpbPBAdd.Location = new System.Drawing.Point(80, 228);
            this.gpbPBAdd.Name = "gpbPBAdd";
            this.gpbPBAdd.Size = new System.Drawing.Size(444, 123);
            this.gpbPBAdd.TabIndex = 8;
            this.gpbPBAdd.TabStop = false;
            this.gpbPBAdd.Text = "Agregar";
            // 
            // gpbPBFilter
            // 
            this.gpbPBFilter.Controls.Add(this.btnDelete);
            this.gpbPBFilter.Controls.Add(this.txtFilter);
            this.gpbPBFilter.Controls.Add(this.btnFilter);
            this.gpbPBFilter.Location = new System.Drawing.Point(80, 366);
            this.gpbPBFilter.Name = "gpbPBFilter";
            this.gpbPBFilter.Size = new System.Drawing.Size(444, 44);
            this.gpbPBFilter.TabIndex = 9;
            this.gpbPBFilter.TabStop = false;
            this.gpbPBFilter.Text = "Buscar ejercicio";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Eliminar ejercicio";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(46, 18);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 8;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(183, 15);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(12, 417);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 10;
            this.btnGoBack.Text = "Volver";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(172, 189);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteOneRow
            // 
            this.btnDeleteOneRow.Location = new System.Drawing.Point(328, 189);
            this.btnDeleteOneRow.Name = "btnDeleteOneRow";
            this.btnDeleteOneRow.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteOneRow.TabIndex = 12;
            this.btnDeleteOneRow.Text = "Eliminar una fila";
            this.btnDeleteOneRow.UseVisualStyleBackColor = true;
            this.btnDeleteOneRow.Click += new System.EventHandler(this.btnDeleteOneRow_Click);
            // 
            // frmPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(596, 464);
            this.Controls.Add(this.btnDeleteOneRow);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.gpbPBFilter);
            this.Controls.Add(this.gpbPBAdd);
            this.Controls.Add(this.dgvPbs);
            this.Name = "frmPB";
            this.Text = "PB";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPbs)).EndInit();
            this.gpbPBAdd.ResumeLayout(false);
            this.gpbPBAdd.PerformLayout();
            this.gpbPBFilter.ResumeLayout(false);
            this.gpbPBFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPbs;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblExercise;
        private System.Windows.Forms.Label lblReps;
        private System.Windows.Forms.TextBox txtExercise;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtReps;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gpbPBAdd;
        private System.Windows.Forms.GroupBox gpbPBFilter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteOneRow;
    }
}
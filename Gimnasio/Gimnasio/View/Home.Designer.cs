
namespace Gimnasio.View
{
    partial class frmHome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnTurns = new System.Windows.Forms.Button();
            this.btnPB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(223, 42);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(71, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bienvenido/a";
            // 
            // btnTurns
            // 
            this.btnTurns.Location = new System.Drawing.Point(71, 94);
            this.btnTurns.Name = "btnTurns";
            this.btnTurns.Size = new System.Drawing.Size(97, 23);
            this.btnTurns.TabIndex = 1;
            this.btnTurns.Text = "Gestor de turnos";
            this.btnTurns.UseVisualStyleBackColor = true;
            this.btnTurns.Click += new System.EventHandler(this.btnTurns_Click);
            // 
            // btnPB
            // 
            this.btnPB.Location = new System.Drawing.Point(327, 94);
            this.btnPB.Name = "btnPB";
            this.btnPB.Size = new System.Drawing.Size(94, 23);
            this.btnPB.TabIndex = 2;
            this.btnPB.Text = "Mis PB";
            this.btnPB.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 171);
            this.Controls.Add(this.btnPB);
            this.Controls.Add(this.btnTurns);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnTurns;
        private System.Windows.Forms.Button btnPB;
    }
}
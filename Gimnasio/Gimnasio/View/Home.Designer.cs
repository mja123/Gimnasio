
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnTurns = new System.Windows.Forms.Button();
            this.btnPB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblWelcome.Location = new System.Drawing.Point(119, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(114, 22);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bienvenido/a";
            // 
            // btnTurns
            // 
            this.btnTurns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.btnTurns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTurns.Location = new System.Drawing.Point(22, 62);
            this.btnTurns.Name = "btnTurns";
            this.btnTurns.Size = new System.Drawing.Size(97, 23);
            this.btnTurns.TabIndex = 1;
            this.btnTurns.Text = "Gestor de turnos";
            this.btnTurns.UseVisualStyleBackColor = false;
            this.btnTurns.Click += new System.EventHandler(this.btnTurns_Click);
            // 
            // btnPB
            // 
            this.btnPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnPB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPB.Location = new System.Drawing.Point(283, 62);
            this.btnPB.Name = "btnPB";
            this.btnPB.Size = new System.Drawing.Size(94, 23);
            this.btnPB.TabIndex = 2;
            this.btnPB.Text = "Mis PB";
            this.btnPB.UseVisualStyleBackColor = false;
            this.btnPB.Click += new System.EventHandler(this.btnPB_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(397, 305);
            this.Controls.Add(this.btnPB);
            this.Controls.Add(this.btnTurns);
            this.Controls.Add(this.lblWelcome);
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTurns;
        private System.Windows.Forms.Button btnPB;
        public System.Windows.Forms.Label lblWelcome;
    }
}
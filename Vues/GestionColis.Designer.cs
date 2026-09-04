namespace Vues
{
    partial class GestionColis
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dtpLiv = new System.Windows.Forms.DateTimePicker();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.cbProds = new System.Windows.Forms.ComboBox();
            this.dgvColis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(63, 306);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dtpLiv
            // 
            this.dtpLiv.Location = new System.Drawing.Point(120, 93);
            this.dtpLiv.Name = "dtpLiv";
            this.dtpLiv.Size = new System.Drawing.Size(200, 22);
            this.dtpLiv.TabIndex = 1;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(117, 44);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 2;
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(120, 147);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(100, 22);
            this.txtQte.TabIndex = 3;
            // 
            // cbProds
            // 
            this.cbProds.FormattingEnabled = true;
            this.cbProds.Location = new System.Drawing.Point(126, 193);
            this.cbProds.Name = "cbProds";
            this.cbProds.Size = new System.Drawing.Size(210, 24);
            this.cbProds.TabIndex = 4;
            // 
            // dgvColis
            // 
            this.dgvColis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColis.Location = new System.Drawing.Point(407, 31);
            this.dgvColis.Name = "dgvColis";
            this.dgvColis.RowHeadersWidth = 51;
            this.dgvColis.RowTemplate.Height = 24;
            this.dgvColis.Size = new System.Drawing.Size(546, 287);
            this.dgvColis.TabIndex = 5;
            // 
            // GestionColis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 482);
            this.Controls.Add(this.dgvColis);
            this.Controls.Add(this.cbProds);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.dtpLiv);
            this.Controls.Add(this.btnAjouter);
            this.Name = "GestionColis";
            this.Text = "GestionColis";
            this.Load += new System.EventHandler(this.GestionColis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DateTimePicker dtpLiv;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.ComboBox cbProds;
        private System.Windows.Forms.DataGridView dgvColis;
    }
}
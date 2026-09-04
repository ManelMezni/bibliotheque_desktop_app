namespace Vues
{
    partial class GestionProduits
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAjouterProdConstant = new System.Windows.Forms.Button();
            this.txtRefernce = new System.Windows.Forms.TextBox();
            this.txtDesg = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtPRix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAjouterProdReel = new System.Windows.Forms.Button();
            this.btnAJouterDAO = new System.Windows.Forms.Button();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouterProdConstant
            // 
            this.btnAjouterProdConstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterProdConstant.Location = new System.Drawing.Point(41, 310);
            this.btnAjouterProdConstant.Name = "btnAjouterProdConstant";
            this.btnAjouterProdConstant.Size = new System.Drawing.Size(355, 99);
            this.btnAjouterProdConstant.TabIndex = 0;
            this.btnAjouterProdConstant.Text = "Ajouter Prod avec des valeurs constantes";
            this.btnAjouterProdConstant.UseVisualStyleBackColor = true;
            this.btnAjouterProdConstant.Click += new System.EventHandler(this.btnAjouterProdConstant_Click);
            // 
            // txtRefernce
            // 
            this.txtRefernce.Location = new System.Drawing.Point(165, 43);
            this.txtRefernce.Name = "txtRefernce";
            this.txtRefernce.Size = new System.Drawing.Size(100, 22);
            this.txtRefernce.TabIndex = 1;
            // 
            // txtDesg
            // 
            this.txtDesg.Location = new System.Drawing.Point(150, 110);
            this.txtDesg.Name = "txtDesg";
            this.txtDesg.Size = new System.Drawing.Size(100, 22);
            this.txtDesg.TabIndex = 2;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(150, 176);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(100, 22);
            this.txtQuantite.TabIndex = 3;
            // 
            // txtPRix
            // 
            this.txtPRix.Location = new System.Drawing.Point(150, 230);
            this.txtPRix.Name = "txtPRix";
            this.txtPRix.Size = new System.Drawing.Size(100, 22);
            this.txtPRix.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Réference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Designation";
            // 
            // btnAjouterProdReel
            // 
            this.btnAjouterProdReel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterProdReel.Location = new System.Drawing.Point(435, 310);
            this.btnAjouterProdReel.Name = "btnAjouterProdReel";
            this.btnAjouterProdReel.Size = new System.Drawing.Size(355, 99);
            this.btnAjouterProdReel.TabIndex = 9;
            this.btnAjouterProdReel.Text = "Ajouter Prod avec des valeurs  réelles";
            this.btnAjouterProdReel.UseVisualStyleBackColor = true;
            this.btnAjouterProdReel.Click += new System.EventHandler(this.btnAjouterProdReel_Click);
            // 
            // btnAJouterDAO
            // 
            this.btnAJouterDAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAJouterDAO.Location = new System.Drawing.Point(796, 310);
            this.btnAJouterDAO.Name = "btnAJouterDAO";
            this.btnAJouterDAO.Size = new System.Drawing.Size(355, 99);
            this.btnAJouterDAO.TabIndex = 10;
            this.btnAJouterDAO.Text = "Ajouter avec DAO";
            this.btnAJouterDAO.UseVisualStyleBackColor = true;
            this.btnAJouterDAO.Click += new System.EventHandler(this.btnAJouterDAO_Click);
            // 
            // dgvProduits
            // 
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Location = new System.Drawing.Point(368, 24);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.RowHeadersWidth = 51;
            this.dgvProduits.RowTemplate.Height = 24;
            this.dgvProduits.Size = new System.Drawing.Size(767, 236);
            this.dgvProduits.TabIndex = 11;
            // 
            // GestionProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 468);
            this.Controls.Add(this.dgvProduits);
            this.Controls.Add(this.btnAJouterDAO);
            this.Controls.Add(this.btnAjouterProdReel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPRix);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.txtDesg);
            this.Controls.Add(this.txtRefernce);
            this.Controls.Add(this.btnAjouterProdConstant);
            this.Name = "GestionProduits";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GestionProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterProdConstant;
        private System.Windows.Forms.TextBox txtRefernce;
        private System.Windows.Forms.TextBox txtDesg;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtPRix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAjouterProdReel;
        private System.Windows.Forms.Button btnAJouterDAO;
        private System.Windows.Forms.DataGridView dgvProduits;
    }
}


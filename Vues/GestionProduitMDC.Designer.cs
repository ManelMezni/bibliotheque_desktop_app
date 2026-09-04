namespace Vues
{
    partial class GestionProduitMDC
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
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.btnAJouterDAO = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPRix = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtDesg = new System.Windows.Forms.TextBox();
            this.txtRefernce = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dgvProdsLinq = new System.Windows.Forms.DataGridView();
            this.btnChercherParPrix = new System.Windows.Forms.Button();
            this.dgvProdLinqDT = new System.Windows.Forms.DataGridView();
            this.btnChercherParPrixDT = new System.Windows.Forms.Button();
            this.btnSuppressionRef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdsLinq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdLinqDT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduits
            // 
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Location = new System.Drawing.Point(372, 59);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.RowHeadersWidth = 51;
            this.dgvProduits.RowTemplate.Height = 24;
            this.dgvProduits.Size = new System.Drawing.Size(767, 236);
            this.dgvProduits.TabIndex = 21;
            // 
            // btnAJouterDAO
            // 
            this.btnAJouterDAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAJouterDAO.Location = new System.Drawing.Point(12, 328);
            this.btnAJouterDAO.Name = "btnAJouterDAO";
            this.btnAJouterDAO.Size = new System.Drawing.Size(257, 99);
            this.btnAJouterDAO.TabIndex = 20;
            this.btnAJouterDAO.Text = "Ajouter avec DAO";
            this.btnAJouterDAO.UseVisualStyleBackColor = true;
            this.btnAJouterDAO.Click += new System.EventHandler(this.btnAJouterDAO_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quantite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Réference";
            // 
            // txtPRix
            // 
            this.txtPRix.Location = new System.Drawing.Point(154, 265);
            this.txtPRix.Name = "txtPRix";
            this.txtPRix.Size = new System.Drawing.Size(100, 22);
            this.txtPRix.TabIndex = 15;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(154, 211);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(100, 22);
            this.txtQuantite.TabIndex = 14;
            // 
            // txtDesg
            // 
            this.txtDesg.Location = new System.Drawing.Point(154, 145);
            this.txtDesg.Name = "txtDesg";
            this.txtDesg.Size = new System.Drawing.Size(100, 22);
            this.txtDesg.TabIndex = 13;
            // 
            // txtRefernce
            // 
            this.txtRefernce.Location = new System.Drawing.Point(169, 78);
            this.txtRefernce.Name = "txtRefernce";
            this.txtRefernce.Size = new System.Drawing.Size(100, 22);
            this.txtRefernce.TabIndex = 12;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 433);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(257, 99);
            this.btnEnregistrer.TabIndex = 22;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // dgvProdsLinq
            // 
            this.dgvProdsLinq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdsLinq.Location = new System.Drawing.Point(372, 319);
            this.dgvProdsLinq.Name = "dgvProdsLinq";
            this.dgvProdsLinq.RowHeadersWidth = 51;
            this.dgvProdsLinq.RowTemplate.Height = 24;
            this.dgvProdsLinq.Size = new System.Drawing.Size(461, 236);
            this.dgvProdsLinq.TabIndex = 23;
            // 
            // btnChercherParPrix
            // 
            this.btnChercherParPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercherParPrix.Location = new System.Drawing.Point(12, 538);
            this.btnChercherParPrix.Name = "btnChercherParPrix";
            this.btnChercherParPrix.Size = new System.Drawing.Size(257, 99);
            this.btnChercherParPrix.TabIndex = 24;
            this.btnChercherParPrix.Text = "Chercher Par Prix";
            this.btnChercherParPrix.UseVisualStyleBackColor = true;
            this.btnChercherParPrix.Click += new System.EventHandler(this.btnChercherParPrix_Click);
            // 
            // dgvProdLinqDT
            // 
            this.dgvProdLinqDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdLinqDT.Location = new System.Drawing.Point(856, 319);
            this.dgvProdLinqDT.Name = "dgvProdLinqDT";
            this.dgvProdLinqDT.RowHeadersWidth = 51;
            this.dgvProdLinqDT.RowTemplate.Height = 24;
            this.dgvProdLinqDT.Size = new System.Drawing.Size(461, 236);
            this.dgvProdLinqDT.TabIndex = 25;
            // 
            // btnChercherParPrixDT
            // 
            this.btnChercherParPrixDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercherParPrixDT.Location = new System.Drawing.Point(985, 561);
            this.btnChercherParPrixDT.Name = "btnChercherParPrixDT";
            this.btnChercherParPrixDT.Size = new System.Drawing.Size(257, 85);
            this.btnChercherParPrixDT.TabIndex = 26;
            this.btnChercherParPrixDT.Text = "Chercher Par Prix dans DatTable";
            this.btnChercherParPrixDT.UseVisualStyleBackColor = true;
            this.btnChercherParPrixDT.Click += new System.EventHandler(this.btnChercherParPrixDT_Click);
            // 
            // btnSuppressionRef
            // 
            this.btnSuppressionRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppressionRef.Location = new System.Drawing.Point(478, 561);
            this.btnSuppressionRef.Name = "btnSuppressionRef";
            this.btnSuppressionRef.Size = new System.Drawing.Size(257, 85);
            this.btnSuppressionRef.TabIndex = 27;
            this.btnSuppressionRef.Text = "Supprimer par Référence";
            this.btnSuppressionRef.UseVisualStyleBackColor = true;
            this.btnSuppressionRef.Click += new System.EventHandler(this.btnSuppressionRef_Click);
            // 
            // GestionProduitMDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 689);
            this.Controls.Add(this.btnSuppressionRef);
            this.Controls.Add(this.btnChercherParPrixDT);
            this.Controls.Add(this.dgvProdLinqDT);
            this.Controls.Add(this.btnChercherParPrix);
            this.Controls.Add(this.dgvProdsLinq);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dgvProduits);
            this.Controls.Add(this.btnAJouterDAO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPRix);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.txtDesg);
            this.Controls.Add(this.txtRefernce);
            this.Name = "GestionProduitMDC";
            this.Text = "GestionProduitMDC";
            this.Load += new System.EventHandler(this.GestionProduitMDC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdsLinq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdLinqDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.Button btnAJouterDAO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPRix;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtDesg;
        private System.Windows.Forms.TextBox txtRefernce;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridView dgvProdsLinq;
        private System.Windows.Forms.Button btnChercherParPrix;
        private System.Windows.Forms.DataGridView dgvProdLinqDT;
        private System.Windows.Forms.Button btnChercherParPrixDT;
        private System.Windows.Forms.Button btnSuppressionRef;
    }
}
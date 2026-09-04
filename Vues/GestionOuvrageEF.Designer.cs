namespace Vues
{
    partial class GestionOuvrageEF
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
            this.btnSup = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.dgvOuvrages = new System.Windows.Forms.DataGridView();
            this.cbAuteurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvN = new System.Windows.Forms.DataGridView();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOuvrages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(509, 348);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(184, 55);
            this.btnSup.TabIndex = 13;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(286, 348);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(184, 55);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(73, 348);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(184, 55);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(119, 114);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(150, 22);
            this.txtTitre.TabIndex = 9;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(119, 47);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(150, 22);
            this.txtISBN.TabIndex = 8;
            // 
            // dgvOuvrages
            // 
            this.dgvOuvrages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOuvrages.Location = new System.Drawing.Point(370, 30);
            this.dgvOuvrages.Name = "dgvOuvrages";
            this.dgvOuvrages.RowHeadersWidth = 51;
            this.dgvOuvrages.RowTemplate.Height = 24;
            this.dgvOuvrages.Size = new System.Drawing.Size(487, 222);
            this.dgvOuvrages.TabIndex = 7;
            // 
            // cbAuteurs
            // 
            this.cbAuteurs.FormattingEnabled = true;
            this.cbAuteurs.Location = new System.Drawing.Point(119, 174);
            this.cbAuteurs.Name = "cbAuteurs";
            this.cbAuteurs.Size = new System.Drawing.Size(150, 24);
            this.cbAuteurs.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Auteur de l\'ouv";
            // 
            // dgvN
            // 
            this.dgvN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbn,
            this.Column1,
            this.Column2});
            this.dgvN.Location = new System.Drawing.Point(907, 57);
            this.dgvN.Name = "dgvN";
            this.dgvN.RowHeadersWidth = 51;
            this.dgvN.RowTemplate.Height = 24;
            this.dgvN.Size = new System.Drawing.Size(530, 150);
            this.dgvN.TabIndex = 16;
            // 
            // isbn
            // 
            this.isbn.HeaderText = "ibsn";
            this.isbn.MinimumWidth = 6;
            this.isbn.Name = "isbn";
            this.isbn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "titre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ouvrage";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // sup
            // 
            this.sup.Location = new System.Drawing.Point(732, 348);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(184, 55);
            this.sup.TabIndex = 17;
            this.sup.Text = "Supprimer";
            this.sup.UseVisualStyleBackColor = true;
            this.sup.Click += new System.EventHandler(this.sup_Click);
            // 
            // GestionOuvrageEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 450);
            this.Controls.Add(this.sup);
            this.Controls.Add(this.dgvN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAuteurs);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.dgvOuvrages);
            this.Name = "GestionOuvrageEF";
            this.Text = "GestionOuvrageEF";
            this.Load += new System.EventHandler(this.GestionOuvrageEF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOuvrages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.DataGridView dgvOuvrages;
        private System.Windows.Forms.ComboBox cbAuteurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvN;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button sup;
    }
}
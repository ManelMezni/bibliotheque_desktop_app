namespace Vues
{
    partial class MenuBibliothequeFSEG2026
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gestionOuvrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionAuteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modeDecnnectéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeConnecteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionOuvrageToolStripMenuItem,
            this.gestionAuteurToolStripMenuItem,
            this.modeDecnnectéToolStripMenuItem,
            this.modeConnecteToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(35, 20);
            this.toolStripStatusLabel.Text = "État";
            // 
            // gestionOuvrageToolStripMenuItem
            // 
            this.gestionOuvrageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem});
            this.gestionOuvrageToolStripMenuItem.Name = "gestionOuvrageToolStripMenuItem";
            this.gestionOuvrageToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.gestionOuvrageToolStripMenuItem.Text = "GestionOuvrage";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // gestionAuteurToolStripMenuItem
            // 
            this.gestionAuteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem1});
            this.gestionAuteurToolStripMenuItem.Name = "gestionAuteurToolStripMenuItem";
            this.gestionAuteurToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.gestionAuteurToolStripMenuItem.Text = "GestionAuteur";
            // 
            // nouveauToolStripMenuItem1
            // 
            this.nouveauToolStripMenuItem1.Name = "nouveauToolStripMenuItem1";
            this.nouveauToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.nouveauToolStripMenuItem1.Text = "Nouveau";
            this.nouveauToolStripMenuItem1.Click += new System.EventHandler(this.nouveauToolStripMenuItem1_Click);
            // 
            // modeDecnnectéToolStripMenuItem
            // 
            this.modeDecnnectéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitToolStripMenuItem});
            this.modeDecnnectéToolStripMenuItem.Name = "modeDecnnectéToolStripMenuItem";
            this.modeDecnnectéToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.modeDecnnectéToolStripMenuItem.Text = "MDC";
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.produitToolStripMenuItem.Text = "Produit";
            this.produitToolStripMenuItem.Click += new System.EventHandler(this.produitToolStripMenuItem_Click);
            // 
            // modeConnecteToolStripMenuItem
            // 
            this.modeConnecteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitToolStripMenuItem1,
            this.colisToolStripMenuItem});
            this.modeConnecteToolStripMenuItem.Name = "modeConnecteToolStripMenuItem";
            this.modeConnecteToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.modeConnecteToolStripMenuItem.Text = "Mode Connecte";
            // 
            // produitToolStripMenuItem1
            // 
            this.produitToolStripMenuItem1.Name = "produitToolStripMenuItem1";
            this.produitToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.produitToolStripMenuItem1.Text = "Produit";
            this.produitToolStripMenuItem1.Click += new System.EventHandler(this.produitToolStripMenuItem1_Click);
            // 
            // colisToolStripMenuItem
            // 
            this.colisToolStripMenuItem.Name = "colisToolStripMenuItem";
            this.colisToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colisToolStripMenuItem.Text = "Colis";
            this.colisToolStripMenuItem.Click += new System.EventHandler(this.colisToolStripMenuItem_Click);
            // 
            // MenuBibliothequeFSEG2026
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuBibliothequeFSEG2026";
            this.Text = "MenuBibliothequeFSEG2026";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem gestionOuvrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionAuteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modeDecnnectéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeConnecteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colisToolStripMenuItem;
    }
}




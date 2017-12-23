namespace MultiFramesProject
{
    partial class FRM_MDI
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
            this.MENU_PRINCIPAL = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marchéPublicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouvementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revueDePresseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MENU_PRINCIPAL.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENU_PRINCIPAL
            // 
            this.MENU_PRINCIPAL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.servicesToolStripMenuItem});
            this.MENU_PRINCIPAL.Location = new System.Drawing.Point(0, 0);
            this.MENU_PRINCIPAL.Name = "MENU_PRINCIPAL";
            this.MENU_PRINCIPAL.Size = new System.Drawing.Size(1116, 24);
            this.MENU_PRINCIPAL.TabIndex = 1;
            this.MENU_PRINCIPAL.Text = "Menu Principal";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.sauvegarderToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir...";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marchéPublicToolStripMenuItem,
            this.mouvementToolStripMenuItem,
            this.revueDePresseToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // marchéPublicToolStripMenuItem
            // 
            this.marchéPublicToolStripMenuItem.Name = "marchéPublicToolStripMenuItem";
            this.marchéPublicToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.marchéPublicToolStripMenuItem.Text = "Marché Public";
            this.marchéPublicToolStripMenuItem.Click += new System.EventHandler(this.marchéPublicToolStripMenuItem_Click);
            // 
            // mouvementToolStripMenuItem
            // 
            this.mouvementToolStripMenuItem.Name = "mouvementToolStripMenuItem";
            this.mouvementToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.mouvementToolStripMenuItem.Text = "Mouvement";
            // 
            // revueDePresseToolStripMenuItem
            // 
            this.revueDePresseToolStripMenuItem.Name = "revueDePresseToolStripMenuItem";
            this.revueDePresseToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.revueDePresseToolStripMenuItem.Text = "Revue de presse";
            // 
            // FRM_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 598);
            this.Controls.Add(this.MENU_PRINCIPAL);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MENU_PRINCIPAL;
            this.Name = "FRM_MDI";
            this.Text = "StartPage";
            this.MENU_PRINCIPAL.ResumeLayout(false);
            this.MENU_PRINCIPAL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MENU_PRINCIPAL;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marchéPublicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouvementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revueDePresseToolStripMenuItem;
    }
}


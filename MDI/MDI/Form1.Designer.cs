namespace MDI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentanaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarVentanaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoHorizontalMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoVerticalMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            //
            // menuPrincipal
            //
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.archivoMenu, this.ventanasMenu});
            this.menuPrincipal.MdiWindowListItem = this.ventanasMenu;
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.TabIndex = 0;
            //
            // archivoMenu
            //
            this.archivoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.nuevaVentanaMenu, this.cerrarVentanaMenu,
                new System.Windows.Forms.ToolStripSeparator(), this.salirMenu});
            this.archivoMenu.Name = "archivoMenu";
            this.archivoMenu.Text = "&Archivo";
            this.nuevaVentanaMenu.Name = "nuevaVentanaMenu";
            this.nuevaVentanaMenu.Text = "&Nueva ventana";
            this.nuevaVentanaMenu.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            this.nuevaVentanaMenu.Click += new System.EventHandler(this.NuevaVentana_Click);
            this.cerrarVentanaMenu.Name = "cerrarVentanaMenu";
            this.cerrarVentanaMenu.Text = "&Cerrar ventana";
            this.cerrarVentanaMenu.Click += new System.EventHandler(this.CerrarVentana_Click);
            this.salirMenu.Name = "salirMenu";
            this.salirMenu.Text = "&Salir";
            this.salirMenu.Click += new System.EventHandler(this.Salir_Click);
            //
            // ventanasMenu
            //
            this.ventanasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.cascadaMenu, this.mosaicoHorizontalMenu, this.mosaicoVerticalMenu});
            this.ventanasMenu.Name = "ventanasMenu";
            this.ventanasMenu.Text = "&Ventanas";
            this.cascadaMenu.Name = "cascadaMenu";
            this.cascadaMenu.Text = "&Cascada";
            this.cascadaMenu.Click += new System.EventHandler(this.Cascada_Click);
            this.mosaicoHorizontalMenu.Name = "mosaicoHorizontalMenu";
            this.mosaicoHorizontalMenu.Text = "Mosaico &horizontal";
            this.mosaicoHorizontalMenu.Click += new System.EventHandler(this.MosaicoHorizontal_Click);
            this.mosaicoVerticalMenu.Name = "mosaicoVerticalMenu";
            this.mosaicoVerticalMenu.Text = "Mosaico &vertical";
            this.mosaicoVerticalMenu.Click += new System.EventHandler(this.MosaicoVertical_Click);
            //
            // Form1
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana MDI";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoMenu;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentanaMenu;
        private System.Windows.Forms.ToolStripMenuItem cerrarVentanaMenu;
        private System.Windows.Forms.ToolStripMenuItem salirMenu;
        private System.Windows.Forms.ToolStripMenuItem ventanasMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadaMenu;
        private System.Windows.Forms.ToolStripMenuItem mosaicoHorizontalMenu;
        private System.Windows.Forms.ToolStripMenuItem mosaicoVerticalMenu;
    }
}


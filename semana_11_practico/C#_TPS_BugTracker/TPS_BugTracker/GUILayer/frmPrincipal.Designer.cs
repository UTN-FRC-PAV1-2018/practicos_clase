namespace TPS_BugTracker
{
    partial class frmPrincipal
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
            this.SoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaDeBugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_principal = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Mnu_principal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoporteToolStripMenuItem
            // 
            this.SoporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosToolStripMenuItem});
            this.SoporteToolStripMenuItem.Name = "SoporteToolStripMenuItem";
            this.SoporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.SoporteToolStripMenuItem.Text = "&Soporte";
            // 
            // UsuariosToolStripMenuItem
            // 
            this.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
            this.UsuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.UsuariosToolStripMenuItem.Text = "Usuarios";
            this.UsuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // BugsToolStripMenuItem
            // 
            this.BugsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsultaDeBugsToolStripMenuItem});
            this.BugsToolStripMenuItem.Name = "BugsToolStripMenuItem";
            this.BugsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.BugsToolStripMenuItem.Text = "&Bugs";
            // 
            // ConsultaDeBugsToolStripMenuItem
            // 
            this.ConsultaDeBugsToolStripMenuItem.Name = "ConsultaDeBugsToolStripMenuItem";
            this.ConsultaDeBugsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ConsultaDeBugsToolStripMenuItem.Text = "&Consulta de bugs";
            this.ConsultaDeBugsToolStripMenuItem.Click += new System.EventHandler(this.ConsultaDeBugsToolStripMenuItem_Click);
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.SalirToolStripMenuItem.Text = "&Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // Mnu_principal
            // 
            this.Mnu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SoporteToolStripMenuItem,
            this.BugsToolStripMenuItem,
            this.SalirToolStripMenuItem});
            this.Mnu_principal.Location = new System.Drawing.Point(0, 0);
            this.Mnu_principal.Name = "Mnu_principal";
            this.Mnu_principal.Size = new System.Drawing.Size(525, 24);
            this.Mnu_principal.TabIndex = 2;
            this.Mnu_principal.Text = "MenuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(525, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Mnu_principal);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Mnu_principal.ResumeLayout(false);
            this.Mnu_principal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripMenuItem SoporteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem UsuariosToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BugsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ConsultaDeBugsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip Mnu_principal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

    }
}
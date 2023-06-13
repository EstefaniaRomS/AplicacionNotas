namespace CapaPresentacion
{
    partial class Inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuagregar = new FontAwesome.Sharp.IconMenuItem();
            this.menuver = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuagregar,
            this.menuver});
            this.menu.Location = new System.Drawing.Point(0, 73);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(796, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuagregar
            // 
            this.menuagregar.AutoSize = false;
            this.menuagregar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.menuagregar.IconColor = System.Drawing.Color.Black;
            this.menuagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuagregar.IconSize = 50;
            this.menuagregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuagregar.Name = "menuagregar";
            this.menuagregar.Size = new System.Drawing.Size(80, 69);
            this.menuagregar.Text = "Agregar";
            this.menuagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuagregar.Click += new System.EventHandler(this.menuagregar_Click);
            // 
            // menuver
            // 
            this.menuver.AutoSize = false;
            this.menuver.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.menuver.IconColor = System.Drawing.Color.Black;
            this.menuver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuver.IconSize = 50;
            this.menuver.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuver.Name = "menuver";
            this.menuver.Size = new System.Drawing.Size(80, 69);
            this.menuver.Text = "Ver Notas";
            this.menuver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuver.Click += new System.EventHandler(this.menuver_Click);
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.OliveDrab;
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(796, 73);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OliveDrab;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Block de Notas";
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 146);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(796, 452);
            this.contenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 598);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private FontAwesome.Sharp.IconMenuItem menuagregar;
        private FontAwesome.Sharp.IconMenuItem menuver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label contenedor;
    }
}


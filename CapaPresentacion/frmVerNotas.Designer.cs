namespace CapaPresentacion
{
    partial class frmVerNotas
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
            this.contenedor = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.dgvnotas = new System.Windows.Forms.DataGridView();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtidnota = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotas)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedor.Location = new System.Drawing.Point(0, 73);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(801, 377);
            this.contenedor.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.Silver;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(800, 73);
            this.menu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mis Notas";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Crimson;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 20;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.Location = new System.Drawing.Point(359, 378);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(117, 38);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dgvnotas
            // 
            this.dgvnotas.AllowUserToAddRows = false;
            this.dgvnotas.AllowUserToDeleteRows = false;
            this.dgvnotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdNota,
            this.Titulo,
            this.Contenido});
            this.dgvnotas.Location = new System.Drawing.Point(129, 81);
            this.dgvnotas.Name = "dgvnotas";
            this.dgvnotas.ReadOnly = true;
            this.dgvnotas.RowHeadersWidth = 51;
            this.dgvnotas.RowTemplate.Height = 24;
            this.dgvnotas.Size = new System.Drawing.Size(568, 291);
            this.dgvnotas.TabIndex = 11;
            this.dgvnotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnotas_CellContentClick);
            // 
            // txtindice
            // 
            this.txtindice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtindice.Location = new System.Drawing.Point(54, 102);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(25, 22);
            this.txtindice.TabIndex = 18;
            this.txtindice.Visible = false;
            // 
            // txtidnota
            // 
            this.txtidnota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidnota.Location = new System.Drawing.Point(85, 102);
            this.txtidnota.Name = "txtidnota";
            this.txtidnota.Size = new System.Drawing.Size(25, 22);
            this.txtidnota.TabIndex = 19;
            this.txtidnota.Visible = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "✔";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Text = "";
            this.Id.Width = 25;
            // 
            // IdNota
            // 
            this.IdNota.HeaderText = "Nota";
            this.IdNota.MinimumWidth = 6;
            this.IdNota.Name = "IdNota";
            this.IdNota.ReadOnly = true;
            this.IdNota.Width = 60;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 130;
            // 
            // Contenido
            // 
            this.Contenido.HeaderText = "Contenido";
            this.Contenido.MinimumWidth = 6;
            this.Contenido.Name = "Contenido";
            this.Contenido.ReadOnly = true;
            this.Contenido.Width = 300;
            // 
            // frmVerNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtidnota);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.dgvnotas);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmVerNotas";
            this.Text = "frmVerNotas";
            this.Load += new System.EventHandler(this.frmVerNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contenedor;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btneliminar;
        private System.Windows.Forms.DataGridView dgvnotas;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtidnota;
        private System.Windows.Forms.DataGridViewButtonColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contenido;
    }
}
namespace CapaPresentacion
{
    partial class frmAgregar
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
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontenido = new System.Windows.Forms.RichTextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.contendor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 20;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.Location = new System.Drawing.Point(359, 358);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(117, 38);
            this.btnguardar.TabIndex = 16;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Agregar nota";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contenido:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Titulo:";
            // 
            // txtcontenido
            // 
            this.txtcontenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontenido.Location = new System.Drawing.Point(274, 145);
            this.txtcontenido.Name = "txtcontenido";
            this.txtcontenido.Size = new System.Drawing.Size(283, 196);
            this.txtcontenido.TabIndex = 11;
            this.txtcontenido.Text = "";
            // 
            // txttitulo
            // 
            this.txttitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttitulo.Location = new System.Drawing.Point(274, 97);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(283, 22);
            this.txttitulo.TabIndex = 10;
            // 
            // contendor
            // 
            this.contendor.BackColor = System.Drawing.Color.White;
            this.contendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contendor.Dock = System.Windows.Forms.DockStyle.Left;
            this.contendor.Location = new System.Drawing.Point(0, 73);
            this.contendor.Name = "contendor";
            this.contendor.Size = new System.Drawing.Size(801, 377);
            this.contendor.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 73);
            this.menuStrip1.TabIndex = 14;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcontenido);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.contendor);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmAgregar";
            this.Text = "frmNotas";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtcontenido;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label contendor;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
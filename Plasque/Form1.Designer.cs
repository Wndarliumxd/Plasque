namespace Plasque
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCabeza = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.botonRestaurar = new System.Windows.Forms.Button();
            this.botonMin = new System.Windows.Forms.Button();
            this.botonMax = new System.Windows.Forms.Button();
            this.botonSalida = new System.Windows.Forms.Button();
            this.panelCabeza.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabeza
            // 
            this.panelCabeza.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelCabeza.Controls.Add(this.botonRestaurar);
            this.panelCabeza.Controls.Add(this.botonMin);
            this.panelCabeza.Controls.Add(this.botonMax);
            this.panelCabeza.Controls.Add(this.botonSalida);
            this.panelCabeza.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabeza.Location = new System.Drawing.Point(0, 0);
            this.panelCabeza.Name = "panelCabeza";
            this.panelCabeza.Size = new System.Drawing.Size(745, 40);
            this.panelCabeza.TabIndex = 0;
            this.panelCabeza.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabeza_MouseMove);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 427);
            this.panelMenu.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 40);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(545, 427);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Visible = false;
            // 
            // botonRestaurar
            // 
            this.botonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRestaurar.FlatAppearance.BorderSize = 0;
            this.botonRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.botonRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.botonRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRestaurar.Image = global::Plasque.Properties.Resources.Icono_Restaurar;
            this.botonRestaurar.Location = new System.Drawing.Point(659, 0);
            this.botonRestaurar.Name = "botonRestaurar";
            this.botonRestaurar.Size = new System.Drawing.Size(40, 40);
            this.botonRestaurar.TabIndex = 3;
            this.botonRestaurar.UseVisualStyleBackColor = true;
            this.botonRestaurar.Click += new System.EventHandler(this.botonRestaurar_Click);
            // 
            // botonMin
            // 
            this.botonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMin.FlatAppearance.BorderSize = 0;
            this.botonMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.botonMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.botonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonMin.Image = global::Plasque.Properties.Resources.Icono_Minimizar;
            this.botonMin.Location = new System.Drawing.Point(613, 0);
            this.botonMin.Name = "botonMin";
            this.botonMin.Size = new System.Drawing.Size(40, 40);
            this.botonMin.TabIndex = 2;
            this.botonMin.UseVisualStyleBackColor = true;
            this.botonMin.Click += new System.EventHandler(this.botonMin_Click);
            // 
            // botonMax
            // 
            this.botonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMax.FlatAppearance.BorderSize = 0;
            this.botonMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.botonMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.botonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonMax.Image = global::Plasque.Properties.Resources.Icono_Maximizar;
            this.botonMax.Location = new System.Drawing.Point(659, 0);
            this.botonMax.Name = "botonMax";
            this.botonMax.Size = new System.Drawing.Size(40, 40);
            this.botonMax.TabIndex = 1;
            this.botonMax.UseVisualStyleBackColor = true;
            this.botonMax.Click += new System.EventHandler(this.botonMax_Click);
            // 
            // botonSalida
            // 
            this.botonSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSalida.FlatAppearance.BorderSize = 0;
            this.botonSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.botonSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.botonSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalida.Image = global::Plasque.Properties.Resources.Icono_cerrar_FN;
            this.botonSalida.Location = new System.Drawing.Point(705, 0);
            this.botonSalida.Name = "botonSalida";
            this.botonSalida.Size = new System.Drawing.Size(40, 40);
            this.botonSalida.TabIndex = 0;
            this.botonSalida.UseVisualStyleBackColor = true;
            this.botonSalida.Click += new System.EventHandler(this.botonSalida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 467);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabeza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelCabeza.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabeza;
        private System.Windows.Forms.Button botonSalida;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button botonMax;
        private System.Windows.Forms.Button botonMin;
        private System.Windows.Forms.Button botonRestaurar;

    }
}


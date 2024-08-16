namespace App
{
    partial class FormEleccionCantidad
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
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.labelNombreArticulo = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelTexto = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(282, 177);
            this.BotonCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(125, 27);
            this.BotonCancelar.TabIndex = 35;
            this.BotonCancelar.Text = "Cancelar [F2]";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(138, 177);
            this.BotonAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(125, 27);
            this.BotonAceptar.TabIndex = 34;
            this.BotonAceptar.Text = "Aceptar [ENTER]";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // labelNombreArticulo
            // 
            this.labelNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreArticulo.Location = new System.Drawing.Point(218, 36);
            this.labelNombreArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreArticulo.Name = "labelNombreArticulo";
            this.labelNombreArticulo.Size = new System.Drawing.Size(81, 29);
            this.labelNombreArticulo.TabIndex = 36;
            this.labelNombreArticulo.Text = "nombre";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Enabled = false;
            this.textBoxStock.Location = new System.Drawing.Point(138, 114);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(56, 21);
            this.textBoxStock.TabIndex = 37;
            this.textBoxStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelStock
            // 
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(77, 110);
            this.labelStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(62, 32);
            this.labelStock.TabIndex = 38;
            this.labelStock.Text = "stock";
            // 
            // labelCantidad
            // 
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.Location = new System.Drawing.Point(306, 110);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(86, 32);
            this.labelCantidad.TabIndex = 40;
            this.labelCantidad.Text = "cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(390, 114);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(54, 21);
            this.textBoxCantidad.TabIndex = 39;
            // 
            // labelTexto
            // 
            this.labelTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.Location = new System.Drawing.Point(184, 65);
            this.labelTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(160, 22);
            this.labelTexto.TabIndex = 41;
            this.labelTexto.Text = "(seleccione la cantidad)";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(79, 95);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 42;
            // 
            // FormEleccionCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 213);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.labelNombreArticulo);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEleccionCantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEleccionCantidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Label labelNombreArticulo;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.Label labelError;
    }
}
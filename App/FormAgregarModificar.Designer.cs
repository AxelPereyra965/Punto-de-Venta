namespace App
{
    partial class FormAgregarModificar
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
            this.TextBoxStock = new System.Windows.Forms.TextBox();
            this.LabelStock = new System.Windows.Forms.Label();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.BotonAgregarImagen = new System.Windows.Forms.Button();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.ComboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxUrlImagen = new System.Windows.Forms.TextBox();
            this.labelUrlImagen = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxStock
            // 
            this.TextBoxStock.Location = new System.Drawing.Point(98, 212);
            this.TextBoxStock.Name = "TextBoxStock";
            this.TextBoxStock.Size = new System.Drawing.Size(110, 20);
            this.TextBoxStock.TabIndex = 37;
            // 
            // LabelStock
            // 
            this.LabelStock.AutoSize = true;
            this.LabelStock.Location = new System.Drawing.Point(57, 215);
            this.LabelStock.Name = "LabelStock";
            this.LabelStock.Size = new System.Drawing.Size(35, 13);
            this.LabelStock.TabIndex = 38;
            this.LabelStock.Text = "Stock";
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(281, 256);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(85, 31);
            this.BotonCancelar.TabIndex = 31;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(107, 256);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(85, 31);
            this.BotonAgregar.TabIndex = 30;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // BotonAgregarImagen
            // 
            this.BotonAgregarImagen.Image = global::App.Properties.Resources.img_icono;
            this.BotonAgregarImagen.Location = new System.Drawing.Point(221, 126);
            this.BotonAgregarImagen.Name = "BotonAgregarImagen";
            this.BotonAgregarImagen.Size = new System.Drawing.Size(31, 24);
            this.BotonAgregarImagen.TabIndex = 33;
            this.BotonAgregarImagen.Text = " ";
            this.BotonAgregarImagen.UseVisualStyleBackColor = true;
            this.BotonAgregarImagen.Click += new System.EventHandler(this.BotonAgregarImagen_Click);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(98, 159);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(110, 21);
            this.comboBoxCategoria.TabIndex = 27;
            // 
            // ComboBoxMarca
            // 
            this.ComboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMarca.FormattingEnabled = true;
            this.ComboBoxMarca.Location = new System.Drawing.Point(98, 132);
            this.ComboBoxMarca.Name = "ComboBoxMarca";
            this.ComboBoxMarca.Size = new System.Drawing.Size(110, 21);
            this.ComboBoxMarca.TabIndex = 25;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(98, 186);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(110, 20);
            this.textBoxPrecio.TabIndex = 28;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(57, 189);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 35;
            this.labelPrecio.Text = "Precio";
            // 
            // textBoxUrlImagen
            // 
            this.textBoxUrlImagen.Location = new System.Drawing.Point(99, 102);
            this.textBoxUrlImagen.Name = "textBoxUrlImagen";
            this.textBoxUrlImagen.Size = new System.Drawing.Size(111, 20);
            this.textBoxUrlImagen.TabIndex = 24;
            this.textBoxUrlImagen.Leave += new System.EventHandler(this.textBoxUrlImagen_Leave);
            // 
            // labelUrlImagen
            // 
            this.labelUrlImagen.AutoSize = true;
            this.labelUrlImagen.Location = new System.Drawing.Point(39, 102);
            this.labelUrlImagen.Name = "labelUrlImagen";
            this.labelUrlImagen.Size = new System.Drawing.Size(55, 13);
            this.labelUrlImagen.TabIndex = 34;
            this.labelUrlImagen.Text = "UrlImagen";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(40, 159);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 32;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(55, 132);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 29;
            this.labelMarca.Text = "Marca";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(99, 76);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(110, 20);
            this.textBoxDescripcion.TabIndex = 23;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(34, 76);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 26;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(99, 47);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(110, 20);
            this.textBoxNombre.TabIndex = 21;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(54, 50);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 22;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(98, 21);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(111, 20);
            this.textBoxCodigo.TabIndex = 20;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(57, 24);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 19;
            this.labelCodigo.Text = "Codigo";
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Location = new System.Drawing.Point(268, 65);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(181, 154);
            this.pictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImg.TabIndex = 36;
            this.pictureBoxImg.TabStop = false;
            // 
            // FormAgregarModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 308);
            this.Controls.Add(this.TextBoxStock);
            this.Controls.Add(this.LabelStock);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.BotonAgregarImagen);
            this.Controls.Add(this.pictureBoxImg);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.ComboBoxMarca);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.textBoxUrlImagen);
            this.Controls.Add(this.labelUrlImagen);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregarModificar";
            this.Load += new System.EventHandler(this.FormAgregarModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxStock;
        private System.Windows.Forms.Label LabelStock;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Button BotonAgregarImagen;
        private System.Windows.Forms.PictureBox pictureBoxImg;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox ComboBoxMarca;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxUrlImagen;
        private System.Windows.Forms.Label labelUrlImagen;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
    }
}
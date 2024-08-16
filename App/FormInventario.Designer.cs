namespace App
{
    partial class FormInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonModificar = new System.Windows.Forms.Button();
            this.BotonFiltrar = new System.Windows.Forms.Button();
            this.textBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.ComboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.ComboBoxCampo = new System.Windows.Forms.ComboBox();
            this.labelCampo = new System.Windows.Forms.Label();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.TextBoxFiltroRapido = new System.Windows.Forms.TextBox();
            this.labelFiltroRapido = new System.Windows.Forms.Label();
            this.pictureBoxArticulos = new System.Windows.Forms.PictureBox();
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.BotonEliminar.Image = global::App.Properties.Resources.img_eliminar;
            this.BotonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonEliminar.Location = new System.Drawing.Point(10, 242);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(102, 70);
            this.BotonEliminar.TabIndex = 30;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonEliminar.UseVisualStyleBackColor = false;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonModificar
            // 
            this.BotonModificar.BackColor = System.Drawing.SystemColors.Window;
            this.BotonModificar.Image = global::App.Properties.Resources.img_editar;
            this.BotonModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonModificar.Location = new System.Drawing.Point(10, 151);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(102, 70);
            this.BotonModificar.TabIndex = 29;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonModificar.UseVisualStyleBackColor = false;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // BotonFiltrar
            // 
            this.BotonFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotonFiltrar.Location = new System.Drawing.Point(638, 370);
            this.BotonFiltrar.Name = "BotonFiltrar";
            this.BotonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BotonFiltrar.TabIndex = 28;
            this.BotonFiltrar.Text = "Buscar";
            this.BotonFiltrar.UseVisualStyleBackColor = true;
            this.BotonFiltrar.Click += new System.EventHandler(this.BotonFiltrar_Click);
            // 
            // textBoxFiltroAvanzado
            // 
            this.textBoxFiltroAvanzado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFiltroAvanzado.Location = new System.Drawing.Point(523, 373);
            this.textBoxFiltroAvanzado.Name = "textBoxFiltroAvanzado";
            this.textBoxFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiltroAvanzado.TabIndex = 27;
            // 
            // labelFiltro
            // 
            this.labelFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(482, 375);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(29, 13);
            this.labelFiltro.TabIndex = 26;
            this.labelFiltro.Text = "Filtro";
            // 
            // ComboBoxCriterio
            // 
            this.ComboBoxCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboBoxCriterio.FormattingEnabled = true;
            this.ComboBoxCriterio.Location = new System.Drawing.Point(339, 372);
            this.ComboBoxCriterio.Name = "ComboBoxCriterio";
            this.ComboBoxCriterio.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCriterio.TabIndex = 25;
            // 
            // labelCriterio
            // 
            this.labelCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(298, 375);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(39, 13);
            this.labelCriterio.TabIndex = 24;
            this.labelCriterio.Text = "Criterio";
            // 
            // ComboBoxCampo
            // 
            this.ComboBoxCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboBoxCampo.FormattingEnabled = true;
            this.ComboBoxCampo.Location = new System.Drawing.Point(168, 373);
            this.ComboBoxCampo.Name = "ComboBoxCampo";
            this.ComboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCampo.TabIndex = 23;
            this.ComboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCampo_SelectedIndexChanged);
            // 
            // labelCampo
            // 
            this.labelCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(115, 376);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(40, 13);
            this.labelCampo.TabIndex = 22;
            this.labelCampo.Text = "Campo";
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.SystemColors.Window;
            this.BotonAgregar.Image = global::App.Properties.Resources.img_agregar;
            this.BotonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonAgregar.Location = new System.Drawing.Point(10, 54);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(102, 73);
            this.BotonAgregar.TabIndex = 21;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonAgregar.UseVisualStyleBackColor = false;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // TextBoxFiltroRapido
            // 
            this.TextBoxFiltroRapido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFiltroRapido.Location = new System.Drawing.Point(257, 28);
            this.TextBoxFiltroRapido.Name = "TextBoxFiltroRapido";
            this.TextBoxFiltroRapido.Size = new System.Drawing.Size(324, 20);
            this.TextBoxFiltroRapido.TabIndex = 20;
            this.TextBoxFiltroRapido.TextChanged += new System.EventHandler(this.TextBoxFiltroRapido_TextChanged);
            // 
            // labelFiltroRapido
            // 
            this.labelFiltroRapido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFiltroRapido.AutoSize = true;
            this.labelFiltroRapido.Location = new System.Drawing.Point(204, 31);
            this.labelFiltroRapido.Name = "labelFiltroRapido";
            this.labelFiltroRapido.Size = new System.Drawing.Size(40, 13);
            this.labelFiltroRapido.TabIndex = 19;
            this.labelFiltroRapido.Text = "Buscar";
            // 
            // pictureBoxArticulos
            // 
            this.pictureBoxArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxArticulos.Location = new System.Drawing.Point(704, 28);
            this.pictureBoxArticulos.Name = "pictureBoxArticulos";
            this.pictureBoxArticulos.Size = new System.Drawing.Size(264, 332);
            this.pictureBoxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulos.TabIndex = 18;
            this.pictureBoxArticulos.TabStop = false;
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.AllowUserToAddRows = false;
            this.DgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvArticulos.Location = new System.Drawing.Point(118, 54);
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.RowHeadersVisible = false;
            this.DgvArticulos.RowTemplate.Height = 30;
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(580, 263);
            this.DgvArticulos.TabIndex = 17;
            this.DgvArticulos.SelectionChanged += new System.EventHandler(this.DgvArticulos_SelectionChanged);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 443);
            this.ControlBox = false;
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.BotonFiltrar);
            this.Controls.Add(this.textBoxFiltroAvanzado);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.ComboBoxCriterio);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.ComboBoxCampo);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.TextBoxFiltroRapido);
            this.Controls.Add(this.labelFiltroRapido);
            this.Controls.Add(this.pictureBoxArticulos);
            this.Controls.Add(this.DgvArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.Button BotonModificar;
        private System.Windows.Forms.Button BotonFiltrar;
        private System.Windows.Forms.TextBox textBoxFiltroAvanzado;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.ComboBox ComboBoxCriterio;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.ComboBox ComboBoxCampo;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.TextBox TextBoxFiltroRapido;
        private System.Windows.Forms.Label labelFiltroRapido;
        private System.Windows.Forms.PictureBox pictureBoxArticulos;
        private System.Windows.Forms.DataGridView DgvArticulos;
    }
}
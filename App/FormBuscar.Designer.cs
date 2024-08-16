namespace App
{
    partial class FormBuscar
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
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.labelArticulos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(70, 15);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(166, 20);
            this.textBoxBuscar.TabIndex = 22;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(12, 15);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(52, 17);
            this.labelBuscar.TabIndex = 21;
            this.labelBuscar.Text = "Buscar";
            // 
            // labelArticulos
            // 
            this.labelArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArticulos.Location = new System.Drawing.Point(3, 0);
            this.labelArticulos.Name = "labelArticulos";
            this.labelArticulos.Size = new System.Drawing.Size(113, 25);
            this.labelArticulos.TabIndex = 24;
            this.labelArticulos.Text = "  Buscar Articulo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelArticulos);
            this.panel1.Location = new System.Drawing.Point(0, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 28);
            this.panel1.TabIndex = 26;
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvArticulos.Location = new System.Drawing.Point(0, 0);
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(982, 308);
            this.DgvArticulos.TabIndex = 23;
            this.DgvArticulos.SelectionChanged += new System.EventHandler(this.DgvArticulos_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.BotonCancelar);
            this.panel2.Controls.Add(this.BotonAceptar);
            this.panel2.Controls.Add(this.DgvArticulos);
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 393);
            this.panel2.TabIndex = 33;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(540, 327);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(121, 32);
            this.BotonCancelar.TabIndex = 33;
            this.BotonCancelar.Text = "Cancelar [F2]";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(321, 327);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(121, 32);
            this.BotonAceptar.TabIndex = 32;
            this.BotonAceptar.Text = "Aceptar [ENTER]";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.labelBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscar";
            this.Load += new System.EventHandler(this.FormBuscar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.Label labelArticulos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAceptar;
    }
}
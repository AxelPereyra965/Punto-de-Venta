namespace App
{
    partial class FormVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.LabelTextTotal = new System.Windows.Forms.Label();
            this.LabelBuscar = new System.Windows.Forms.Label();
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.ComboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonQuitar = new System.Windows.Forms.Button();
            this.BotonCobrar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(641, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 342);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.LabelTotal);
            this.panel4.Controls.Add(this.LabelTextTotal);
            this.panel4.Location = new System.Drawing.Point(0, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 100);
            this.panel4.TabIndex = 18;
            // 
            // LabelTotal
            // 
            this.LabelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(89, 54);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(185, 46);
            this.LabelTotal.TabIndex = 1;
            // 
            // LabelTextTotal
            // 
            this.LabelTextTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTextTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTextTotal.Location = new System.Drawing.Point(-8, 54);
            this.LabelTextTotal.Name = "LabelTextTotal";
            this.LabelTextTotal.Size = new System.Drawing.Size(109, 46);
            this.LabelTextTotal.TabIndex = 0;
            this.LabelTextTotal.Text = "Total";
            // 
            // LabelBuscar
            // 
            this.LabelBuscar.AutoSize = true;
            this.LabelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBuscar.Location = new System.Drawing.Point(9, 44);
            this.LabelBuscar.Name = "LabelBuscar";
            this.LabelBuscar.Size = new System.Drawing.Size(73, 25);
            this.LabelBuscar.TabIndex = 26;
            this.LabelBuscar.Text = "Buscar";
            // 
            // DgvVentas
            // 
            this.DgvVentas.AllowUserToAddRows = false;
            this.DgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvVentas.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvVentas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DgvVentas.Location = new System.Drawing.Point(-1, 96);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.RowHeadersVisible = false;
            this.DgvVentas.RowTemplate.Height = 30;
            this.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVentas.Size = new System.Drawing.Size(645, 342);
            this.DgvVentas.TabIndex = 25;
            // 
            // ComboBoxBuscar
            // 
            this.ComboBoxBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxBuscar.FormattingEnabled = true;
            this.ComboBoxBuscar.Location = new System.Drawing.Point(88, 50);
            this.ComboBoxBuscar.Name = "ComboBoxBuscar";
            this.ComboBoxBuscar.Size = new System.Drawing.Size(110, 21);
            this.ComboBoxBuscar.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Image = global::App.Properties.Resources.img_buscar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(228, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 73);
            this.button1.TabIndex = 33;
            this.button1.Text = "Buscar [F1]";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.BotonCancelar.Image = global::App.Properties.Resources.img_eliminar;
            this.BotonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonCancelar.Location = new System.Drawing.Point(585, 17);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(103, 73);
            this.BotonCancelar.TabIndex = 30;
            this.BotonCancelar.Text = "Cancelar[F6]";
            this.BotonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonCancelar.UseVisualStyleBackColor = false;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonQuitar
            // 
            this.BotonQuitar.BackColor = System.Drawing.SystemColors.Window;
            this.BotonQuitar.Image = global::App.Properties.Resources.img_tacho;
            this.BotonQuitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonQuitar.Location = new System.Drawing.Point(465, 17);
            this.BotonQuitar.Name = "BotonQuitar";
            this.BotonQuitar.Size = new System.Drawing.Size(103, 73);
            this.BotonQuitar.TabIndex = 29;
            this.BotonQuitar.Text = "Quitar [F5]";
            this.BotonQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonQuitar.UseVisualStyleBackColor = false;
            this.BotonQuitar.Click += new System.EventHandler(this.BotonQuitar_Click);
            // 
            // BotonCobrar
            // 
            this.BotonCobrar.BackColor = System.Drawing.SystemColors.Window;
            this.BotonCobrar.Image = global::App.Properties.Resources.img_cobrar;
            this.BotonCobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonCobrar.Location = new System.Drawing.Point(346, 17);
            this.BotonCobrar.Name = "BotonCobrar";
            this.BotonCobrar.Size = new System.Drawing.Size(103, 73);
            this.BotonCobrar.TabIndex = 28;
            this.BotonCobrar.Text = "Cobrar [ENTER]";
            this.BotonCobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonCobrar.UseVisualStyleBackColor = false;
            this.BotonCobrar.Click += new System.EventHandler(this.BotonCobrar_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 475);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboBoxBuscar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonQuitar);
            this.Controls.Add(this.BotonCobrar);
            this.Controls.Add(this.LabelBuscar);
            this.Controls.Add(this.DgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label LabelTextTotal;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonQuitar;
        private System.Windows.Forms.Button BotonCobrar;
        private System.Windows.Forms.Label LabelBuscar;
        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.ComboBox ComboBoxBuscar;
        private System.Windows.Forms.Button button1;
    }
}
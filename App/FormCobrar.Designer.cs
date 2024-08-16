namespace App
{
    partial class FormCobrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelPago = new System.Windows.Forms.Panel();
            this.labelSinPago = new System.Windows.Forms.Label();
            this.labelSinImporte = new System.Windows.Forms.Label();
            this.BotonCheck = new System.Windows.Forms.Button();
            this.textImporte = new System.Windows.Forms.TextBox();
            this.labelImportev = new System.Windows.Forms.Label();
            this.ComboBoxPago = new System.Windows.Forms.ComboBox();
            this.labelPago = new System.Windows.Forms.Label();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.dataGridViewCobrar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCobrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.labelNum);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 44);
            this.panel1.TabIndex = 0;
            // 
            // labelNum
            // 
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.Location = new System.Drawing.Point(346, 9);
            this.labelNum.Margin = new System.Windows.Forms.Padding(0);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(152, 23);
            this.labelNum.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(12, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 68);
            this.panel2.TabIndex = 1;
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(294, 9);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(52, 23);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total";
            // 
            // panelPago
            // 
            this.panelPago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPago.Controls.Add(this.labelSinPago);
            this.panelPago.Controls.Add(this.labelSinImporte);
            this.panelPago.Controls.Add(this.BotonCheck);
            this.panelPago.Controls.Add(this.textImporte);
            this.panelPago.Controls.Add(this.labelImportev);
            this.panelPago.Controls.Add(this.ComboBoxPago);
            this.panelPago.Controls.Add(this.labelPago);
            this.panelPago.Location = new System.Drawing.Point(0, 44);
            this.panelPago.Margin = new System.Windows.Forms.Padding(0);
            this.panelPago.Name = "panelPago";
            this.panelPago.Size = new System.Drawing.Size(737, 97);
            this.panelPago.TabIndex = 1;
            // 
            // labelSinPago
            // 
            this.labelSinPago.AutoSize = true;
            this.labelSinPago.Location = new System.Drawing.Point(80, 22);
            this.labelSinPago.Name = "labelSinPago";
            this.labelSinPago.Size = new System.Drawing.Size(0, 13);
            this.labelSinPago.TabIndex = 33;
            // 
            // labelSinImporte
            // 
            this.labelSinImporte.AutoSize = true;
            this.labelSinImporte.Location = new System.Drawing.Point(359, 24);
            this.labelSinImporte.Name = "labelSinImporte";
            this.labelSinImporte.Size = new System.Drawing.Size(0, 13);
            this.labelSinImporte.TabIndex = 32;
            // 
            // BotonCheck
            // 
            this.BotonCheck.BackColor = System.Drawing.SystemColors.Window;
            this.BotonCheck.Image = global::App.Properties.Resources.icono_check;
            this.BotonCheck.Location = new System.Drawing.Point(559, 35);
            this.BotonCheck.Name = "BotonCheck";
            this.BotonCheck.Size = new System.Drawing.Size(37, 28);
            this.BotonCheck.TabIndex = 31;
            this.BotonCheck.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonCheck.UseVisualStyleBackColor = false;
            this.BotonCheck.Click += new System.EventHandler(this.BotonCheck_Click);
            // 
            // textImporte
            // 
            this.textImporte.Location = new System.Drawing.Point(431, 39);
            this.textImporte.Name = "textImporte";
            this.textImporte.Size = new System.Drawing.Size(103, 20);
            this.textImporte.TabIndex = 28;
            // 
            // labelImportev
            // 
            this.labelImportev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImportev.Location = new System.Drawing.Point(358, 37);
            this.labelImportev.Margin = new System.Windows.Forms.Padding(0);
            this.labelImportev.Name = "labelImportev";
            this.labelImportev.Size = new System.Drawing.Size(70, 23);
            this.labelImportev.TabIndex = 27;
            this.labelImportev.Text = "Importe";
            // 
            // ComboBoxPago
            // 
            this.ComboBoxPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPago.FormattingEnabled = true;
            this.ComboBoxPago.Location = new System.Drawing.Point(206, 38);
            this.ComboBoxPago.Name = "ComboBoxPago";
            this.ComboBoxPago.Size = new System.Drawing.Size(113, 21);
            this.ComboBoxPago.TabIndex = 26;
            // 
            // labelPago
            // 
            this.labelPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPago.Location = new System.Drawing.Point(79, 35);
            this.labelPago.Margin = new System.Windows.Forms.Padding(0);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(124, 23);
            this.labelPago.TabIndex = 2;
            this.labelPago.Text = "Forma De Pago";
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(397, 316);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(121, 32);
            this.BotonCancelar.TabIndex = 35;
            this.BotonCancelar.Text = "Cancelar [F2]";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(178, 316);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(121, 32);
            this.BotonAceptar.TabIndex = 34;
            this.BotonAceptar.Text = "Aceptar [ENTER]";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // dataGridViewCobrar
            // 
            this.dataGridViewCobrar.AllowUserToAddRows = false;
            this.dataGridViewCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCobrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCobrar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCobrar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCobrar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCobrar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCobrar.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewCobrar.Location = new System.Drawing.Point(0, 141);
            this.dataGridViewCobrar.Name = "dataGridViewCobrar";
            this.dataGridViewCobrar.RowHeadersVisible = false;
            this.dataGridViewCobrar.RowTemplate.Height = 30;
            this.dataGridViewCobrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCobrar.Size = new System.Drawing.Size(737, 148);
            this.dataGridViewCobrar.TabIndex = 36;
            // 
            // FormCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 376);
            this.Controls.Add(this.dataGridViewCobrar);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.panelPago);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCobrar";
            this.Load += new System.EventHandler(this.FormCobrar_Load);
            this.panel1.ResumeLayout(false);
            this.panelPago.ResumeLayout(false);
            this.panelPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCobrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelPago;
        private System.Windows.Forms.Label labelPago;
        private System.Windows.Forms.Label labelImportev;
        private System.Windows.Forms.ComboBox ComboBoxPago;
        private System.Windows.Forms.TextBox textImporte;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.DataGridView dataGridViewCobrar;
        private System.Windows.Forms.Button BotonCheck;
        private System.Windows.Forms.Label labelSinPago;
        private System.Windows.Forms.Label labelSinImporte;
    }
}
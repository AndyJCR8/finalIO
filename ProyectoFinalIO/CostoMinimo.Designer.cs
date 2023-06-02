namespace ProyectoFinalIO
{
    partial class CostoMinimo
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.dgvEcuaciones = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblOferta = new System.Windows.Forms.Label();
            this.lblPlantas = new System.Windows.Forms.Label();
            this.txtbX1 = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransporte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcuaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Correr test de calculo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(15, 464);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(104, 24);
            this.lblResultado.TabIndex = 61;
            this.lblResultado.Text = "Resultado: ";
            // 
            // dgvEcuaciones
            // 
            this.dgvEcuaciones.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEcuaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEcuaciones.Location = new System.Drawing.Point(15, 192);
            this.dgvEcuaciones.Name = "dgvEcuaciones";
            this.dgvEcuaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEcuaciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEcuaciones.Size = new System.Drawing.Size(816, 209);
            this.dgvEcuaciones.TabIndex = 60;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 416);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(200, 29);
            this.btnCalcular.TabIndex = 59;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblOferta
            // 
            this.lblOferta.AutoSize = true;
            this.lblOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOferta.Location = new System.Drawing.Point(12, 155);
            this.lblOferta.Name = "lblOferta";
            this.lblOferta.Size = new System.Drawing.Size(398, 24);
            this.lblOferta.TabIndex = 58;
            this.lblOferta.Text = "Ingrese los datos de costos, oferta y demanda:";
            // 
            // lblPlantas
            // 
            this.lblPlantas.AutoSize = true;
            this.lblPlantas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantas.Location = new System.Drawing.Point(12, 9);
            this.lblPlantas.Name = "lblPlantas";
            this.lblPlantas.Size = new System.Drawing.Size(229, 24);
            this.lblPlantas.TabIndex = 54;
            this.lblPlantas.Text = "Ingrese los datos iniciales:";
            // 
            // txtbX1
            // 
            this.txtbX1.Location = new System.Drawing.Point(227, 47);
            this.txtbX1.Name = "txtbX1";
            this.txtbX1.Size = new System.Drawing.Size(314, 20);
            this.txtbX1.TabIndex = 48;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(12, 47);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(191, 24);
            this.lblX.TabIndex = 47;
            this.lblX.Text = "Cantidad de plantas =";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(547, 115);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(284, 29);
            this.btnAceptar.TabIndex = 62;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.Location = new System.Drawing.Point(12, 82);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(168, 24);
            this.lblMoneda.TabIndex = 63;
            this.lblMoneda.Text = "Moneda utilizada =";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(227, 87);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(314, 20);
            this.txtMoneda.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Unidad de Transporte =";
            // 
            // txtTransporte
            // 
            this.txtTransporte.Location = new System.Drawing.Point(227, 124);
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.Size = new System.Drawing.Size(314, 20);
            this.txtTransporte.TabIndex = 66;
            // 
            // CostoMinimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 533);
            this.Controls.Add(this.txtTransporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.dgvEcuaciones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblOferta);
            this.Controls.Add(this.lblPlantas);
            this.Controls.Add(this.txtbX1);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CostoMinimo";
            this.Text = "CostoMinimo";
            this.Load += new System.EventHandler(this.CostoMinimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcuaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView dgvEcuaciones;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblOferta;
        private System.Windows.Forms.Label lblPlantas;
        private System.Windows.Forms.TextBox txtbX1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTransporte;
    }
}
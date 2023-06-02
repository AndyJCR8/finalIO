namespace ProyectoFinalIO
{
    partial class Simplex
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbMinimizacion = new System.Windows.Forms.RadioButton();
            this.rbMaximizacion = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvEcuaciones = new System.Windows.Forms.DataGridView();
            this.coefX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coefX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coefX3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coefRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtbX3 = new System.Windows.Forms.TextBox();
            this.txtbX2 = new System.Windows.Forms.TextBox();
            this.txtbX1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcuaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "z =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "x1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "x2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "x3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ingrese la función objetivo:";
            // 
            // rbMinimizacion
            // 
            this.rbMinimizacion.AutoSize = true;
            this.rbMinimizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMinimizacion.ForeColor = System.Drawing.Color.Black;
            this.rbMinimizacion.Location = new System.Drawing.Point(503, 61);
            this.rbMinimizacion.Name = "rbMinimizacion";
            this.rbMinimizacion.Size = new System.Drawing.Size(117, 24);
            this.rbMinimizacion.TabIndex = 16;
            this.rbMinimizacion.TabStop = true;
            this.rbMinimizacion.Text = "Minimización";
            this.rbMinimizacion.UseVisualStyleBackColor = true;
            // 
            // rbMaximizacion
            // 
            this.rbMaximizacion.AutoSize = true;
            this.rbMaximizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaximizacion.ForeColor = System.Drawing.Color.Black;
            this.rbMaximizacion.Location = new System.Drawing.Point(647, 61);
            this.rbMaximizacion.Name = "rbMaximizacion";
            this.rbMaximizacion.Size = new System.Drawing.Size(121, 24);
            this.rbMaximizacion.TabIndex = 17;
            this.rbMaximizacion.TabStop = true;
            this.rbMaximizacion.Text = "Maximización";
            this.rbMaximizacion.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(500, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Seleccione el tipo de método";
            // 
            // dgvEcuaciones
            // 
            this.dgvEcuaciones.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEcuaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEcuaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coefX1,
            this.coefX2,
            this.coefX3,
            this.coefRes});
            this.dgvEcuaciones.Location = new System.Drawing.Point(12, 184);
            this.dgvEcuaciones.Name = "dgvEcuaciones";
            this.dgvEcuaciones.Size = new System.Drawing.Size(655, 209);
            this.dgvEcuaciones.TabIndex = 45;
            // 
            // coefX1
            // 
            this.coefX1.HeaderText = "X1";
            this.coefX1.Name = "coefX1";
            // 
            // coefX2
            // 
            this.coefX2.HeaderText = "X2";
            this.coefX2.Name = "coefX2";
            // 
            // coefX3
            // 
            this.coefX3.HeaderText = "X3";
            this.coefX3.Name = "coefX3";
            // 
            // coefRes
            // 
            this.coefRes.HeaderText = "Resultado";
            this.coefRes.Name = "coefRes";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(673, 256);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 53);
            this.btnCalcular.TabIndex = 44;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ingrese las ecuaciones de restricción:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 432);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(104, 24);
            this.lblResult.TabIndex = 46;
            this.lblResult.Text = "Resultado: ";
            // 
            // txtbX3
            // 
            this.txtbX3.Location = new System.Drawing.Point(302, 65);
            this.txtbX3.Name = "txtbX3";
            this.txtbX3.Size = new System.Drawing.Size(72, 20);
            this.txtbX3.TabIndex = 5;
            this.txtbX3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbKeyPress);
            // 
            // txtbX2
            // 
            this.txtbX2.Location = new System.Drawing.Point(188, 65);
            this.txtbX2.Name = "txtbX2";
            this.txtbX2.Size = new System.Drawing.Size(72, 20);
            this.txtbX2.TabIndex = 3;
            this.txtbX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbKeyPress);
            // 
            // txtbX1
            // 
            this.txtbX1.Location = new System.Drawing.Point(74, 65);
            this.txtbX1.Name = "txtbX1";
            this.txtbX1.Size = new System.Drawing.Size(72, 20);
            this.txtbX1.TabIndex = 1;
            this.txtbX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbKeyPress);
            // 
            // Simplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dgvEcuaciones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rbMaximizacion);
            this.Controls.Add(this.rbMinimizacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbX3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbX2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbX1);
            this.Controls.Add(this.label1);
            this.Name = "Simplex";
            this.Text = "Simplex";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcuaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMinimizacion;
        private System.Windows.Forms.RadioButton rbMaximizacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvEcuaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn coefX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coefX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coefX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn coefRes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtbX3;
        private System.Windows.Forms.TextBox txtbX2;
        private System.Windows.Forms.TextBox txtbX1;
    }
}
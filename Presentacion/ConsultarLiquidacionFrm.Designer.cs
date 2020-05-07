namespace Presentacion
{
    partial class ConsultarLiquidacionFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Contributivotxt = new System.Windows.Forms.TextBox();
            this.SubsidiadoTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PalabraTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FechaDt = new System.Windows.Forms.DateTimePicker();
            this.CalcularBton = new System.Windows.Forms.Button();
            this.TipoCalculoBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalTodostxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo:";
            // 
            // TipoBox
            // 
            this.TipoBox.FormattingEnabled = true;
            this.TipoBox.Items.AddRange(new object[] {
            "Subsidiado",
            "Contributivo",
            "Todos"});
            this.TipoBox.Location = new System.Drawing.Point(355, 12);
            this.TipoBox.Name = "TipoBox";
            this.TipoBox.Size = new System.Drawing.Size(121, 21);
            this.TipoBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "TotalContributivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "TotalSubsidiado:";
            // 
            // Contributivotxt
            // 
            this.Contributivotxt.Location = new System.Drawing.Point(399, 345);
            this.Contributivotxt.Name = "Contributivotxt";
            this.Contributivotxt.Size = new System.Drawing.Size(100, 20);
            this.Contributivotxt.TabIndex = 11;
            // 
            // SubsidiadoTxt
            // 
            this.SubsidiadoTxt.Location = new System.Drawing.Point(684, 343);
            this.SubsidiadoTxt.Name = "SubsidiadoTxt";
            this.SubsidiadoTxt.Size = new System.Drawing.Size(100, 20);
            this.SubsidiadoTxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Palabra:";
            // 
            // PalabraTxt
            // 
            this.PalabraTxt.Location = new System.Drawing.Point(85, 413);
            this.PalabraTxt.Name = "PalabraTxt";
            this.PalabraTxt.Size = new System.Drawing.Size(100, 20);
            this.PalabraTxt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Por Fecha:";
            // 
            // FechaDt
            // 
            this.FechaDt.Location = new System.Drawing.Point(344, 413);
            this.FechaDt.Name = "FechaDt";
            this.FechaDt.Size = new System.Drawing.Size(200, 20);
            this.FechaDt.TabIndex = 16;
            
            // 
            // CalcularBton
            // 
            this.CalcularBton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularBton.Location = new System.Drawing.Point(604, 404);
            this.CalcularBton.Name = "CalcularBton";
            this.CalcularBton.Size = new System.Drawing.Size(94, 32);
            this.CalcularBton.TabIndex = 17;
            this.CalcularBton.Text = "Calcular";
            this.CalcularBton.UseVisualStyleBackColor = true;
            this.CalcularBton.Click += new System.EventHandler(this.CalcularBton_Click);
            // 
            // TipoCalculoBox
            // 
            this.TipoCalculoBox.FormattingEnabled = true;
            this.TipoCalculoBox.Items.AddRange(new object[] {
            "Suma",
            "Totales",
            "BuscarPalabra",
            "FiltrarPorFecha"});
            this.TipoCalculoBox.Location = new System.Drawing.Point(124, 12);
            this.TipoCalculoBox.Name = "TipoCalculoBox";
            this.TipoCalculoBox.Size = new System.Drawing.Size(121, 21);
            this.TipoCalculoBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "TipoCalculo";
            // 
            // TotalTodostxt
            // 
            this.TotalTodostxt.Location = new System.Drawing.Point(85, 342);
            this.TotalTodostxt.Name = "TotalTodostxt";
            this.TotalTodostxt.Size = new System.Drawing.Size(100, 20);
            this.TotalTodostxt.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total:";
            // 
            // ConsultarLiquidacionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 480);
            this.Controls.Add(this.TotalTodostxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TipoCalculoBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CalcularBton);
            this.Controls.Add(this.FechaDt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PalabraTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubsidiadoTxt);
            this.Controls.Add(this.Contributivotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarLiquidacionFrm";
            this.Text = "ConsultarLiquidacionFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TipoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Contributivotxt;
        private System.Windows.Forms.TextBox SubsidiadoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PalabraTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechaDt;
        private System.Windows.Forms.Button CalcularBton;
        private System.Windows.Forms.ComboBox TipoCalculoBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalTodostxt;
        private System.Windows.Forms.Label label7;
    }
}
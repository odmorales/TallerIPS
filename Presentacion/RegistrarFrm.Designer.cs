namespace Presentacion
{
    partial class RegistrarFrm
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
            this.FechaLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.ValorServicioTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SalarioTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoAfiliacionBox = new System.Windows.Forms.ComboBox();
            this.Tipolbl = new System.Windows.Forms.Label();
            this.IdentificacionTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NoLiquidacionTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FechaLiquidacion
            // 
            this.FechaLiquidacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLiquidacion.Location = new System.Drawing.Point(84, 351);
            this.FechaLiquidacion.Name = "FechaLiquidacion";
            this.FechaLiquidacion.Size = new System.Drawing.Size(236, 21);
            this.FechaLiquidacion.TabIndex = 23;
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AgregarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AgregarBtn.Location = new System.Drawing.Point(413, 330);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(152, 42);
            this.AgregarBtn.TabIndex = 22;
            this.AgregarBtn.Text = "Registrar Liquidacion";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // ValorServicioTxt
            // 
            this.ValorServicioTxt.Location = new System.Drawing.Point(201, 291);
            this.ValorServicioTxt.Name = "ValorServicioTxt";
            this.ValorServicioTxt.Size = new System.Drawing.Size(121, 20);
            this.ValorServicioTxt.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(92, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Valor Servicio:";
            // 
            // SalarioTxt
            // 
            this.SalarioTxt.Location = new System.Drawing.Point(201, 235);
            this.SalarioTxt.Name = "SalarioTxt";
            this.SalarioTxt.Size = new System.Drawing.Size(121, 20);
            this.SalarioTxt.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(128, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Salario:";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(201, 182);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(121, 20);
            this.NombreTxt.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(121, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre:";
            // 
            // TipoAfiliacionBox
            // 
            this.TipoAfiliacionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoAfiliacionBox.FormattingEnabled = true;
            this.TipoAfiliacionBox.Items.AddRange(new object[] {
            "Contributivo",
            "Subsidiado"});
            this.TipoAfiliacionBox.Location = new System.Drawing.Point(201, 138);
            this.TipoAfiliacionBox.Name = "TipoAfiliacionBox";
            this.TipoAfiliacionBox.Size = new System.Drawing.Size(119, 21);
            this.TipoAfiliacionBox.TabIndex = 15;
            // 
            // Tipolbl
            // 
            this.Tipolbl.AutoSize = true;
            this.Tipolbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipolbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tipolbl.Location = new System.Drawing.Point(92, 140);
            this.Tipolbl.Name = "Tipolbl";
            this.Tipolbl.Size = new System.Drawing.Size(83, 16);
            this.Tipolbl.TabIndex = 14;
            this.Tipolbl.Text = "Tipo Afiliación:";
            // 
            // IdentificacionTxt
            // 
            this.IdentificacionTxt.Location = new System.Drawing.Point(201, 61);
            this.IdentificacionTxt.Name = "IdentificacionTxt";
            this.IdentificacionTxt.Size = new System.Drawing.Size(121, 20);
            this.IdentificacionTxt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(90, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Identificación:";
            // 
            // NoLiquidacionTxt
            // 
            this.NoLiquidacionTxt.Location = new System.Drawing.Point(201, 99);
            this.NoLiquidacionTxt.Name = "NoLiquidacionTxt";
            this.NoLiquidacionTxt.Size = new System.Drawing.Size(121, 20);
            this.NoLiquidacionTxt.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(83, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "No.Liquidacion:";
            // 
            // RegistrarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 509);
            this.Controls.Add(this.NoLiquidacionTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechaLiquidacion);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.ValorServicioTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SalarioTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipoAfiliacionBox);
            this.Controls.Add(this.Tipolbl);
            this.Controls.Add(this.IdentificacionTxt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarFrm";
            this.Text = "RegistrarFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaLiquidacion;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.TextBox ValorServicioTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SalarioTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoAfiliacionBox;
        private System.Windows.Forms.Label Tipolbl;
        private System.Windows.Forms.TextBox IdentificacionTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NoLiquidacionTxt;
        private System.Windows.Forms.Label label5;
    }
}
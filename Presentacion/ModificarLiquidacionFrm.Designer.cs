namespace Presentacion
{
    partial class ModificarLiquidacionFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarLiquidacionFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.NoLiquidacionTxt = new System.Windows.Forms.TextBox();
            this.BuscarBton = new System.Windows.Forms.Button();
            this.ModificarBton = new System.Windows.Forms.Button();
            this.ValorServicioTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "No.Liquidacion:";
            // 
            // NoLiquidacionTxt
            // 
            this.NoLiquidacionTxt.Location = new System.Drawing.Point(332, 130);
            this.NoLiquidacionTxt.Name = "NoLiquidacionTxt";
            this.NoLiquidacionTxt.Size = new System.Drawing.Size(109, 20);
            this.NoLiquidacionTxt.TabIndex = 1;
            // 
            // BuscarBton
            // 
            this.BuscarBton.AutoSize = true;
            this.BuscarBton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarBton.Image")));
            this.BuscarBton.Location = new System.Drawing.Point(464, 122);
            this.BuscarBton.Name = "BuscarBton";
            this.BuscarBton.Size = new System.Drawing.Size(75, 38);
            this.BuscarBton.TabIndex = 2;
            this.BuscarBton.UseVisualStyleBackColor = true;
            
            // 
            // ModificarBton
            // 
            this.ModificarBton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarBton.Location = new System.Drawing.Point(464, 268);
            this.ModificarBton.Name = "ModificarBton";
            this.ModificarBton.Size = new System.Drawing.Size(94, 32);
            this.ModificarBton.TabIndex = 3;
            this.ModificarBton.Text = "Modificar";
            this.ModificarBton.UseVisualStyleBackColor = true;
            this.ModificarBton.Click += new System.EventHandler(this.ModificarBton_Click);
            // 
            // ValorServicioTxt
            // 
            this.ValorServicioTxt.Location = new System.Drawing.Point(332, 202);
            this.ValorServicioTxt.Name = "ValorServicioTxt";
            this.ValorServicioTxt.Size = new System.Drawing.Size(109, 20);
            this.ValorServicioTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Servicio:";
            // 
            // ModificarLiquidacionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 494);
            this.Controls.Add(this.ValorServicioTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModificarBton);
            this.Controls.Add(this.BuscarBton);
            this.Controls.Add(this.NoLiquidacionTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarLiquidacionFrm";
            this.Text = "ModificarLiquidacionFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NoLiquidacionTxt;
        private System.Windows.Forms.Button BuscarBton;
        private System.Windows.Forms.Button ModificarBton;
        private System.Windows.Forms.TextBox ValorServicioTxt;
        private System.Windows.Forms.Label label2;
    }
}
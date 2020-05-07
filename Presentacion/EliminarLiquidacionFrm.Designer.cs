namespace Presentacion
{
    partial class EliminarLiquidacionFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarLiquidacionFrm));
            this.ValorServicioTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ModificarBton = new System.Windows.Forms.Button();
            this.BuscarBton = new System.Windows.Forms.Button();
            this.NoLiquidacionTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValorServicioTxt
            // 
            this.ValorServicioTxt.Location = new System.Drawing.Point(353, 217);
            this.ValorServicioTxt.Name = "ValorServicioTxt";
            this.ValorServicioTxt.Size = new System.Drawing.Size(109, 20);
            this.ValorServicioTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor Servicio:";
            // 
            // ModificarBton
            // 
            this.ModificarBton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarBton.Location = new System.Drawing.Point(485, 277);
            this.ModificarBton.Name = "ModificarBton";
            this.ModificarBton.Size = new System.Drawing.Size(94, 32);
            this.ModificarBton.TabIndex = 9;
            this.ModificarBton.Text = "Eliminar";
            this.ModificarBton.UseVisualStyleBackColor = true;
            this.ModificarBton.Click += new System.EventHandler(this.ModificarBton_Click);
            // 
            // BuscarBton
            // 
            this.BuscarBton.AutoSize = true;
            this.BuscarBton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarBton.Image")));
            this.BuscarBton.Location = new System.Drawing.Point(485, 137);
            this.BuscarBton.Name = "BuscarBton";
            this.BuscarBton.Size = new System.Drawing.Size(75, 38);
            this.BuscarBton.TabIndex = 8;
            this.BuscarBton.UseVisualStyleBackColor = true;
            this.BuscarBton.Click += new System.EventHandler(this.BuscarBton_Click);
            // 
            // NoLiquidacionTxt
            // 
            this.NoLiquidacionTxt.Location = new System.Drawing.Point(353, 145);
            this.NoLiquidacionTxt.Name = "NoLiquidacionTxt";
            this.NoLiquidacionTxt.Size = new System.Drawing.Size(109, 20);
            this.NoLiquidacionTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "No.Liquidacion:";
            // 
            // EliminarLiquidacionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 465);
            this.Controls.Add(this.ValorServicioTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModificarBton);
            this.Controls.Add(this.BuscarBton);
            this.Controls.Add(this.NoLiquidacionTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarLiquidacionFrm";
            this.Text = "EliminarLiquidacionFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValorServicioTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ModificarBton;
        private System.Windows.Forms.Button BuscarBton;
        private System.Windows.Forms.TextBox NoLiquidacionTxt;
        private System.Windows.Forms.Label label1;
    }
}
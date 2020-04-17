namespace Calculadora_IMC
{
    partial class Form1
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
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.labelTextHight = new System.Windows.Forms.Label();
            this.labelTextWreight = new System.Windows.Forms.Label();
            this.labelIMC = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelResultado
            // 
            this.labelResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResultado.Location = new System.Drawing.Point(102, 177);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(155, 20);
            this.labelResultado.TabIndex = 25;
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(28, 177);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(68, 56);
            this.buttonCalc.TabIndex = 24;
            this.buttonCalc.Text = "Calcular";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(102, 142);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(155, 20);
            this.txtAltura.TabIndex = 23;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(102, 104);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(155, 20);
            this.txtPeso.TabIndex = 22;
            // 
            // labelTextHight
            // 
            this.labelTextHight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTextHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextHight.Location = new System.Drawing.Point(28, 142);
            this.labelTextHight.Name = "labelTextHight";
            this.labelTextHight.Size = new System.Drawing.Size(68, 20);
            this.labelTextHight.TabIndex = 21;
            this.labelTextHight.Text = "Altura";
            this.labelTextHight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTextWreight
            // 
            this.labelTextWreight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTextWreight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextWreight.Location = new System.Drawing.Point(28, 104);
            this.labelTextWreight.Name = "labelTextWreight";
            this.labelTextWreight.Size = new System.Drawing.Size(68, 20);
            this.labelTextWreight.TabIndex = 20;
            this.labelTextWreight.Text = "Peso";
            this.labelTextWreight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIMC
            // 
            this.labelIMC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelIMC.Location = new System.Drawing.Point(102, 213);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(155, 20);
            this.labelIMC.TabIndex = 27;
            this.labelIMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(28, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(229, 63);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "Cálculo de IMC";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.labelTextHight);
            this.Controls.Add(this.labelTextWreight);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label labelTextHight;
        private System.Windows.Forms.Label labelTextWreight;
        private System.Windows.Forms.Label labelIMC;
        private System.Windows.Forms.Label labelTitle;
    }
}


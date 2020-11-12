namespace Ejercicio11dePOOPunto2.View
{
    partial class FormAgregarEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarEditar));
            this.NumericX = new System.Windows.Forms.NumericUpDown();
            this.NumericY = new System.Windows.Forms.NumericUpDown();
            this.NumericRadio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.ComboBoxBorde = new System.Windows.Forms.ComboBox();
            this.ComboBoxRelleno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRadio)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericX
            // 
            this.NumericX.Location = new System.Drawing.Point(53, 7);
            this.NumericX.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NumericX.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.NumericX.Name = "NumericX";
            this.NumericX.Size = new System.Drawing.Size(62, 20);
            this.NumericX.TabIndex = 0;
            // 
            // NumericY
            // 
            this.NumericY.Location = new System.Drawing.Point(121, 7);
            this.NumericY.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NumericY.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.NumericY.Name = "NumericY";
            this.NumericY.Size = new System.Drawing.Size(62, 20);
            this.NumericY.TabIndex = 1;
            // 
            // NumericRadio
            // 
            this.NumericRadio.Location = new System.Drawing.Point(53, 33);
            this.NumericRadio.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NumericRadio.Name = "NumericRadio";
            this.NumericRadio.Size = new System.Drawing.Size(130, 20);
            this.NumericRadio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Centro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Radio";
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BotonAceptar.Image")));
            this.BotonAceptar.Location = new System.Drawing.Point(12, 124);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(77, 44);
            this.BotonAceptar.TabIndex = 5;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BotonCancelar.Image")));
            this.BotonCancelar.Location = new System.Drawing.Point(107, 124);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(77, 44);
            this.BotonCancelar.TabIndex = 6;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // ComboBoxBorde
            // 
            this.ComboBoxBorde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBorde.FormattingEnabled = true;
            this.ComboBoxBorde.Location = new System.Drawing.Point(53, 60);
            this.ComboBoxBorde.Name = "ComboBoxBorde";
            this.ComboBoxBorde.Size = new System.Drawing.Size(130, 21);
            this.ComboBoxBorde.TabIndex = 7;
            // 
            // ComboBoxRelleno
            // 
            this.ComboBoxRelleno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRelleno.FormattingEnabled = true;
            this.ComboBoxRelleno.Location = new System.Drawing.Point(53, 87);
            this.ComboBoxRelleno.Name = "ComboBoxRelleno";
            this.ComboBoxRelleno.Size = new System.Drawing.Size(130, 21);
            this.ComboBoxRelleno.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Borde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Relleno";
            // 
            // FormAgregarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 179);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxRelleno);
            this.Controls.Add(this.ComboBoxBorde);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericRadio);
            this.Controls.Add(this.NumericY);
            this.Controls.Add(this.NumericX);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarEditar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormAgregarEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRadio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericX;
        private System.Windows.Forms.NumericUpDown NumericY;
        private System.Windows.Forms.NumericUpDown NumericRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.ComboBox ComboBoxBorde;
        private System.Windows.Forms.ComboBox ComboBoxRelleno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
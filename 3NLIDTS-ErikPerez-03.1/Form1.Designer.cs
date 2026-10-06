namespace _3NLIDTS_ErikPerez_03._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblCelsius = new Label();
            lblFahrenheit = new Label();
            lblKelvin = new Label();
            txtCelsius = new TextBox();
            txtFahrenheit = new TextBox();
            txtKelvin = new TextBox();
            rdbCelsius = new RadioButton();
            rdbFahrenheit = new RadioButton();
            rdbKelvin = new RadioButton();
            grpOpciones = new GroupBox();
            grpOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(449, 175);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(69, 33);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(524, 175);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(69, 33);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(599, 175);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(69, 33);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCelsius
            // 
            lblCelsius.AutoSize = true;
            lblCelsius.Location = new Point(174, 87);
            lblCelsius.Name = "lblCelsius";
            lblCelsius.Size = new Size(44, 15);
            lblCelsius.TabIndex = 3;
            lblCelsius.Text = "Celsius";
            lblCelsius.UseMnemonic = false;
            // 
            // lblFahrenheit
            // 
            lblFahrenheit.AutoSize = true;
            lblFahrenheit.Location = new Point(152, 113);
            lblFahrenheit.Name = "lblFahrenheit";
            lblFahrenheit.Size = new Size(66, 15);
            lblFahrenheit.TabIndex = 4;
            lblFahrenheit.Text = "Fahrenheit:";
            lblFahrenheit.Click += label2_Click;
            // 
            // lblKelvin
            // 
            lblKelvin.AutoSize = true;
            lblKelvin.Location = new Point(180, 148);
            lblKelvin.Name = "lblKelvin";
            lblKelvin.Size = new Size(42, 15);
            lblKelvin.TabIndex = 5;
            lblKelvin.Text = "Kelvin:";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(224, 84);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(100, 23);
            txtCelsius.TabIndex = 6;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(224, 113);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(100, 23);
            txtFahrenheit.TabIndex = 7;
            // 
            // txtKelvin
            // 
            txtKelvin.Location = new Point(224, 145);
            txtKelvin.Name = "txtKelvin";
            txtKelvin.Size = new Size(100, 23);
            txtKelvin.TabIndex = 8;
            // 
            // rdbCelsius
            // 
            rdbCelsius.AutoSize = true;
            rdbCelsius.Location = new Point(43, 23);
            rdbCelsius.Name = "rdbCelsius";
            rdbCelsius.Size = new Size(62, 19);
            rdbCelsius.TabIndex = 9;
            rdbCelsius.TabStop = true;
            rdbCelsius.Text = "Celsius";
            rdbCelsius.UseVisualStyleBackColor = true;
            // 
            // rdbFahrenheit
            // 
            rdbFahrenheit.AutoSize = true;
            rdbFahrenheit.Location = new Point(43, 54);
            rdbFahrenheit.Name = "rdbFahrenheit";
            rdbFahrenheit.Size = new Size(81, 19);
            rdbFahrenheit.TabIndex = 10;
            rdbFahrenheit.TabStop = true;
            rdbFahrenheit.Text = "Fahrenheit";
            rdbFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rdbKelvin
            // 
            rdbKelvin.AutoSize = true;
            rdbKelvin.Location = new Point(43, 85);
            rdbKelvin.Name = "rdbKelvin";
            rdbKelvin.Size = new Size(57, 19);
            rdbKelvin.TabIndex = 11;
            rdbKelvin.TabStop = true;
            rdbKelvin.Text = "Kelvin";
            rdbKelvin.UseVisualStyleBackColor = true;
            // 
            // grpOpciones
            // 
            grpOpciones.BackColor = Color.Transparent;
            grpOpciones.Controls.Add(rdbKelvin);
            grpOpciones.Controls.Add(rdbFahrenheit);
            grpOpciones.Controls.Add(rdbCelsius);
            grpOpciones.ForeColor = SystemColors.ButtonFace;
            grpOpciones.Location = new Point(449, 34);
            grpOpciones.Name = "grpOpciones";
            grpOpciones.Size = new Size(269, 129);
            grpOpciones.TabIndex = 12;
            grpOpciones.TabStop = false;
            grpOpciones.Text = "Convertir desde:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(grpOpciones);
            Controls.Add(txtKelvin);
            Controls.Add(txtFahrenheit);
            Controls.Add(txtCelsius);
            Controls.Add(lblKelvin);
            Controls.Add(lblFahrenheit);
            Controls.Add(lblCelsius);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            grpOpciones.ResumeLayout(false);
            grpOpciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblCelsius;
        private Label lblFahrenheit;
        private Label lblKelvin;
        private TextBox txtCelsius;
        private TextBox txtFahrenheit;
        private TextBox txtKelvin;
        private RadioButton rdbCelsius;
        private RadioButton rdbFahrenheit;
        private RadioButton rdbKelvin;
        private GroupBox grpOpciones;
    }
}

namespace GestorInfPers
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
            tabControl1 = new TabControl();
            tabDatosPersonales = new TabPage();
            panel1 = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            monthCalendar1 = new MonthCalendar();
            txtbxCorreo = new TextBox();
            txtbxDireccion = new TextBox();
            txtbdApellidos = new TextBox();
            txtbxNombre = new TextBox();
            lblEdad = new Label();
            label5 = new Label();
            lblCorreo = new Label();
            lblDireccion = new Label();
            lblApellidos = new Label();
            lblNombre = new Label();
            tabPreferencias = new TabPage();
            tabVisualizacion = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            chkbxBoletin = new CheckBox();
            chkLstHobbies = new CheckedListBox();
            cmbxPaises = new ComboBox();
            lblPais = new Label();
            lblPaises = new Label();
            tabControl1.SuspendLayout();
            tabDatosPersonales.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPreferencias.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDatosPersonales);
            tabControl1.Controls.Add(tabPreferencias);
            tabControl1.Controls.Add(tabVisualizacion);
            tabControl1.Location = new Point(12, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1383, 851);
            tabControl1.TabIndex = 0;
            // 
            // tabDatosPersonales
            // 
            tabDatosPersonales.Controls.Add(panel1);
            tabDatosPersonales.Controls.Add(numericUpDown1);
            tabDatosPersonales.Controls.Add(label1);
            tabDatosPersonales.Controls.Add(monthCalendar1);
            tabDatosPersonales.Controls.Add(txtbxCorreo);
            tabDatosPersonales.Controls.Add(txtbxDireccion);
            tabDatosPersonales.Controls.Add(txtbdApellidos);
            tabDatosPersonales.Controls.Add(txtbxNombre);
            tabDatosPersonales.Controls.Add(lblEdad);
            tabDatosPersonales.Controls.Add(label5);
            tabDatosPersonales.Controls.Add(lblCorreo);
            tabDatosPersonales.Controls.Add(lblDireccion);
            tabDatosPersonales.Controls.Add(lblApellidos);
            tabDatosPersonales.Controls.Add(lblNombre);
            tabDatosPersonales.Location = new Point(8, 46);
            tabDatosPersonales.Name = "tabDatosPersonales";
            tabDatosPersonales.Padding = new Padding(3);
            tabDatosPersonales.Size = new Size(1367, 797);
            tabDatosPersonales.TabIndex = 0;
            tabDatosPersonales.Text = "Datos Personales";
            tabDatosPersonales.UseVisualStyleBackColor = true;
            tabDatosPersonales.Click += tabDatosPersonales_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(898, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 166);
            panel1.TabIndex = 13;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(3, 112);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(93, 36);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Otro";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(4, 57);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(152, 36);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Femenino";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(154, 36);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(498, 144);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(240, 39);
            numericUpDown1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(935, 90);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 11;
            label1.Text = "Genero";
            label1.Click += label1_Click_1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(467, 249);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // txtbxCorreo
            // 
            txtbxCorreo.Location = new Point(865, 389);
            txtbxCorreo.Name = "txtbxCorreo";
            txtbxCorreo.Size = new Size(259, 39);
            txtbxCorreo.TabIndex = 9;
            // 
            // txtbxDireccion
            // 
            txtbxDireccion.Location = new Point(171, 402);
            txtbxDireccion.Name = "txtbxDireccion";
            txtbxDireccion.Size = new Size(259, 39);
            txtbxDireccion.TabIndex = 8;
            // 
            // txtbdApellidos
            // 
            txtbdApellidos.Location = new Point(171, 269);
            txtbdApellidos.Name = "txtbdApellidos";
            txtbdApellidos.Size = new Size(259, 39);
            txtbdApellidos.TabIndex = 7;
            // 
            // txtbxNombre
            // 
            txtbxNombre.Location = new Point(171, 143);
            txtbxNombre.Name = "txtbxNombre";
            txtbxNombre.Size = new Size(259, 39);
            txtbxNombre.TabIndex = 6;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(588, 90);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(66, 32);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(536, 208);
            label5.Name = "label5";
            label5.Size = new Size(202, 32);
            label5.TabIndex = 4;
            label5.Text = "Fecha nacimiento";
            label5.Click += label5_Click;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(941, 354);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(86, 32);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo";
            lblCorreo.Click += lblCorreo_Click;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(239, 354);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(114, 32);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Direccion";
            lblDireccion.Click += label3_Click;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(231, 208);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(112, 32);
            lblApellidos.TabIndex = 1;
            lblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(239, 90);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(102, 32);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // tabPreferencias
            // 
            tabPreferencias.Controls.Add(lblPaises);
            tabPreferencias.Controls.Add(lblPais);
            tabPreferencias.Controls.Add(cmbxPaises);
            tabPreferencias.Controls.Add(chkLstHobbies);
            tabPreferencias.Controls.Add(chkbxBoletin);
            tabPreferencias.Location = new Point(8, 46);
            tabPreferencias.Name = "tabPreferencias";
            tabPreferencias.Padding = new Padding(3);
            tabPreferencias.Size = new Size(1367, 797);
            tabPreferencias.TabIndex = 1;
            tabPreferencias.Text = "Preferencias";
            tabPreferencias.UseVisualStyleBackColor = true;
            tabPreferencias.Click += tabPreferencias_Click;
            // 
            // tabVisualizacion
            // 
            tabVisualizacion.Location = new Point(8, 46);
            tabVisualizacion.Name = "tabVisualizacion";
            tabVisualizacion.Padding = new Padding(3);
            tabVisualizacion.Size = new Size(1367, 797);
            tabVisualizacion.TabIndex = 2;
            tabVisualizacion.Text = "Visualizacion";
            tabVisualizacion.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnGuardar);
            flowLayoutPanel1.Controls.Add(btnLimpiar);
            flowLayoutPanel1.Controls.Add(btnSalir);
            flowLayoutPanel1.Location = new Point(20, 880);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(504, 46);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(3, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(162, 43);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(171, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(162, 43);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(339, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(162, 43);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // chkbxBoletin
            // 
            chkbxBoletin.AutoSize = true;
            chkbxBoletin.Location = new Point(171, 283);
            chkbxBoletin.Name = "chkbxBoletin";
            chkbxBoletin.Size = new Size(288, 36);
            chkbxBoletin.TabIndex = 0;
            chkbxBoletin.Text = "¿Suscribirse al boletin?";
            chkbxBoletin.UseVisualStyleBackColor = true;
            chkbxBoletin.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkLstHobbies
            // 
            chkLstHobbies.FormattingEnabled = true;
            chkLstHobbies.Items.AddRange(new object[] { "Badminton", "Programar", "Meditar", "Bailar" });
            chkLstHobbies.Location = new Point(639, 335);
            chkLstHobbies.Name = "chkLstHobbies";
            chkLstHobbies.Size = new Size(239, 148);
            chkLstHobbies.TabIndex = 1;
            // 
            // cmbxPaises
            // 
            cmbxPaises.FormattingEnabled = true;
            cmbxPaises.Items.AddRange(new object[] { "Inglaterra", "China", "Corea", "Argentina", "Marruecos" });
            cmbxPaises.Location = new Point(171, 387);
            cmbxPaises.Name = "cmbxPaises";
            cmbxPaises.Size = new Size(242, 40);
            cmbxPaises.TabIndex = 2;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(650, 283);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(102, 32);
            lblPais.TabIndex = 3;
            lblPais.Text = "Hobbies";
            // 
            // lblPaises
            // 
            lblPaises.AutoSize = true;
            lblPaises.Location = new Point(171, 335);
            lblPaises.Name = "lblPaises";
            lblPaises.Size = new Size(77, 32);
            lblPaises.TabIndex = 4;
            lblPaises.Text = "Paises";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 949);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Gestion avanzada de informacion personal";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabDatosPersonales.ResumeLayout(false);
            tabDatosPersonales.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPreferencias.ResumeLayout(false);
            tabPreferencias.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabDatosPersonales;
        private TabPage tabPreferencias;
        private TabPage tabVisualizacion;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblCorreo;
        private Label lblDireccion;
        private Label lblApellidos;
        private Label lblNombre;
        private Label lblEdad;
        private Label label5;
        private TextBox txtbxDireccion;
        private TextBox txtbdApellidos;
        private TextBox txtbxNombre;
        private MonthCalendar monthCalendar1;
        private TextBox txtbxCorreo;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Panel panel1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox cmbxPaises;
        private CheckedListBox chkLstHobbies;
        private CheckBox chkbxBoletin;
        private Label lblPaises;
        private Label lblPais;
    }
}

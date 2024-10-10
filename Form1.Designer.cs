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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabDatosPersonales = new TabPage();
            chkgrpGenero = new Panel();
            rbtnOtro = new RadioButton();
            rbtnFemenino = new RadioButton();
            rbtnMasculino = new RadioButton();
            nupdownEdad = new NumericUpDown();
            lblGenero = new Label();
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
            lblPaises = new Label();
            lblPais = new Label();
            cmbxPaises = new ComboBox();
            chkLstHobbies = new CheckedListBox();
            chkbxBoletin = new CheckBox();
            tabVisualizacion = new TabPage();
            lblCronometro = new Label();
            btnImagenes = new Button();
            lblFoto = new Label();
            picAleatorio = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            helpProvider1 = new HelpProvider();
            imageList1 = new ImageList(components);
            tabControl1.SuspendLayout();
            tabDatosPersonales.SuspendLayout();
            chkgrpGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupdownEdad).BeginInit();
            tabPreferencias.SuspendLayout();
            tabVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAleatorio).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDatosPersonales);
            tabControl1.Controls.Add(tabPreferencias);
            tabControl1.Controls.Add(tabVisualizacion);
            tabControl1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            tabControl1.Location = new Point(12, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1383, 851);
            tabControl1.TabIndex = 0;
            // 
            // tabDatosPersonales
            // 
            tabDatosPersonales.BackColor = Color.FromArgb(0, 64, 64);
            tabDatosPersonales.Controls.Add(chkgrpGenero);
            tabDatosPersonales.Controls.Add(nupdownEdad);
            tabDatosPersonales.Controls.Add(lblGenero);
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
            tabDatosPersonales.Click += tabDatosPersonales_Click;
            // 
            // chkgrpGenero
            // 
            chkgrpGenero.Controls.Add(rbtnOtro);
            chkgrpGenero.Controls.Add(rbtnFemenino);
            chkgrpGenero.Controls.Add(rbtnMasculino);
            chkgrpGenero.Location = new Point(898, 157);
            chkgrpGenero.Name = "chkgrpGenero";
            chkgrpGenero.Size = new Size(192, 166);
            chkgrpGenero.TabIndex = 13;
            // 
            // rbtnOtro
            // 
            rbtnOtro.AutoSize = true;
            rbtnOtro.ForeColor = Color.Yellow;
            rbtnOtro.Location = new Point(3, 112);
            rbtnOtro.Name = "rbtnOtro";
            rbtnOtro.Size = new Size(97, 36);
            rbtnOtro.TabIndex = 2;
            rbtnOtro.TabStop = true;
            rbtnOtro.Text = "Otro";
            rbtnOtro.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.ForeColor = Color.Yellow;
            rbtnFemenino.Location = new Point(4, 57);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(158, 36);
            rbtnFemenino.TabIndex = 1;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.ForeColor = Color.Yellow;
            rbtnMasculino.Location = new Point(3, 3);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(164, 36);
            rbtnMasculino.TabIndex = 0;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // nupdownEdad
            // 
            nupdownEdad.Location = new Point(516, 144);
            nupdownEdad.Name = "nupdownEdad";
            nupdownEdad.Size = new Size(240, 39);
            nupdownEdad.TabIndex = 12;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Trebuchet MS", 12F);
            lblGenero.ForeColor = Color.Yellow;
            lblGenero.Location = new Point(935, 90);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(119, 40);
            lblGenero.TabIndex = 11;
            lblGenero.Text = "Genero";
            lblGenero.Click += label1_Click_1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.Teal;
            monthCalendar1.Location = new Point(474, 269);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            monthCalendar1.TitleBackColor = SystemColors.AppWorkspace;
            // 
            // txtbxCorreo
            // 
            txtbxCorreo.BackColor = SystemColors.Menu;
            txtbxCorreo.Location = new Point(864, 397);
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
            lblEdad.Font = new Font("Trebuchet MS", 12F);
            lblEdad.ForeColor = Color.Yellow;
            lblEdad.Location = new Point(606, 90);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(87, 40);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(498, 218);
            label5.Name = "label5";
            label5.Size = new Size(270, 40);
            label5.TabIndex = 4;
            label5.Text = "Fecha nacimiento";
            label5.Click += label5_Click;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Trebuchet MS", 12F);
            lblCorreo.ForeColor = Color.Yellow;
            lblCorreo.Location = new Point(941, 354);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(111, 40);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo";
            lblCorreo.Click += lblCorreo_Click;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Trebuchet MS", 12F);
            lblDireccion.ForeColor = Color.Yellow;
            lblDireccion.Location = new Point(214, 354);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(150, 40);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Direccion";
            lblDireccion.Click += label3_Click;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Trebuchet MS", 12F);
            lblApellidos.ForeColor = Color.Yellow;
            lblApellidos.Location = new Point(229, 218);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(146, 40);
            lblApellidos.TabIndex = 1;
            lblApellidos.Text = "Apellidos";
            lblApellidos.Click += lblApellidos_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(0, 64, 64);
            lblNombre.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Yellow;
            lblNombre.Location = new Point(225, 90);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(128, 40);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // tabPreferencias
            // 
            tabPreferencias.BackColor = Color.FromArgb(0, 64, 64);
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
            tabPreferencias.Click += tabPreferencias_Click;
            // 
            // lblPaises
            // 
            lblPaises.AutoSize = true;
            lblPaises.Font = new Font("Trebuchet MS", 12F);
            lblPaises.ForeColor = Color.Yellow;
            lblPaises.Location = new Point(171, 384);
            lblPaises.Name = "lblPaises";
            lblPaises.Size = new Size(103, 40);
            lblPaises.TabIndex = 4;
            lblPaises.Text = "Paises";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Font = new Font("Trebuchet MS", 12F);
            lblPais.ForeColor = Color.Yellow;
            lblPais.Location = new Point(650, 283);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(130, 40);
            lblPais.TabIndex = 3;
            lblPais.Text = "Hobbies";
            // 
            // cmbxPaises
            // 
            cmbxPaises.FormattingEnabled = true;
            cmbxPaises.Items.AddRange(new object[] { "Inglaterra", "China", "Corea", "Argentina", "Marruecos" });
            cmbxPaises.Location = new Point(181, 427);
            cmbxPaises.Name = "cmbxPaises";
            cmbxPaises.Size = new Size(242, 40);
            cmbxPaises.TabIndex = 2;
            // 
            // chkLstHobbies
            // 
            chkLstHobbies.BackColor = Color.FromArgb(0, 64, 64);
            chkLstHobbies.ForeColor = Color.Yellow;
            chkLstHobbies.FormattingEnabled = true;
            chkLstHobbies.Items.AddRange(new object[] { "Badminton", "Programar", "Meditar", "Bailar" });
            chkLstHobbies.Location = new Point(639, 335);
            chkLstHobbies.Name = "chkLstHobbies";
            chkLstHobbies.Size = new Size(239, 148);
            chkLstHobbies.TabIndex = 1;
            chkLstHobbies.SelectedIndexChanged += chkLstHobbies_SelectedIndexChanged;
            // 
            // chkbxBoletin
            // 
            chkbxBoletin.AutoSize = true;
            chkbxBoletin.Font = new Font("Trebuchet MS", 12F);
            chkbxBoletin.ForeColor = Color.Yellow;
            chkbxBoletin.Location = new Point(171, 283);
            chkbxBoletin.Name = "chkbxBoletin";
            chkbxBoletin.Size = new Size(370, 44);
            chkbxBoletin.TabIndex = 0;
            chkbxBoletin.Text = "¿Suscribirse al boletin?";
            chkbxBoletin.UseVisualStyleBackColor = true;
            chkbxBoletin.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tabVisualizacion
            // 
            tabVisualizacion.BackColor = Color.FromArgb(0, 64, 64);
            tabVisualizacion.Controls.Add(lblCronometro);
            tabVisualizacion.Controls.Add(btnImagenes);
            tabVisualizacion.Controls.Add(lblFoto);
            tabVisualizacion.Controls.Add(picAleatorio);
            tabVisualizacion.ForeColor = Color.Yellow;
            tabVisualizacion.Location = new Point(8, 46);
            tabVisualizacion.Name = "tabVisualizacion";
            tabVisualizacion.Padding = new Padding(3);
            tabVisualizacion.Size = new Size(1367, 797);
            tabVisualizacion.TabIndex = 2;
            tabVisualizacion.Text = "Visualizacion";
            tabVisualizacion.Click += tabVisualizacion_Click;
            // 
            // lblCronometro
            // 
            lblCronometro.AutoSize = true;
            lblCronometro.BackColor = Color.Gray;
            lblCronometro.Font = new Font("Segoe Script", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCronometro.ForeColor = Color.Yellow;
            lblCronometro.Location = new Point(165, 68);
            lblCronometro.Name = "lblCronometro";
            lblCronometro.Size = new Size(1011, 119);
            lblCronometro.TabIndex = 3;
            lblCronometro.Text = "DD/MM/YYY HH:MM:SS";
            lblCronometro.Click += label2_Click;
            // 
            // btnImagenes
            // 
            btnImagenes.BackColor = Color.FromArgb(255, 128, 128);
            btnImagenes.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnImagenes.Location = new Point(500, 586);
            btnImagenes.Name = "btnImagenes";
            btnImagenes.Size = new Size(270, 46);
            btnImagenes.TabIndex = 2;
            btnImagenes.Text = "Generar nueva foto";
            btnImagenes.UseVisualStyleBackColor = false;
            btnImagenes.Click += btn_Imagenes_Click;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoto.Location = new Point(500, 244);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(302, 40);
            lblFoto.TabIndex = 1;
            lblFoto.Text = "Elige foto aleatoria";
            // 
            // picAleatorio
            // 
            picAleatorio.Location = new Point(500, 325);
            picAleatorio.Name = "picAleatorio";
            picAleatorio.Size = new Size(280, 240);
            picAleatorio.TabIndex = 0;
            picAleatorio.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnGuardar);
            flowLayoutPanel1.Controls.Add(btnLimpiar);
            flowLayoutPanel1.Controls.Add(btnSalir);
            flowLayoutPanel1.Location = new Point(20, 872);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(550, 65);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 128, 128);
            btnGuardar.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.Yellow;
            btnGuardar.Location = new Point(3, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(172, 62);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 128, 128);
            btnLimpiar.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Yellow;
            btnLimpiar.Location = new Point(181, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(172, 62);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 128, 128);
            btnSalir.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Yellow;
            btnSalir.Location = new Point(359, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(172, 62);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(1467, 949);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Gestion avanzada de informacion personal";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabDatosPersonales.ResumeLayout(false);
            tabDatosPersonales.PerformLayout();
            chkgrpGenero.ResumeLayout(false);
            chkgrpGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupdownEdad).EndInit();
            tabPreferencias.ResumeLayout(false);
            tabPreferencias.PerformLayout();
            tabVisualizacion.ResumeLayout(false);
            tabVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAleatorio).EndInit();
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
        private Label lblGenero;
        private NumericUpDown nupdownEdad;
        private Panel chkgrpGenero;
        private RadioButton rbtnOtro;
        private RadioButton rbtnFemenino;
        private RadioButton rbtnMasculino;
        private ComboBox cmbxPaises;
        private CheckedListBox chkLstHobbies;
        private CheckBox chkbxBoletin;
        private Label lblPaises;
        private Label lblPais;
        private System.Windows.Forms.Timer timer1;
        private ToolTip toolTip1;
        private Button btnImagenes;
        private Label lblFoto;
        private Label lblCronometro;
        private HelpProvider helpProvider1;
        private PictureBox picAleatorio;
        private ImageList imageList1;
    }
}

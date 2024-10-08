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
            tabPreferencias = new TabPage();
            tabVisualizacion = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tabControl1.SuspendLayout();
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
            tabControl1.Size = new Size(1668, 874);
            tabControl1.TabIndex = 0;
            // 
            // tabDatosPersonales
            // 
            tabDatosPersonales.Location = new Point(8, 46);
            tabDatosPersonales.Name = "tabDatosPersonales";
            tabDatosPersonales.Padding = new Padding(3);
            tabDatosPersonales.Size = new Size(1652, 820);
            tabDatosPersonales.TabIndex = 0;
            tabDatosPersonales.Text = "Datos Personales";
            tabDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // tabPreferencias
            // 
            tabPreferencias.Location = new Point(8, 46);
            tabPreferencias.Name = "tabPreferencias";
            tabPreferencias.Padding = new Padding(3);
            tabPreferencias.Size = new Size(1652, 820);
            tabPreferencias.TabIndex = 1;
            tabPreferencias.Text = "Preferencias";
            tabPreferencias.UseVisualStyleBackColor = true;
            // 
            // tabVisualizacion
            // 
            tabVisualizacion.Location = new Point(8, 46);
            tabVisualizacion.Name = "tabVisualizacion";
            tabVisualizacion.Padding = new Padding(3);
            tabVisualizacion.Size = new Size(1652, 820);
            tabVisualizacion.TabIndex = 2;
            tabVisualizacion.Text = "Visualizacion";
            tabVisualizacion.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Location = new Point(20, 880);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(504, 46);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(162, 43);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(171, 3);
            button2.Name = "button2";
            button2.Size = new Size(162, 43);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(339, 3);
            button3.Name = "button3";
            button3.Size = new Size(162, 43);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1692, 934);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Gestion avanzada de informacion personal";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabDatosPersonales;
        private TabPage tabPreferencias;
        private TabPage tabVisualizacion;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}

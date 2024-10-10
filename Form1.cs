using System.Collections;
using System.Windows.Forms;

namespace GestorInfPers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblCronometro.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void tabDatosPersonales_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPreferencias_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbdApellidos.Text = String.Empty;
            txtbxCorreo.Text = String.Empty;
            txtbxNombre.Text = String.Empty;
            txtbxDireccion.Text = String.Empty;
            nupdownEdad.ResetText();

            for (int i = 0; i < chkLstHobbies.Items.Count; i++)
            {
                chkLstHobbies.SetItemChecked(i, false);
            }




            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
            rbtnOtro.Checked = false;
            chkbxBoletin.Checked = false;






        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkLstHobbies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cmbxPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (camposVacios())
            {
                MessageBox.Show("Completa todos los campos");
                }
            else
            {
                if (!edadCorrecta())
                {

                    DialogResult result = MessageBox.Show("La edad no coincide con la fecha de nacimiento \n ¿Continuar?", "Error edad/fecha de nacimiento", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        mostrarResumen();
                    }
                }
                else { mostrarResumen(); }


            }
        }

         
        
        
        void mostrarResumen()
        {
            String nombre = txtbxNombre.Text;
            String apellidos = txtbdApellidos.Text;
            String email = txtbxCorreo.Text.ToString();
            String edad = nupdownEdad.Text.ToString();
            DateTime fecha_nac = monthCalendar1.SelectionStart;
            String genero = "";
            if (rbtnMasculino.Checked)
            {
                genero = "hombre";
            }
            else if (rbtnOtro.Checked)
            {
                genero = "ni hombre ni mujer";
            }
            else if (rbtnFemenino.Checked)
            {
                genero = "mujer";
            }
            String suscrito = "";
            if (chkbxBoletin.Checked) { suscrito = "suscrito al boletin"; } else suscrito = "no estas suscrito al boletin";
            String paises = cmbxPaises.Text;
            
           
            
            
            
           

            MessageBox.Show(
                "Te llamas " + nombre + " ," + genero + " de"+ edad+" años "+ "en " + paises + " , naciste el " + fecha_nac+
                " \n" +ListaHobbies()+ "y" + suscrito + "\n"

                , "Resumen para " + lblCorreo);
        }


        String ListaHobbies()
        {
            // Verificar si hay elementos seleccionados en el CheckedListBox
            if (chkLstHobbies.CheckedItems.Count == 0)
            {
                return "Sin hobbies";
            }

            String lista = "Tus hobbies son ";
            ArrayList hobbies = new ArrayList();

            // Recorrer los ítems seleccionados en el CheckedListBox
            foreach (var item in chkLstHobbies.CheckedItems)
            {
                hobbies.Add(item.ToString());
                lista += item.ToString() + ", ";
            }

           

            return lista;
        }


        bool edadCorrecta()
        {
            int edad;
            int year_actual;
            int edadCalender;
            int.TryParse(DateTime.Now.Year.ToString(), out edad);
            int.TryParse(monthCalendar1.SelectionStart.Year.ToString(), out year_actual);
            int.TryParse(nupdownEdad.Text.ToString(), out edadCalender);


            if ((year_actual - edad) == edadCalender)
            {
                return true;
            }
            else return false;
        }
        bool camposVacios()
        {


            if (string.IsNullOrWhiteSpace(txtbxNombre.Text) ||
            string.IsNullOrWhiteSpace(txtbdApellidos.Text) ||
            string.IsNullOrWhiteSpace(txtbxCorreo.Text) ||
             string.IsNullOrWhiteSpace(txtbxDireccion.Text) ||
              nupdownEdad.Value == 0 || monthCalendar1.SelectionRange.Start == DateTime.MinValue)
            {
                return true;
            }
            else return false;

        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

        }

        private void tabVisualizacion_Click(object sender, EventArgs e)
        {

        }

        private void btn_Imagenes_Click(object sender, EventArgs e)
        {




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCronometro.Text = DateTime.Now.ToString();
        }
    }
}

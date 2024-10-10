using System.Collections;
using System.Windows.Forms;

namespace GestorInfPers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            String nombre = txtbxNombre.Text;
            String apellidos = txtbdApellidos.Text;
            String email = txtbxCorreo.Text;
            String edad = nupdownEdad.Text;
            DateTime fecha_nac = monthCalendar1.SelectionStart;
            String genero;
            if (rbtnMasculino.Checked)
            {
                genero = "masculino";
            }
            else if (rbtnOtro.Checked)
            {
                genero = "otro";
            }
            else if (rbtnFemenino.Checked)
            {
                genero = "femenino";
            }
            Boolean suscrito = chkbxBoletin.Checked;
            String paises = cmbxPaises.Text;
            ArrayList hobbies = new ArrayList();
            //Recorrer y añadir los validos


        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

        }

        private void tabVisualizacion_Click(object sender, EventArgs e)
        {

        }
    }
}

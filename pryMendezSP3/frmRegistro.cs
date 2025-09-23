namespace pryMendezSP3
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        //definicion de variables
        // static para que no se modifiquen las variables
        // new es instanciar en la memoria
        public static string[] vecRepuesto = new string[100];
        float Precio = 0;
        string Marca;
        string Origen;
        int Numero;
        string Descripcion;
        int indice = 0;

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex != -1)
            {
                cmbOrigen.Enabled = true;
            }
            else
            {
                cmbOrigen.Enabled = false;
            }
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedIndex != -1)
            {
                mtbNumero.Enabled = true;
            }
            else
            {
                mtbNumero.Enabled = false;
            }
        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbNumero.Text != "")
            {
                txtDescripcion.Enabled = true;
            }
            else
            {
                txtDescripcion.Enabled = false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            vecRepuesto[indice] = "untexto";
            indice++;
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            cmbMarca.Items.Add("(P) Peugeot");
            cmbMarca.Items.Add("(F) Fiat");
            cmbMarca.Items.Add("(R) Renault");
            cmbOrigen.Items.Add("(N) Nacional");
            cmbOrigen.Items.Add("(I) Importado");
            cmbMarcaConsultar.Items.Add("(P) Peugeot");
            cmbMarcaConsultar.Items.Add("(f) Fiat");
            cmbMarcaConsultar.Items.Add("(R) Renault");
        }
    }
}

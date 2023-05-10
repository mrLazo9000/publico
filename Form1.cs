using System.Text.RegularExpressions;

namespace TesteIONIC
{
    public partial class frmTesteIONIC : Form
    {
        public frmTesteIONIC()
        {
            InitializeComponent();
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            txtTextoCriptografado.Text = Polybius.RetornarCriptografia(txtPalavraChave.Text + txtTextoSimples.Text);
        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            txtTextoDescriptografado.Text = Polybius.RetornarDescriptografia(txtTextoCriptografado.Text);
        }

   }
}
using System;
using System.Windows.Forms;

namespace GeradorDeSenha
{
    public partial class formMain : Form
    {
        private PasswordGenerator passwordGenerator;

        public formMain()
        {
            InitializeComponent();
            passwordGenerator = new PasswordGenerator();
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            if (textBoxLength.Text.Length == 0)
            {
                StatusLabel.Text = "Coloque o tamanho da senha, imbecil x.x";
                return;
            }
            else
            {
                int length = Convert.ToInt32(textBoxLength.Text);
                //int length = (int)textBoxLength.Text;
                int upper = Convert.ToInt32(checkBoxUpper.Checked);
                int lower = Convert.ToInt32(checkBoxLower.Checked);
                int numeric = Convert.ToInt32(checkBoxNumeric.Checked);
                int special = Convert.ToInt32(checkBoxSpecial.Checked);

                try
                {
                    string password = passwordGenerator.GeneratePassword(length, upper, lower, numeric, special);
                    textBoxPassword.Text = password;
                    StatusLabel.Text = "Senha gerada! x3~";
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPassword.Text))
            {
                Clipboard.SetText(textBoxPassword.Text);
                textBoxPassword.Focus();
                StatusLabel.Text = "Senha Copiada! :3";
            }
            else
            {
                StatusLabel.Text = "Sem senha gerada para copiar :(";
            }
        }

        private void TextBoxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cheque se a tecla pressionada é um digito ou uma tecla de controle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suprima o pressionamento de tecla
                StatusLabel.Text = "É só número, burrinhe x.x";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            StatusLabel.Text = "Pronto";
        }
    }
}
using System.Text;
using System.Windows.Forms;

namespace AESconverter
{
    public partial class AESconverter : Form
    {
        public AESconverter()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            byte[] key = AESConverter.Padding(System.Text.Encoding.UTF8.GetBytes(keyField.Text), 32);
            byte[] IV = AESConverter.Padding(System.Text.Encoding.UTF8.GetBytes(IVField.Text), 16);

            byte[] encryptedSource = AESConverter.EncryptStringToBytes_Aes(sourceField.Text, key, IV);
            convertedSourceField.Text = System.Convert.ToBase64String(encryptedSource);
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            byte[] key = AESConverter.Padding(System.Text.Encoding.UTF8.GetBytes(keyField.Text), 32);
            byte[] IV = AESConverter.Padding(System.Text.Encoding.UTF8.GetBytes(IVField.Text), 16);

            string DecryptedSource = AESConverter.DecryptStringFromBytes_Aes(System.Convert.FromBase64String(sourceField.Text), key, IV);
            convertedSourceField.Text = DecryptedSource;
        }

        private void getIVButton_Click(object sender, EventArgs e)
        {
            IVField.Text = AESConverter.GetIV();
        }
    }
}

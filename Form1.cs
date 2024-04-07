using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AESconverter
{
    public partial class AESconverter : Form
    {
        public AESconverter()
        {
            InitializeComponent();

            createFilePage.DragDrop += new DragEventHandler(c_DragAndDrop);
            createFilePage.DragEnter += new DragEventHandler(c_DragAndEnter);

            viewFilePage.DragDrop += new DragEventHandler(v_DragAndDrop);
            viewFilePage.DragEnter += new DragEventHandler(v_DragAndEnter);

            MessageBox.Show("°³¹ßÁß");
        }

        private void c_DragAndDrop(object? sender, DragEventArgs e)
        {
            if (e.Data is not null)
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[]? files = (string[]?)e.Data.GetData(DataFormats.FileDrop);

                    if (files is not null)
                    {
                        c_codeField.Text = Obfuscator.Obfuscate(files[0]);
                        Obfuscator.currentPath = files[0];
                    }
                }
            }
        }

        private void c_DragAndEnter(object? sender, DragEventArgs e)
        {
            if (e.Data is not null)
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void v_DragAndDrop(object? sender, DragEventArgs e)
        {
            if (e.Data is not null)
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[]? files = (string[]?)e.Data.GetData(DataFormats.FileDrop);

                    if (files is not null)
                    {
                        v_codeField.Text = Obfuscator.Obfuscate(files[0]);
                    }
                }
            }
        }

        private void v_DragAndEnter(object? sender, DragEventArgs e)
        {
            if (e.Data is not null)
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
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

        private void c_addFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    c_codeField.Text = Obfuscator.Obfuscate(openFileDialog.FileName);
                    Obfuscator.currentPath = openFileDialog.FileName;
                }
            }
        }

        private void c_saveFileButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    Obfuscator.GetByteCode(folderBrowserDialog.SelectedPath);
                }
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    v_codeField.Text = Obfuscator.Obfuscate(openFileDialog.FileName);
                }
            }
        }

        private void v_saveFileButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fileStream = File.Create(folderBrowserDialog.SelectedPath + "\\ITSME"))
                    {
                        fileStream.Write(System.Text.Encoding.UTF8.GetBytes(v_codeField.Text), 0, v_codeField.TextLength);
                    }
                }
            }
        }
    }
}

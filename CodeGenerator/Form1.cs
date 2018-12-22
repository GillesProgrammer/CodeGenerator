using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            String code = tbCode.Text.ToString();
            String grain = tbGrain.Text.ToString();

            if (code != null && grain != null)
            {
                tbResult.Text = EncodePassword(code, grain);
            }
        }

        private string EncodePassword(string password, string salt)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] src = Encoding.Unicode.GetBytes(salt);
            byte[] dst = new byte[src.Length + bytes.Length];
            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inarray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inarray);
        }
    }
}

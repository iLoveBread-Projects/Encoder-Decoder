using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncoderDecoder
{
    public partial class frmDEcode : Form
    {
        public frmDEcode()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        public static string EncodeServerName(string serverName)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(serverName));
        }
        public static string DecodeServerName(string encodedServername)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(encodedServername));
        }
        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                string encode = EncodeServerName(txtText.Text);

                txtResult.Text = encode;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not encode the message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                string decode = DecodeServerName(txtText.Text);

                txtResult.Text = decode;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not decode the message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text != "")
                {
                    Clipboard.SetText(txtResult.Text);
                    MessageBox.Show("Successfully copied the result to your clipboard", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please encode or decode something first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not copy the result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
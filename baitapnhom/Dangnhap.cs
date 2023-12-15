using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace baitapnhom
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập thành công!");
            Form f = new Trangchu();
            f.Show();
        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar == '\0')
            {
                checkMatkhau.BringToFront();
                txtMatkhau.PasswordChar = '*';
            }
        }

        private void checkMatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar == '\0')
            {
                checkMatkhau.BringToFront();
                txtMatkhau.PasswordChar = '*';
            }
            else
            {
                checkMatkhau.BringToFront();
                txtMatkhau.PasswordChar = '\0';
            }
        }
    }
}

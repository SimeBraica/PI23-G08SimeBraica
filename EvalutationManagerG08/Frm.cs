using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvalutationManagerG08 {
    public partial class frm_Login : Form {
        public frm_Login() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void text_Username_TextChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Btn_login_Click(object sender, EventArgs e) {
            if(txt_Username.Text == "") {
                MessageBox.Show("Korisničko ime nije uneseno", "Problem", MessageBoxButtons.OK, MessageBoxButtons.Error);
            }
        }
    }
}

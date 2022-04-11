using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SsitemaHotel {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e) {
            //centralizar painel de login
            pnlLogin.Location = new Point(this.Width / 2 - 167 , this.Height / 2 - 153);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(21,164, 160);
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e) {

        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            if (txtUsuario.Text == "" ) {
                MessageBox.Show("Preencha o Usuário");
                txtUsuario.Focus();
                return;
            }
            if (txtSenha.Text == "") {
                MessageBox.Show("Preencha o Senha");
                txtSenha.Focus();
                return;
            }

             
        }
    }
}

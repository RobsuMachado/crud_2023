using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud_2023.BLL;
using Crud_2023.DTO;

namespace CRUD_2023
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // CRIAR UM OBJETO DE TRANSPORTE LOGIN
            LoginDTO loginDTO = new LoginDTO
            {
                User = txtUser.Text,
                Secret = txtSecret.Text,
            };

            // CHAMAR O MÉTODO DA BLL, PARA ISSO É NECESSÁRIO CRIAR UM OBJETO QUE POSSUA GetLoginBLL
            LoginBLL loginBLL = new LoginBLL();
            bool retorno = loginBLL.GetLoginBLL(loginDTO);
            if (retorno)
            {
                MessageBox.Show("Login Ok!");
            }
            else
            {
                MessageBox.Show("Deu ruim!");
            }
        }

        private void txtSecret_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

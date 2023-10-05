using Crud_2023.DAL;
using Crud_2023.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_2023.BLL
{
    internal class LoginBLL
    {
        public bool GetLoginBLL(LoginDTO loginDTO)
        {
            LoginDAL loginDAL = new LoginDAL();
            bool retorno = loginDAL.GetLoginDAL(loginDTO);

            if (retorno)
            {
                return true;
            }
            return false;
        }
    }
}

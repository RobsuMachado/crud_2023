using Crud_2023.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_2023.DAL
{
    internal class LoginDAL
    {
        public bool GetLoginDAL(LoginDTO loginDTO)
        {
            if (loginDTO.User == "Robson" && loginDTO.Secret == "12345")
            {
                return true;
            }
            return false;
        }
    }
}

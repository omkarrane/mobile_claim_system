using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDAL;
using UBO;

namespace UBLL
{
    public class LoginBLL
    {
        public bool ValidateUser(LoginBO userbo)
        {
            LoginDAL userdal = new LoginDAL();
            return userdal.ValidateUser(userbo);
        }
    }
}

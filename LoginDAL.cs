using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBO;

namespace UDAL
{
    public class LoginDAL
    {
        public bool ValidateUser(LoginBO userbo)
        {
            LOGINTEAM3 objUser = new LOGINTEAM3();

            try
            {
                using (var dbContext = new LoginContext())
                {
                    objUser = dbContext.LOGINTEAM3.FirstOrDefault<LOGINTEAM3>(u => u.USERID == userbo.USERID && u.PASSWORD == userbo.PASSWORD);
                }

                if (objUser != null)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}

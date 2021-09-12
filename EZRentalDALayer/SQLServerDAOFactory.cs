using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZRentalDALayer
{
    public class SQLServerDAOFactory : DALObjectFactoryBase
    {
        //Public Static Method
        public static string ConnectionString()
        {
            return "Data Source=.\\SQLEXPRESS;Initial Catalog= EZRentalDB;Integrated Security=True";
        }

        #region "OVERRIDE METHODS FROM PARENT CLASS DALObjectFactoryBase"
        public override CreditCardDAO GetCreditCardDAO()
        {
            return new CreditCardDAO();
        }

        public override USStateDAO GetUSStateDAO()
        {
            return new USStateDAO();
        }

        public override CountryDAO GetCountryDAO()
        {
            return new CountryDAO();
        }
        #endregion
    }
}

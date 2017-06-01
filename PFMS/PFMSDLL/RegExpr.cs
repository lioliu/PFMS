using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace PFMSDLL
{
    public class RegExpr
    {
        static Regex regPhone = new Regex(@"^1[34578]\d{9}$");
        static Regex regEmail = new Regex(@"[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?");

        public static bool CheckPhone(string phoneNumber)
        {
            return regPhone.IsMatch(phoneNumber);
        }

        public static bool CheckEmail(string adress)
        {
            return regEmail.IsMatch(adress);
        }

    }
}

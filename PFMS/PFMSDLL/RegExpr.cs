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
        //static Regex Password = new Regex(@"^(?:([a-z])|([A-Z])|([0-9])|(.)){6,}|(.)+$");
        public static bool CheckPhone(string phoneNumber)
        {
            return regPhone.IsMatch(phoneNumber);
        }

        public static bool CheckEmail(string adress)
        {
            return regEmail.IsMatch(adress);
        }

        public static int CheckPassWord(string password)
        {
            string result = Regex.Replace(password, "^(?:([a-z])|([A-Z])|([0-9])|(.)){6,}|(.)+$", "$1$2$3$4$5");

            return result.Length;
        }

    }
}

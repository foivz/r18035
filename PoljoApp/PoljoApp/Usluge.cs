using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System
    .Security.Cryptography;

namespace PoljoAppVerzija2
{
    public static class Usluge
    {
        public static MatchCollection ProvjeriRegex(string tekst, string uzorak)
        {
            MatchCollection pogotci;

            Regex regex = new Regex(uzorak);
            pogotci = regex.Matches(tekst);

            return pogotci;
        }

        public static string NapraviHash(string tekst)
        {
            using(MD5 md5Hash = MD5.Create()) { 
                // Pretvara string u niz bajtova i izračunava hash
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(tekst));

                // Stringbuilder za pretvaranje bajtova u string
                StringBuilder sBuilder = new StringBuilder();

                // Formatira svaki bajt u hex string
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
        
        public static bool ProvjeriHash(string tekst, string hash)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                string hashTeksta = NapraviHash(tekst);

                StringComparer comparer = StringComparer.OrdinalIgnoreCase;

                if (0 == comparer.Compare(hashTeksta, hash))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}

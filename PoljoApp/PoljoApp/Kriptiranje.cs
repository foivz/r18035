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
    /// <summary>
    /// Zadužena je za kriptiranje teksta tipa string
    /// </summary>
    public static class Kriptiranje
    {
        /// <summary>
        /// Kriptira ulazni string
        /// </summary>
        /// <param name="tekst"></param>
        /// <returns>Kriptirani string</returns>
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
    }
}

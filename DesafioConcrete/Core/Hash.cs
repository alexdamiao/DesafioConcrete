using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace DesafioConcrete.Core
{
    /// <summary>
    /// Classe utilizada para calcular o hash, padrão SHA256
    /// </summary>
    public class Hash
    {
        /// <summary>
        /// Método de encriptação de string
        /// </summary>
        /// <param name="frase">string que será calculada o hash</param>
        /// <returns>retorno do hash em string</returns>
        public static string sha256encrypt(string frase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }

        /// <summary>
        /// Conversão de array para string
        /// </summary>
        /// <param name="inputArray">array de bytes para serem convertidos</param>
        /// <returns>retorno do hash em string</returns>
        private static string byteArrayToString(byte[] inputArray)
        {
            StringBuilder output = new StringBuilder("");
            for (int i = 0; i < inputArray.Length; i++)
            {
                output.Append(inputArray[i].ToString("X2"));
            }
            return output.ToString();
        }
    }
}
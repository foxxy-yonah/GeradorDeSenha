using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GeradorDeSenha
{
    public class PasswordGenerator
    {
        private readonly string uCharSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string lCharSet = "abcdefghijklmnopqrstuvwxyz";
        private readonly string nCharSet = "0123456789";
        private readonly string sCharSet = "/*-+,!?=()@;:._";

        public string GeneratePassword(int length, int upper = 1, int lower = 1, int numeric = 1, int special = 1)
        {
            if (upper + lower + numeric + special > length)
            {
                throw new ArgumentException("O número de caracteres maiúsculos/minúsculos/numéricos/especiais deve ser menor ou igual ao comprimento");
            }

            string charSet = "";
            if (upper > 0) { charSet += uCharSet; }
            if (lower > 0) { charSet += lCharSet; }
            if (numeric > 0) { charSet += nCharSet; }
            if (special > 0) { charSet += sCharSet; }

            char[] charArray = charSet.ToCharArray();
            byte[] bytes = new byte[length];
#pragma warning disable SYSLIB0023 // O tipo ou membro é obsoleto, mas usaremos mesmo assim
            using (RNGCryptoServiceProvider rng = new())
            {
                rng.GetBytes(bytes);
            }
#pragma warning restore SYSLIB0023 // O tipo ou membro é obsoleto, mas usaremos mesmo assim

            char[] result = new char[length];
            if (charArray.Length == 0)
            {
                throw new ArgumentException("Ao menos uma categoria de caracteres (maiúsculos, minúsculos, numéricos ou especiais) precisa ser selecionada.");
            }

            for (int i = 0; i < length; i++)
            {
                result[i] = charArray[bytes[i] % charArray.Length];
            }

            string password = new(result);        
            bool valid = true;

            //if ($upper - gt($password.ToCharArray() | Where - Object {$_ - cin $uCharSet.ToCharArray() }).Count) { $valid = $false }
            if (upper > password.Count(c => uCharSet.Contains(c))) { valid = false; }
            if (lower > password.Count(c => lCharSet.Contains(c))) { valid = false; }
            if (numeric > password.Count(c => nCharSet.Contains(c))) { valid = false; }
            if (special > password.Count(c => sCharSet.Contains(c))) { valid = false; }

            if (!valid)
            {
                password = GeneratePassword(length, upper, lower, numeric, special);
            }

            return password;
        }
    }
}

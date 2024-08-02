using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_test.Email
{
   public class Email
    {
        //valida o endereço de email
        public bool ValidarEmail(string email)
        {
            //verifica se o e-mail é nulo ou vazio
            if (string.IsNullOrEmpty(email))
                return false;

            //encontra as posições no e-mail
            int atPos = email.IndexOf('@');
            int dotPos = email.LastIndexOf('.');

            // Verifica se "@" está presente e não é o primeiro ou último caractere,
            // e se "." está presente depois de "@" e não é o último caractere.
            return atPos > 0 && dotPos > atPos + 1 && dotPos < email.Length - 1;
        }
    }
}

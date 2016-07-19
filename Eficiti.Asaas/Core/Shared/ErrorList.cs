using System.Collections.Generic;
using System.Linq;

namespace Eficiti.Asaas.Core
{
    public class ErrorList
    {
        public List<Error> Errors { get; set; }

        public override string ToString()
        {
            if (Errors == null)
                return "O servidor remoto retornou um erro: (400) Solicitação Incorreta.";

            var str = string.Empty;
            
            var strErrors = Errors.Select(c => c.ToString()).ToList();

            for (int i = 0; i < strErrors.Count; i++)
            {
                str += strErrors[i];
                if (i != strErrors.Count - 1)
                    str += "\n";
            }

            return str;
        }
    }
}

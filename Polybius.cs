using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIONIC
{
    internal class Polybius
    {
        public static String RetornarCriptografia(string texto)
        {
            int linha = 0;
            int coluna = 0;
            string retorno = string.Empty;

            for (int i = 0; i < texto.Length; i++)
            {
                linha = (int)Math.Floor((texto[i] - 'a') / 5.0) + 1;

                coluna = ((texto[i] - 'a') % 5) + 1;

                if (texto[i] == 'k')
                {
                    linha = linha - 1;
                    coluna = 5 - coluna + 1;
                }

                else if (texto[i] >= 'j')
                {
                    if (coluna == 1)
                    {
                        coluna = 6;
                        linha = linha - 1;
                    }
                    coluna = coluna - 1;
                }

                retorno += linha.ToString() + coluna.ToString();
            }

            return retorno;
        }

        public static String RetornarDescriptografia(string texto)
        {
            string retorno = string.Empty;
            return retorno;
        }
    }
}

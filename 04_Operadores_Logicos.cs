using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_
{
    public static class Operadores_Logicos
    {
       // Método que demonstra o operador E lógico (&&)
        public static bool Elogico(bool a, bool b)
            {
            return a && b; 
            }

        // Método que demonstra o operador OU lógico (||)
        public static bool OULogico(bool a, bool b)
        {
            return a || b;
        }

        // Método que demonstra o operador NEGAÇÂO (!)
        public static bool Negacao(bool a)
        {
            return !a;
        }

        // Método que demonstra o operador OU exclusivo (^)

        public static bool OUExclusivo(bool a, bool b)
        {
            return a ^ b; 
        }

    }
}

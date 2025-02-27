using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace practica3
{
    public class ClassEntrada
    {
        public class InputValidator
        {
            //  validar si una cadena contiene solo números
            public bool EsSoloNumeros(string texto)
            {
                return Regex.IsMatch(texto, @"^\d+$");
            }

            //  validar si una cadena contiene solo letras
            public bool EsSoloLetras(string texto)
            {
                return Regex.IsMatch(texto, @"^[A-Za-z]+$");
            }
        }

        public bool ValidarEntrada(string entrada)
        {
            // validaciom
            if (string.IsNullOrEmpty(entrada))
            {
                return false; // entrada no válida
            }
           
            return true; // entrada válida
        }
    }


}

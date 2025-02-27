using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace practica3
{
    internal class ClassEntrada
    {
        public class InputValidator
        {
            // Método para validar si una cadena contiene solo números
            public bool EsSoloNumeros(string texto)
            {
                return Regex.IsMatch(texto, @"^\d+$");
            }

            // Método para validar si una cadena contiene solo letras
            public bool EsSoloLetras(string texto)
            {
                return Regex.IsMatch(texto, @"^[A-Za-z]+$");
            }
        }
    }

}

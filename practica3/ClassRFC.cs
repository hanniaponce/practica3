using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace practica3
{
    internal class ClassRFC
    {
        public class RFCValidator
        {
            // Método para validar si el RFC tiene el formato correcto
            public bool EsRFCValido(string rfc)
            {
                // Expresión regular para validar el formato de RFC
                string patronRFC = @"^[A-Z]{4}\d{6}[A-Z0-9]{3}$";
                return Regex.IsMatch(rfc.ToUpper(), patronRFC);
            }

            // Método para corregir errores comunes en la captura de RFCs
            public string CorregirRFC(string rfc)
            {
                // Convierte el RFC a mayúsculas y elimina espacios en blanco
                return rfc.Trim().ToUpper();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace practica3
{
    public class ClassRFC
    {
        
    //  validar si el RFC tiene el formato correcto
    public bool EsRFCValido(string rfc)
        {
            // expresión  para validar el formato de RFC
            string patronRFC = @"^[A-Z]{4}\d{6}[A-Z0-9]{3}$";
            return Regex.IsMatch(rfc, patronRFC);
        }

        // corregir errores comunes en la captura de RFC
        public string CorregirRFC(string rfc)
        {
            // convierte el RFC a mayúsculas y elimina espacios en blanco
            return rfc.Trim().ToUpper();
        }

        
        public bool ValidarRFC(string rfc)
        {
            try
            {
                // corrige errores en la captura del RFC
                string rfcCorregido = CorregirRFC(rfc);

                // valida si el RFC tiene el formato correcto
                return EsRFCValido(rfcCorregido);
            }
            catch (Exception)
            {
                // si ocurre un error se considera que el RFC no es válido
                return false;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Validaciones
{
    public class Validaciones
    {
        private ValidationContext context;
        private List<ValidationResult> results;
        private bool valido;
        private string mensaje;


        public Validaciones(object instance)
        {
            context = new ValidationContext(instance);
            results = new List<ValidationResult>();
            valido = Validator.TryValidateObject(instance, context, results, true);



        }

        public bool validado()
        {
            if (valido == false)
            {
                foreach (ValidationResult item in results)
                {
                    mensaje += item.ErrorMessage + "\n";
                }
                System.Windows.Forms.MessageBox.Show(mensaje);
            }
            return valido;
        }
    }
}

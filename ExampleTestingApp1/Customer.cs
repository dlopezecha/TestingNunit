using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTestingApp1
{
    class Customer
    {
        // Atributos del customer
        private string _nombre;
        private int _edad;

        //Métodos habilitados para interactuar con la variable Nombre
        public string nombre
        {
            //Obtener el valor dentro de la variable
            get
            {
                return _nombre;
            }
            // Guardar datos en la varible
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nombre = value;
                }
            }
        }

        //Métodos habilitados para interactuar con la variable Edad
        public int edad
        {
            //Obtener el valor dentro de la variable
            get
            {
                return _edad;
            }
            // Guardar datos en la varible
            set
            {
                if (value > 0)
                {
                    _edad = value;
                }
            }
        }
    }
}

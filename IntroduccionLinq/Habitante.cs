using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    //Se deine la clase "Habitante"
    public class Habitante
    {
        public int IdHabitante {get;set;}
        public string Nombre {get; set;}
        public int Edad {get; set;}
        public int IdCasa { get; set;}

        //Método que devuelve una cadena con los datos del habitante
        public string datosHabitante() {

            //Retorna una cadena con el nombre, la edad y la referencia a la casa(IdCasa)
            return $"Soy {Nombre} con edad de {Edad} años vividos en {IdCasa}";
        }
    }
}

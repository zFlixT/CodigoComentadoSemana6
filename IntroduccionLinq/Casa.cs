using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    //Se define la clase "Casa"
    public class Casa
    {
        public int Id {  get; set; }
        public string Direccion { get; set;}
        public string Ciudad { get; set;}
        public int numeroHabitaciones {  get; set;}

        //Método que devuelve una cadena de texto con los datos de la casa
        public string dameDatosCasa () {

            //Usamos la interpolación de cadenas para devolver la dirección, ciudad y número de habitaciones
            return $"Direcion es {Direccion} en la ciudad de {Ciudad} con numero de habitaciones {numeroHabitaciones}"; 
        }

    }
}

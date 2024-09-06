﻿
using IntroduccionLinq;

#region Introduccion 
//Filtra y muestra palabras con más de 5 letras
/*string[]palabras;
palabras = new string[] { "gato", "perro", "lagarto", "tortuga", "cocdrilo","serpiente", "123456789" };
Console.WriteLine("Mas de 5 letras");

List<string> resultado = new List<string>();

foreach (string str in palabras) {
    if (str.Length >5) {
        resultado.Add(str);
    }
}

foreach (var r in resultado) 
    Console.WriteLine(r);
*/
#endregion

#region Utilizando Linq
//Filtra y muestra palabras con más de 8 letras utilizando LINQ
/*Console.WriteLine("-----------------------------------------------------");    
IEnumerable<string> list = from r in palabras where r.Length > 8 select r;
foreach(var listado in list)
    Console.WriteLine(listado);
Console.WriteLine("-----------------------------------------------------");
*/
#endregion

#region ListaModelos
//Se crean listas para almacenar Casa y Habitante
List<Casa> ListaCasas = new List<Casa>();
List<Habitante> ListaHabitantes = new List<Habitante>();
#endregion

#region ListaCasa
//Se agregan objetos de tipo Casa a la lista ListaCasas con diferentes direcciones, ciudades y número de habitaciones
ListaCasas.Add(new Casa { 
    Id=1,
    Direccion= "3 av Norte ArcanCity",
    Ciudad= "Gothan City",
    numeroHabitaciones= 20,
});
ListaCasas.Add(new Casa
{
    Id = 2,
    Direccion = "6 av Sur SmollVille",
    Ciudad = "Metropolis",
    numeroHabitaciones = 5,
});
ListaCasas.Add(new Casa{ 
    Id = 3,
    Direccion= "Forest Hills, Queens, NY 11375",
    Ciudad = "New York"
});
#endregion

#region ListaHabitante
//Se agregan objetos de tipo Habitante a la lista ListaHabitantes, vinculando habitantes con sus casas mediante IdCasa
ListaHabitantes.Add(new Habitante { 
    IdHabitante= 1,
    Nombre = "Bruno Diaz",
    Edad= 36,
    IdCasa= 1
});
ListaHabitantes.Add(new Habitante {
    IdHabitante = 2,
    Nombre = "Clark Kent.",
    Edad = 40,
    IdCasa = 2
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Peter Parker",
    Edad = 25,
    IdCasa = 3
});
ListaHabitantes.Add(new Habitante {
    IdHabitante = 3,
    Nombre = "Tia Mey",
    Edad = 85,
    IdCasa = 3
});
ListaHabitantes.Add(new Habitante{
    IdHabitante = 2,
    Nombre = "Luise Lain",
    Edad = 40,
    IdCasa = 2
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Selina Kyle",
    Edad = 30,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Alfred",
    Edad = 65,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Nathan Drake",
    Edad = 37,
    IdCasa = 1
});
#endregion

#region SentenciasLinQ
//Se utilizan sentencias LINQ para filtrar y unir datos entre habitantes y casas
/*
IEnumerable<Habitante> ListaEdad = from ObjetoProvicional
                                   in ListaHabitantes
                                   where ObjetoProvicional.Edad > 40
                                   select ObjetoProvicional;

foreach (Habitante objetoProcicional2 in ListaEdad)
{
    Console.WriteLine(objetoProcicional2.datosHabitante());
}

//Join
IEnumerable<Habitante> listaCasaGothan = from objetoTemporalHabitante in ListaHabitantes
                                         join objetoTemporalCasa in ListaCasas
                                         on objetoTemporalHabitante.IdHabitante equals objetoTemporalCasa.Id
                                         where objetoTemporalCasa.Ciudad   == "Gothan City"
                                         select objetoTemporalHabitante;
Console.WriteLine("----------------------------------------------------------------------------------------------");
foreach (Habitante h in listaCasaGothan) {
    Console.WriteLine (h.datosHabitante());
}
*/
#endregion

#region FirsthAndFirsthOrDefault
//Demostración del uso de las funciones `First` y `FirstOrDefault` para obtener elementos de una lista
/* Console.WriteLine("----------------------------------------------------------------------------------------------");
var primeraCasa = ListaCasas.First(); //esto no es linQ es  una fucnin de los Ienumarable
Console.WriteLine(primeraCasa.dameDatosCasa());

//aplicando una restriccion sin restricion lambda
Habitante personaEdad = (from variableTemporalHabitante in ListaHabitantes where variableTemporalHabitante.Edad > 25 select variableTemporalHabitante).First();
Console.WriteLine(personaEdad.datosHabitante());
Console.WriteLine("---------------------------Lo mismo pero con lambdas---------------------------------------------------------");
var Habitante1 = ListaHabitantes.First(objectTemp => objectTemp.Edad >25);
Console.WriteLine(Habitante1.datosHabitante());

// Si no tenemos el elemento que buscamos entoences la sonsulta devolvera una exepcion esto detendra el codigo en su totalidad

//Casa EdadError = (from vCasaTemp in ListaCasas where vCasaTemp.Id >10 select vCasaTemp).First() ;
//Console.WriteLine(EdadError.dameDatosCasa());

Casa CasaConFirsthOrDedault = ListaCasas.FirstOrDefault(vCasa => vCasa.Id > 200);
if (CasaConFirsthOrDedault == null ) {
    Console.WriteLine("No existe !No hay!");
    return;
}
Console.WriteLine("existe !Si existe!");
*/
#endregion

#region Last
//Demostración del uso de las funciones `Last` y `LastOrDefault` para obtener el último elemento de una lista
/*Casa ultimaCasa = ListaCasas.Last(temp => temp.Id>1);
Console.WriteLine(ultimaCasa.dameDatosCasa());
Console.WriteLine("_____________________________________________________");
var h1 = (from objHabitante in ListaHabitantes where objHabitante.Edad > 60 select objHabitante)
    .LastOrDefault();
if (h1 == null) {
    Console.WriteLine("Algo fallo");
return;
}
Console.WriteLine(h1.datosHabitante());
*/
#endregion

#region ElementAt
//Demostración del uso de las funciones `ElementAt` y `ElementAtOrDefault` para obtener elementos en posiciones específicas de una lista
/*var terceraCasa = ListaCasas.ElementAt(2);
Console.WriteLine($"La tercera casa es {terceraCasa.dameDatosCasa()}");

var casaError = ListaCasas.ElementAtOrDefault(3);
if ( casaError != null) { Console.WriteLine($"La tercera casa es {casaError.dameDatosCasa()}"); }

var segundoHabitante = (from objetoTem in ListaHabitantes select objetoTem).ElementAtOrDefault(2);
Console.WriteLine($" segundo habitante es : {segundoHabitante.datosHabitante()}");
*/
#endregion

#region Single
//Demostración del uso de `Single` y `SingleOrDefault` para seleccionar un único elemento de una lista
/*
try {
    var habitantes = ListaHabitantes.Single(variableTem => variableTem.Edad > 40 && variableTem.Edad <70);
    // Creando esta consulta pero con LinQ
    var habitante2 = (from obtem in ListaHabitantes where obtem.Edad >70 select obtem).SingleOrDefault() ;

    Console.WriteLine($"habitante con menos de 20 años {habitantes.datosHabitante()}");
    if ( habitante2 != null ) Console.WriteLine($"habitante con mas de 70 años {habitante2.datosHabitante()}");
}
catch (Exception) {
    Console.WriteLine($"Ocurrio el error");
}
*/
#endregion

#region TypeOf
//Demostración del uso de `OfType` para filtrar elementos de una lista según su tipo
/* var listaEmpleados = new List<Empleado>() { 
    new Medico(){ nombre= "Jorge Casa" },
    new Enfermero(){ nombre = "Raul Blanco"}
};

var medico = listaEmpleados.OfType<Medico>();
Console.WriteLine(medico.Single().nombre);
*/
#endregion

#region OrderBy
//Demostración del uso de `OrderBy` para ordenar los elementos de una lista.
/*var edadA = ListaHabitantes.OrderBy(x => x.Edad);
var edadAC = from vt in ListaHabitantes orderby vt.Edad select vt;
foreach (var edad in edadAC) { 
    Console.WriteLine(edad.datosHabitante());
}
*/
#endregion

#region OrderBYDescending()
//Demostración del uso de `OrderByDescending` para ordenar los elementos de una lista de manera descendente
/* var listaEdad = ListaHabitantes.OrderByDescending(x => x.Edad);
foreach (Habitante h in listaEdad) { 
    Console.WriteLine(h.datosHabitante());
}
Console.WriteLine("-------------------------------------------");
var ListaEdad2 = from h in ListaHabitantes orderby h.Edad descending select h;
foreach (Habitante h in ListaEdad2)
{
    Console.WriteLine(h.datosHabitante());
}
*/
#endregion

#region ThenBy
//Demostración del uso de `OrderBy` seguido de `ThenBy` y `ThenByDescending` para ordenar los elementos de una lista por múltiples criterios

//var habitantes3 = ListaHabitantes.OrderBy(x => x.Edad).ThenBy(x => x.Nombre);

var edadATA = from h in ListaHabitantes orderby h.Edad, h.Nombre descending select h;

foreach (var h in edadATA)
{
    Console.WriteLine(h.datosHabitante());
}

Console.WriteLine("------------------");

//var habitantes4 = ListaHabitantes.OrderBy(x => x.Edad).ThenByDescending(x => x.Nombre);

var lista4 = from h in ListaHabitantes orderby h.Edad, h.Nombre ascending select h; 

foreach (var h in lista4)
{
    Console.WriteLine(h.datosHabitante());
}

#endregion

using System;
using System.Collections.Generic;
namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (AgendaContext bContexto = new AgendaContext())
                {

                    Persona bPersona = new Persona
                    {

                        PersonaID = 1,

                        Nombre = "Juan",

                        Apellido = "Pérez",

                        Telefonos = new List<Telefono> {
                            new Telefono
                            {
                                TelefonoID = 1,
                                Numero = "1234567890",
                                Tipo = "Fijo"
                            },
                            new Telefono
                            {
                                TelefonoID = 2,
                                Numero = "0987654321",
                                Tipo = "Mévil"
                            }
                        }
                    };
                    bContexto.Personas.Add(bPersona);
                    bContexto.SaveChanges();
                    foreach (Persona bItem in bContexto.Personas)
                    {

                        Console.WriteLine("Persona recuperada:\nId. {0}, Nombre: {1} - Apellido: {2}",
                        bItem.PersonaID,
                        bItem.Nombre,
                        bItem.Apellido);

                    }
                    Console.WriteLine("La aplicacién ha finalizado correctamente.");
                }
            }
            catch (Exception bEx)
            {
                Console.WriteLine("Ha ocurrido un error: {0}", bEx);
            }
            Console.ReadKey();
        }
    }
}

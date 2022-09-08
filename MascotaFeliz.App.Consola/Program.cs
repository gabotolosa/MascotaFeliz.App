using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddDueno();
            //AddVeterinario();
            //AddMascota();
            DeleteDueno();
        }
        
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Pepito",
                Apellidos = "Perez",
                Direccion = "alli en la esquina",
                Telefono = "7654321",
                Correo = "pepito123@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
        
        private static void DeleteDueno()
        {
            _repoDueno.DeleteDueno(3);
        }
        
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Miguel",
                Apellidos = "Mata Lozano",
                Direccion = "River Country",
                Telefono = "30001112233",
                TarjetaProfesional = "f1234567"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Hugo",
                Color = "Rojo",
                Especie = "Canino",
                Raza = "Lobo"
            };
            _repoMascota.AddMascota(mascota);
        }
        
    }
}

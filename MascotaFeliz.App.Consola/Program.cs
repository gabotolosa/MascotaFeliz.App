﻿using System;
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
        }
        
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
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
            Nombre = "Hugo",
            Color = "Rojo",
            Especie = "Canino",
            Raza = "Lobo"
        }
        
    }
}

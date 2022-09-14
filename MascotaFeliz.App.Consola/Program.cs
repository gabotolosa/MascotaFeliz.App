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
            //DeleteDueno();
            ActualizarDueno(4);
        }
        
        private static void AddDueno()//agregar dueño
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
        
        private static void DeleteDueno()//borra dueño con el id
        {
            _repoDueno.DeleteDueno(3);
        }
        
        private static void AddVeterinario()//agrega veterinario
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Angela",
                Apellidos = "Becerra",
                Direccion = "Andino",
                Telefono = "77712233",
                TarjetaProfesional = "f998877"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()//agrega mascota
        {
            var mascota = new Mascota
            {
                Nombre = "Mono",
                Color = "Amarillo",
                Especie = "Felino",
                Raza = "Angora"
            };
            _repoMascota.AddMascota(mascota);
        }
        
        private static void ActualizarDueno(int idDueno)
        {
            var dueno =new Dueno
            {
                Id = idDueno,
                Nombres="pepe",
                Apellidos="veloz",
                Direccion="alli no mas",
                Telefono="10000011",
                Correo="pepeper@gmail.com"
            };
            _repoDueno.UpdateDueno(dueno);
        }

        /*
        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = new DateTime(2020, 01, 01)

            };
            _repoHistoria.AddHistoria(historia);
        }*/
    }
}

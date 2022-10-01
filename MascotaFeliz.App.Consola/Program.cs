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
        private static IRepositorioHistoria _repoHistoria =new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddDueno();
            //BuscarDueno(4);
            //AddVeterinario();
            //AddMascota();
            //DeleteDueno();
            DeleteMascota();
            //ActualizarDueno(4);
            //AddHistoria();
            //AsignarDueno();
            //AsignarVeterinario();
            //ListarMascotas();
            //ListarMascotasNombreRazaColor();

            //AsignarHistoria();
            //AsignarVisitaPyP(1);

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

        private static void DeleteMascota()
        {
            _repoMascota.DeleteMascota(4);
            Console.WriteLine("mascota Borrada");
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

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Id + " " + dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }



        private static void AsignarVisitaPyP(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            if (historia != null)
            {
                if (historia.VisitasPyP != null)
                {
                    historia.VisitasPyP.Add(new VisitaPyP { FechaVisita = new DateTime(1000, 09, 21), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", IdVeterinario = 2, Recomendaciones = "Dieta extrema"});
                }
                else
                {
                    historia.VisitasPyP = new List<VisitaPyP>{
                        new VisitaPyP{FechaVisita = new DateTime(2000, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", IdVeterinario = 2, Recomendaciones = "Dieta extrema" }
                    };
                }
                _repoHistoria.UpdateHistoria(historia);
            }
        }

        private static void AsignarDueno()
        {
            var dueno = _repoMascota.AsignarDueno(8, 2);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos);
        }


        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = new DateTime(2020, 02, 04)
                
            };
            _repoHistoria.AddHistoria(historia);
            Console.WriteLine("historia creada");
        }

        private static void AsignarVeterinario()
        {
            var veterinario = _repoMascota.AsignarVeterinario(6, 5);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }

        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre + " " + m.Raza + " le pertenece a " + m.Dueno.Nombres + " " + m.Dueno.Apellidos+ " y lo atiende " + m.Veterinario.Nombres);
            }

        }

        private static void ListarMascotasNombreRazaColor()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre + " " + m.Raza + " Color: "+m.Color);
            }

        }

        private static void AsignarHistoria()
        {
            var historia = _repoMascota.AsignarHistoria(6,2);
            Console.WriteLine("historia asignada");
        }

        
        
    }
}

/*

{
    class Program
    {
       
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hola amigos vamos a empezar a trabajar con las tablas");

            //ListarDuenosFiltro();      
            //AddDueno();
            //BuscarDueno(1);
            
            //ListarDuenos();

            //ListarVeterinariosFiltro();
            //AddVeterinario();
            //BuscarVeterinario(1);
            //BuscarMascota(1);

            //AddMascota();
            //AsignarVeterinario();
            //AsignarDueno();
            //AsignarHistoria();

            //ListarMascotas();
            //ListarHistorias();
            //AsignarDueno();

            //AddHistoria();
            //AsignarVisitaPyP(2);
            ListarMascotas();

        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Cedula = "4545",
                Nombres = "Juanito",
                Apellidos = "Alimaña",
                Direccion = "Casa de los padres",
                Telefono = "515151515",
                Correo = "juanitoalimana@gmail.com"
            };
            dueno = _repoDueno.AddDueno(dueno);
          
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Cedula = "555555",
                Nombres = "La Chilindrina",
                Apellidos = "No se sabe",
                Direccion = "Transversal 5 # 17A-155",
                Telefono = "2222222222",
                TarjetaProfesional = "TP0001"
            };
            _repoVeterinario.AddVeterinario(veterinario);

        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Ragnar",
                Color = "Sable",
                Especie = "Canino",
                Raza = "Husky"
            };
            _repoMascota.AddMascota(mascota);

        }

        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = new DateTime(2020, 01, 01)

            };
            _repoHistoria.AddHistoria(historia);
        }

        private static void AsignarVisitaPyP(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            if (historia != null)
            {
                if (historia.VisitasPyP != null)
                {
                    historia.VisitasPyP.Add(new VisitaPyP { FechaVisita = new DateTime(1000, 09, 21), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", CedulaVeterinario = "123", Recomendaciones = "Dieta extrema"});
                }
                else
                {
                    historia.VisitasPyP = new List<VisitaPyP>{
                        new VisitaPyP{FechaVisita = new DateTime(2000, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", CedulaVeterinario = "123", Recomendaciones = "Dieta extrema" }
                    };
                }
                _repoHistoria.UpdateHistoria(historia);
            }
        }

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Cedula + " " + dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }

        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " " + mascota.Dueno.Nombres);        
        }

        private static void ListarDuenosFiltro()
        {
            var duenosM = _repoDueno.GetDuenosPorFiltro("Ped");
            foreach (Dueno p in duenosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }

        }

        private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }

        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre + " " + m.Raza + " le pertenece a " + m.Dueno.Nombres + " " + m.Dueno.Apellidos+ " y lo atiende " + m.Veterinario.Nombres);
            }

        }

        private static void ListarHistorias()
        {
            var historias = _repoHistoria.GetAllHistorias();
            foreach (Historia h in historias)
            {
                Console.WriteLine(h.Id + " Este es el id de la historia");
            }
        }

        private static void ListarVeterinariosFiltro()
        {
            var veterinariosM = _repoVeterinario.GetVeterinariosPorFiltro("e");
            foreach (Veterinario p in veterinariosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }

        }

        private static void AsignarVeterinario()
        {
            var veterinario = _repoMascota.AsignarVeterinario(1, 2);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }

        private static void AsignarDueno()
        {
            var dueno = _repoMascota.AsignarDueno(1, 4);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos);
        }

        private static void AsignarHistoria()
        {
            var historia = _repoMascota.AsignarHistoria(1,1);
        }


    }
}
*/
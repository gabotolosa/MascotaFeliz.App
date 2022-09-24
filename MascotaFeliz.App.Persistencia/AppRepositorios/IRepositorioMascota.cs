using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();//listar todos las 
        IEnumerable<Mascota> GetAllMascotas_();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);
        IEnumerable<Mascota> GetMascotasPorFiltro(string filtro); //buscar por filtro  
        //IEnumerable<Mascota> GetMascotasPorDueno(int idDueno); //buscar por iddueño
        
        Veterinario AsignarVeterinario(int idMascota, int idVeterinario);//asinar veterinario a mascota
        Dueno AsignarDueno(int idMascota, int idDueno);// asignar dueño a mascota
        Historia AsignarHistoria(int idMascota, int idHistoria);// asignar historia a mascota
    }
}
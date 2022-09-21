using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioDueno
    {
        IEnumerable<Dueno> GetAllDuenos();//listar todos los dueños
        Dueno AddDueno(Dueno dueno); //agregar dueño
        Dueno UpdateDueno(Dueno dueno); //actualizar dueño
        void DeleteDueno(int idDueno);//borrar dueño
        Dueno GetDueno(int idDueno); //buscar por id
        IEnumerable<Dueno> GetDuenosPorFiltro(string filtro); //buscar por filtro  
        
    }
}
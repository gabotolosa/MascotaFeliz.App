using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        IEnumerable<Historia> GetAllHistorias();//listar todos los historias
        Historia AddHistoria(Historia historia); //agregar historia
        Historia UpdateHistoria(Historia historia); //actualizar historia
        void DeleteHistoria(int idHistoria);//borrar historia
        Historia GetHistoria(int idHistoria); //buscar por id
        //IEnumerable<Historia> GetHistoriaPorFiltro(string filtro); //buscar por filtro          
        IEnumerable<VisitaPyP> GetVisitasHistoria(int idHistoria); //buscar por idHistoria
    }
}
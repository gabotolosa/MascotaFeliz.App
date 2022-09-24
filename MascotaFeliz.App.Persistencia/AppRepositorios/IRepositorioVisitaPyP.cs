using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisitaPyP
    {
        
        IEnumerable<VisitaPyP> GetAllVisitasPyP();//listar todos los visitas
        VisitaPyP AddVisitaPyP(VisitaPyP visitaPyP); //agregar visita
        VisitaPyP UpdateVisitaPyP(VisitaPyP visitaPyP); //actualizar visita
        void DeleteVisitaPyP(int idVisitaPyP);//borrar visita
        VisitaPyP GetVisitaPyP(int idVisitaPyP); //buscar por id

        //IEnumerable<VisitaPyP> GetVisitasPyPPorFiltro(int filtro);//buscar por filtro
    }
}
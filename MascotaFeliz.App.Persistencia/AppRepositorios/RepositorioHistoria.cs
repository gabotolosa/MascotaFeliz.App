using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;
namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioHistoria
    {
        /// <summary>
        /// Referencia al contexto de Historia
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//

        public RepositorioHistoria(AppContext appContext){
            _appContext=appContext;
        }
    
        
    }
}

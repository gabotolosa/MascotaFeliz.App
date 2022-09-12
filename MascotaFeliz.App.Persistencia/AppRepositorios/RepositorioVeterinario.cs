using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVeterinario:IRepositorioVeterinario
    {
        private readonly AppContext _appContext;

        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Veterinario AddVeterinario(Veterinario veterinario)
        {
            var veterinarioAdicionado = _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }

        public void DeleteVeterinario(int iDVeterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(d=>d.Id==iDVeterinario);
            if (veterinarioEncontrado==null)
                return;
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }

        public Veterinario UpdateVeterinario(Veterinario veterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault( d => d.Id == veterinario.Id);
            if(veterinarioEncontrado != null)
            {
                veterinarioEncontrado.Nombres=veterinario.Nombres;
                veterinarioEncontrado.Apellidos=veterinario.Apellidos;
                veterinarioEncontrado.Direccion=veterinario.Direccion;
                veterinarioEncontrado.Telefono=veterinario.Telefono;
                veterinarioEncontrado.TarjetaProfesional=veterinario.TarjetaProfesional;

                _appContext.SaveChanges();
            }
            return veterinarioEncontrado;
        }
    }
}
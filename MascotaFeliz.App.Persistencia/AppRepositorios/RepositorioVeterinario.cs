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

        public IEnumerable<Veterinario> GetAllVeterinarios()
        {
            return GetAllVeterinarios_();
        }

        public IEnumerable<Veterinario> GetAllVeterinarios_()
        {
            return _appContext.Veterinarios;
        }

        public Veterinario GetVeterinario(int iDVeterinario)
        {
            return _appContext.Veterinarios.FirstOrDefault(d => d.Id == iDVeterinario);
        }

        public IEnumerable<Veterinario> GetVeterinarioPorFiltro(string filtro)
        {
            var veterinarios = GetAllVeterinarios();
            if(veterinarios != null)
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    veterinarios = veterinarios.Where(s => s.Nombres.Contains(filtro));     
                }
                
            }
            return veterinarios;
        }

    }
}
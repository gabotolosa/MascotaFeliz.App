using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinarios();//listar todos los veterinarios
        Veterinario AddVeterinario(Veterinario veterinario); //agregar veterinario
        Veterinario UpdateVeterinario(Veterinario veterinario); //actualizar veterinario
        void DeleteVeterinario(int iDVeterinario); //borrar veterinario
        Veterinario GetVeterinario(int iDVeterinario); //buscar veterinario por id
        IEnumerable<Veterinario> GetVeterinarioPorFiltro(string filtro);
    }
}
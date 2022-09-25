using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class AsignarDuenoModel : PageModel
    {
        

      /*  
        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioDueno _repoDueno;

        public Mascota mascota{get;set;}
        public IEnumerableDueno<Dueno> listaDuenos{get;set;}
        
        public AsignarDuenoModel(){
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        }

        public IActionResult OnGet(int mascotaId){
            mascota = _repoMascota.GetMascota(mascotaId);
            listaDuenos= _repoDueno.GetAllDuenos();
            if (mascota == null){
                return RedirectToPage("./NotFound.html");
            }
            else{
                return Page();
            }
        }
    */    

    }
}

/*
<h2 class="text-center my-3">Editar Mascotas</h2>
<div class="principalForm">
    <form method="post" >
        <div class="form-group">
            <input type="hidden" asp-for = "mascota.Id" />
            
            <label asp-for="mascota.Nombre"></label>
            <input asp-for="mascota.Nombre" class="form-control">
            <label asp-for="mascota.Color"></label>
            <input asp-for="mascota.Color" class="form-control">
            <label asp-for="mascota.Raza"></label>
            <input asp-for="mascota.Raza" class="form-control">
            <label asp-for="mascota.Especie"></label>
            <input asp-for="mascota.Especie" class="form-control">
            
            <label for="dueno">Dueño</label>
            <select id="dueno" asp-for="mascota.Dueno.Id" name = "duenoId">
                <option value="0">Seleccione un Dueño</option>
                @foreach (var dueno in Model.listaDuenos)
                {
                    <option value="@dueno.Id">@dueno.Nombres @dueno.Apellidos</option>
                }
            </select>
            <label for="veterinario">Veterinario</label>
            <select id="veterinario" asp-for="mascota.Veterinario.Id" name = "veterinarioId">
                <option value="0">Seleccione un Veterinario</option>
                @foreach (var veterinario in Model.listaVeterinarios)
                {
                    <option value="@veterinario.Id">@veterinario.Nombres @veterinario.Apellidos</option>
                }
            </select>

            <button type="submit" class="btn btn-primary">Grabar</button>
        </div>
    </form>
</div>

<a asp-page="./ListaMascotas" class="btn-default">Lista de Mascotas </a>


*/
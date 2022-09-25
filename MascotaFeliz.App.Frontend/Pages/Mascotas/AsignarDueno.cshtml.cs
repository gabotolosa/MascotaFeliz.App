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

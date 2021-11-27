using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migrants.App.Persistencia.AppRepositorios;
using E_Migrants.App.Persistencia;
using E_Migrants.App.Dominio.Entidades;
using Microsoft.AspNetCore.Authorization;

namespace E_Migrants.App.Frontend.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioMigrantes repositorioMigrante;
        public Migrante Migrante { get; set; }

        public DetailsModel()
        {
            this.repositorioMigrante = new RepositorioMigrante(new E_Migrants.App.Persistencia.AppRepositorios.AppContext());
        }

        public IActionResult OnGet(int migranteID)
        {
            Migrante = repositorioMigrante.GetMigrante(migranteID);
            if (Migrante == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }

    }
}
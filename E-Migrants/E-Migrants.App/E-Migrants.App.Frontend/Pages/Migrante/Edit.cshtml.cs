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
    public class EditModel : PageModel
    {
        private readonly IRepositorioMigrantes repositorioMigrante;
        [BindProperty]
        public Migrante Migrante { get; set; }


         public EditModel()
        {
            this.repositorioMigrante=new RepositorioMigrante(new E_Migrants.App.Persistencia.AppRepositorios.AppContext());
        }
        public IActionResult OnGet(int? MigranteID)
        {
            if (MigranteID.HasValue)
            {
                Migrante = repositorioMigrante.GetMigrante(MigranteID.Value);
            }
            else
            {
                Migrante = new Migrante();

            }
            if (Migrante == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if (Migrante.Id > 0)
            {
                Migrante = repositorioMigrante.UpdateMigrante(Migrante);
            }
            else
            {
                repositorioMigrante.AddMigrante(Migrante);
            }
            return Page();
        }
    }
}
using System;
using E_Migrants.App.Dominio.Entidades;
using System.Collections.Generic;

namespace E_Migrants.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMigrantes
    {
        IEnumerable<Migrante> GetAllMigrantes();
         Migrante AddMigrante(Migrante migrante);
         Migrante UpdateMigrante(Migrante migrante);
        //  Migrante DeleteMigrante(int idMigrante);
         Migrante GetMigrante(int idMigrante);
    }
}
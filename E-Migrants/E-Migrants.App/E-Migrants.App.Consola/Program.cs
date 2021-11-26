using System;
using System.Collections.Generic;
using E_Migrants.App.Dominio;
using E_Migrants.App.Persistencia;
using E_Migrants.App.Persistencia.AppRepositorios;

namespace E_Migrants.App.Consola
{
    class Program
    {
        public static IRepositorioMigrantes _repoMigrante = new RepositorioMigrante(new Persistencia.AppRepositorios.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

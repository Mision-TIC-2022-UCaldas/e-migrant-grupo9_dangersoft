using System;
using System.Collections.Generic;
using System.Linq;
using E_Migrants.App.Dominio.Entidades;

namespace E_Migrants.App.Persistencia.AppRepositorios
{
    public class RepositorioMigrante : IRepositorioMigrantes
    {
        private readonly AppContext _appContext;

        public RepositorioMigrante(AppContext appContext){
            _appContext = appContext;
        }

        IEnumerable<Migrante> IRepositorioMigrantes.GetAllMigrantes()
        {
            return _appContext.Migrante;
        }

        Migrante IRepositorioMigrantes.AddMigrante(Migrante Migrante){
            var migranteAdicionado = _appContext.Migrante.Add(Migrante);
            _appContext.SaveChanges();
            return migranteAdicionado.Entity;
        }

        Migrante IRepositorioMigrantes.GetMigrante(int idMigrante){
            return _appContext.Migrante.FirstOrDefault(m => m.Id == idMigrante);
        }

        Migrante IRepositorioMigrantes.UpdateMigrante(Migrante Migrante)
        {
            var migranteEncontrado = _appContext.Migrante.FirstOrDefault(m => m.Id == Migrante.Id);
            if (migranteEncontrado != null)
            {
                migranteEncontrado.nombre = Migrante.nombre;
                migranteEncontrado.apellidos = Migrante.apellidos;
                migranteEncontrado.TipoDocumento = Migrante.TipoDocumento;
                migranteEncontrado.NumeroDocumento = Migrante.NumeroDocumento;
                migranteEncontrado.PaisdeOrigen = Migrante.PaisdeOrigen;
                migranteEncontrado.FechaDeNacimiento = Migrante.FechaDeNacimiento;
                migranteEncontrado.Email = Migrante.Email;
                migranteEncontrado.Telefono = Migrante.Telefono;
                migranteEncontrado.DireccionActual = Migrante.nombre;
                migranteEncontrado.Ciudad = Migrante.Ciudad;
                migranteEncontrado.SituacionLaboral = Migrante.SituacionLaboral;

                _appContext.SaveChanges();
            }
            return migranteEncontrado;
        }


    }
}
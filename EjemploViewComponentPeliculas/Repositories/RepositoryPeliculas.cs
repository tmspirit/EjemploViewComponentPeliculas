using EjemploViewComponentPeliculas.Data;
using EjemploViewComponentPeliculas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploViewComponentPeliculas.Repositories
{
    public class RepositoryPeliculas
    {
        PeliculasContext context;
        public RepositoryPeliculas(PeliculasContext context)
        {
            this.context = context;
        }
        #region PELICULAS
        public List<Pelicula> GetPeliculas()
        {
            var consulta = from datos in context.Peliculas
                           select datos;
            return consulta.ToList();
        }

        public List<Pelicula> GetPeliculasGenero(int genero)
        {
            var consulta = from datos in context.Peliculas
                           where datos.IdGenero == genero
                           select datos;
            return consulta.ToList();
        }

        public Pelicula GetPelicula(int idPeli)
        {
            var consulta = (from datos in context.Peliculas
                            where datos.idPelicula == idPeli
                            select datos).SingleOrDefault();

            return consulta as Pelicula;
        }
        #endregion

        #region GENEROS
        public List<Genero> Getgeneros()
        {
            return this.context.Generos.ToList();
        }
        #endregion


    }
}

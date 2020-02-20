using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploViewComponentPeliculas.Models
{
    [Table("Peliculas")]
    public class Pelicula
    {
        [Column("idPelicula")]
        [Key]
        public int idPelicula { get; set; }
        [Column("IdDistribuidor")]
        public int IdDistribuidor { get; set; }
        [Column("IdGenero")]
        public int IdGenero { get; set; }
        [Column("Titulo")]
        public String Titulo { get; set; }
        [Column("IdNacionalidad")]
        public int IdNacionalidad { get; set; }
        [Column("Argumento")]
        public String Argumento { get; set; }
        [Column("Foto")]
        public String Foto { get; set; }
        [Column("Fecha_Estreno")]
        public DateTime Fecha_Estreno { get; set; }
        [Column("Actores")]
        public String Actores { get; set; }
        [Column("Director")]
        public String Director { get; set; }
        [Column("Duracion")]
        public int Duracion { get; set; }
        [Column("Precio")]
        public int Precio { get; set; }
        [Column("YouTube")]
        public String YouTube { get; set; }
        [Column("EnlaceVideo")]
        public String EnlaceVideo { get; set; }

    }
}

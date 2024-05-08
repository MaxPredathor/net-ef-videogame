using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    [Table("videogames")]
    public class Videogioco
    {
        [Key]
        public int id { get; set; }
        public string? name { get; set; }
        [Column("release_date")]
        public DateTime? ReleaseDate { get; set; }
        public string overview { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [Column("software_house_id")]
        public int SoftwareHouseID { get; set; }

        //public Videogioco(string nome, DateTime dataDiRilascio, string overview, DateTime createdAt, DateTime updatedAt, int softwareHouseID)
        //{
        //    name = nome;
        //    ReleaseDate = dataDiRilascio;
        //    this.overview = overview;
        //    CreatedAt = createdAt;
        //    UpdatedAt = updatedAt;
        //    SoftwareHouseID = softwareHouseID;
        //}
    }
}

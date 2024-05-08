using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    [Table("software_houses")]
    public class SoftwareHouse
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        [Column("tax_id")]
        public int TaxId { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        
        public SoftwareHouse(string name)
        {
            this.name = name;
            this.TaxId = 100;
            this.city = "Bologna";
            this.country = "Italia";
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }
    }
}

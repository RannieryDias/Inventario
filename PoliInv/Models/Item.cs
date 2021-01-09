using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoliInv.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public String Tipo { get; set; }
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public int Protocolo { get; set; }
    }
}

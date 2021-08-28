using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4WPF.Models
{
    public class CityModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnline.Web.Models
{
    public class Country
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(30,ErrorMessage ="El campo {0} debe contener al menos un caracter")]
        public string Name { get; set; }

        public ICollection<Department> Departments { get; set; }
        [DisplayName("Departments Number")]
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;

    }
}

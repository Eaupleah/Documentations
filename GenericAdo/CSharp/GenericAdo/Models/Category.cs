using CSharp.GenericAdoServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GenericAdo.Models
{

    public class Category : BaseEntity
        {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; } = null!;
            public string? Description { get; set; }
        }
   
}

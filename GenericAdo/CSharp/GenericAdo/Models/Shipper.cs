using CSharp.GenericAdoServices.Models;

namespace CSharp.GenericAdo.Models
{
    public class Shipper : BaseEntity
        {
            public int ShipperID { get; set; }
            public string CompanyName { get; set; } = null!;
            public string? Phone { get; set; }
        }
   
}

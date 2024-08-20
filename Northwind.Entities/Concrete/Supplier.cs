using Core.Entities;

namespace Northwind.Entities.Concrete
{
    public class Supplier : IEntity
    {
        public int SupplierID { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }
    }
}

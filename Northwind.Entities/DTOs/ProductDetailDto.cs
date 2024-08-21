using Core.Entities;

namespace Northwind.Entities.DTOs
{
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string CategoryName { get; set; }

        public string SupplierName { get; set; }

        public string SupplierCountry { get; set; }

        public short UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }

    }
}

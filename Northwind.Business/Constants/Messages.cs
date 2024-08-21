using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Constants
{
    public static class Messages
    {
        // General:
        public static string Added = "Eklendi";
        public static string NotFound = "Bulunamadı.";
        public static string NameInvalid = "Ürün ismi geçersiz.";
        public static string Listed = "Ürünler Listelendi";
        public static string Updated = "Güncellendi.";

        public static string MaintenanceTime = "Şu anda bakım gerçekleşiyor.";

        // Product: 
        public static string ProductPriceInvalid = "Ürün fiyatı 0'dan yüksek olmalıdır.";
    }
}

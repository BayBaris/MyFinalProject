using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static yapılar newlenme ihtiyacı duymaz...
    public static class Messages
    {
        //public değişkenler PascalCase ile yazılır...
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string ProductListed = "Ürünler başarı ile listelendi.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir." ;
        public static string ProductNameAlreadyExists = "Bu isimde ürün zaten sistemde mevcut.";
        internal static string CategoryCountError = "Kategori sayısı en fazla 15 olabilir.";
    }
}

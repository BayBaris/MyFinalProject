using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string CategoryCountError = "Kategori sayısı en fazla 15 olabilir.";
        public static string AuthorizationDenied = "Bu işlem için yetkiniz yok!";
        public static string UserRegistered = "Kullanıcı kayı edildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string SuccessfulLogin = "Başarı ile giriş yapıldı";
        public static string PasswordError = "Eksik ya da yanlış parola girdiniz!";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
    }
}

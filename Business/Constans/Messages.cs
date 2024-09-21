using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string ProductsListed = "Ürünler listelendi";

        public static string ProductCountOfCategoryError = "Category sayısı 10 dan fazla";
        public static string ProductNameAlreadyExists = "Bu isimde ürün zaten mevcut";

        public static string CategoryLimitExceded = "Category sınırı aşıldı";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kayıt Olundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatası";
        public static string SuccessfulLogin = "Başarılı giriş";

        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = " Kullanıcı token yaratıldı";
    }
}

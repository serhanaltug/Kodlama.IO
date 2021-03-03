using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün adı geçersiz.";
        public static string MaintenanceTime = "Bakım zamanı.";
        public static string ProductsListes = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 100 ürün olabilir.";
        public static string ProductNameAlreadyExisys = "Bu isimde kayıtlı ürün var.";
        public static string CategoryCountError = "Categori sayısı en fazla 15 olabilir.";
        public static string AuthorizationDenied = "İzin red edildi.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string UserRegistered = "Kullanıcı kayıt edildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Kullanıcı girişi başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten var.";
    }
}

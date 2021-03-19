namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Eklendi";
        public static string Updated = "Güncellendi";
        public static string Deleted = "Silindi";
        public static string CarCanNotBeRentError = "Araba şu anda kirada olduğu için tekrar kiralanamaz.";
        public static string ImageCountError = "En fazla 5 resim ekleyebilirsiniz.";
        public static string CategoryCountError = "Categori sayısı en fazla 15 olabilir.";
        public static string AuthorizationDenied = "İzin red edildi.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string UserRegistered = "Kullanıcı kayıt edildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Kullanıcı girişi başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten var.";
        public static string RentSuccess = "Aracı kiraladınız.";
        public static string RentCheckSuccess = "Araç kiralamaya uygundur.";
        public static string RentCheckFailed = "Bu araç şu anda kirada.";
        public static string RentFailed= "Aracı kiralarken hata oluştu.";
        public static string RentDateCannotLessThenToday = "Kiralama tarihi bugünden önce olamaz.";
        public static string RentDateError = "Lütfen tarihleri kontrol ediniz.";
        public static string OrderCompleted = "Aracı kiraladığınız için teşekkür ederiz.";
        public static string OrderNotCompleted = "Araç kiralama başarısız oldu.";
    }
}

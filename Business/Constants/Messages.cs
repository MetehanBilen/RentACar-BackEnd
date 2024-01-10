using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        /*
           * Brand 
           * Car
           * Color
           * Customer
           * Rental
           * User
          */
        //CRUD  

        public static string BrandAdded   = "Marka Eklendi.";
        public static string BrandListed  = "Markalar Listelendi.";
        public static string BrandUpdated = "Makra Güncellendi.";
        public static string BrandDeleted = "Marka Silindi.";

        public static string CarAdded   = "Araba Eklendi";
        public static string CarListed  = "Arabalar Listelendi.";
        public static string CarUpdated = "Araba Güncellendi.";
        public static string CarDeleted = "Araba Silindi.";

        public static string CarImageUploaded = "Araba Görüntüsü Eklendi.";

        public static string ColorAdded   = "Renk Eklendi.";
        public static string ColorListed  = "Renkler Listelendi.";
        public static string ColorUpdated = "Renk Güncellendi.";
        public static string ColorDeleted = "Renk Silindi.";

        public static string ColorError = "Renk Hatası !";

        public static string CustomerAdded   = "Müşteri Eklendi.";
        public static string CustomerListed  = "Müşteriler Listelendi.";
        public static string CustomerUpdated = "Müşteri Güncellendi.";
        public static string CustomerDeleted = "Müsteri Silindi.";

        public static string RentalAdded   = "Kiralama Eklendi.";
        public static string RentalListed  = "Kiralamalar Listelendi.";
        public static string RentalUpdated = "Kiralama Güncellendi.";
        public static string RentalDeleted = "Kiralama Silindi.";

        public static string UserAdded = "Kullanıcı Eklendi.";
        public static string UserListed = "Kullanıcılar Listelendi.";
        public static string UserUpdated = "Kullanıcı Güncellendi.";
        public static string UserDeleted = "Kullanıcı Silindi";


        public static string AuthorizationDenied = "Yetkisiz işlem.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

    }
}

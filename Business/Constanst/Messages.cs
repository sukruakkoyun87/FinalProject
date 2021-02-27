﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constanst
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";

        public static string ProductNameInvalid = "Ürün ismi Geçersiz";

        public static string MaintenanceTime="Sistem Bakımda ";

        public static string ProductsListed = "Ürünler Listelendi";

        public  static string ProductCountOfCategoryError="Bir Kategoriden en fazla 10 adet olmalıdır";

        public static string CategoryLimitExtended = "Kategori Limiti Aşıldı";


        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}

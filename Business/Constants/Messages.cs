﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string AddedBrand = "Marka başarıyla eklendi.";
        public static string DeletedBrand = "Marka başarıyla silindi.";
        public static string UpdatedBrand = "Marka başarıyla güncellendi.";
        public static string FailedBrandAddOrUpdate = "Lütfen marka isminin uzunluğunu 2 karakterden fazla giriniz.";

        public static string AddedCar = "Araba başarıyla eklendi.";
        public static string DeletedCar = "Araba başarıyla silindi.";
        public static string UpdatedCar = "Araba başarıyla güncellendi.";
        public static string FailedCarAddOrUpdate = "Lütfen günlük fiyat kısmını 0'dan büyük giriniz.";

        public static string AddedColor = "Renk başarıyla eklendi.";
        public static string DeletedColor = "Renk başarıyla silindi.";
        public static string UpdatedColor = "Renk başarıyla güncellendi.";

        public static string AddedCustomer = "Müşteri başarıyla eklendi.";
        public static string DeletedCustomer = "Müşteri başarıyla silindi.";
        public static string UpdatedCustomer = "Müşteri başarıyla güncellendi.";


        public static string AddedUser = "Kullanıcı başarıyla eklendi.";
        public static string DeletedUser = "Kullanıcı başarıyla silindi.";
        public static string UpdatedUser = "Kullanıcı başarıyla güncellendi.";


        public static string AddedRental = "Araba Kiralama işlemi baraşıyla gerçekleşti.";
        public static string DeletedRental = "Araba Kiralama işlemi iptal edildi.";
        public static string UpdatedRental = "Araba Kiralama işlemi güncellendi.";
        public static string FailedRentalAddOrUpdate = "Bu araba henüz teslim edilmediği için kiralayamazsınız.";
        public static string ReturnedRental = "Kiraladığınız araç teslim edildi.";

        public static string CarAdded = "Araç eklendi";
        public static string ColorAdded = "Renk eklendi";
        public static string BrandAdded = "Marka eklendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string RentalAdded = "Kiralama eklendi";
        public static string CarImageAdded = "Araç resmi eklendi";
        public static string CarDeleted = "Araç silindi";
        public static string ColorDeleted = "Renk silindi";
        public static string BrandDeleted = "Marka silindi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string CustomerDeleted = "Müsteri silindi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string CarUpdated = "Araç guncellendi";
        public static string CarImageDeleted = "Araç resmi silindi";
        public static string ColorUpdated = "Renk guncellendi";
        public static string BrandUpdated = "Marka guncellendi";
        public static string UserUpdated = "Kullanıcı guncellendi";
        public static string CustomerUpdated = "Müşteri guncellendi";
        public static string RentalUpdated = "Kiralama guncellendi";
        public static string CarImageUpdated = "Araç resmi güncellendi";
        public static string CarNotFound = "Araç bulunamadı";
        public static string ColorNotFound = "Renk bulunamadı";
        public static string BrandNotFound = "Marka bulunamadı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string CustomerNotFound = "Müşteri bulunamadı";
        public static string RentalNotFound = "Kiralama bulunamadı";
        public static string CarImageNotFound = "Resim bulunamadı";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz";
        public static string CarExists = "Araç zaten veritabanında var.";
        public static string ColorExists = "Renk zaten veritabanında var.";
        public static string BrandExists = "Marka zaten veritabanında var.";
        public static string UserExists = "Kullanıcı zaten veritabanında var.";
        public static string CustomerExists = "Musteri zaten veritabanında var.";
        public static string RentalExists = "Kiralama kaydı veritabanında var.";
        public static string CarImageExists = "Resim kaydı veritabanında var";
        public static string CarListed = "Araç(lar) listelendi";
        public static string ColorListed = "Renk(ler) listelendi";
        public static string BrandListed = "Marka(lar) listelendi";
        public static string UserListed = "Kullanıcı(lar) listelendi";
        public static string CustomerListed = "Müşteri(ler) listelendi";
        public static string RentalListed = "Kiralama(lar) listelendi";
        public static string RentalIsOnRent = "Araç şu anda kirada.";
        public static string RentalEnded = "Araç kiradan döndü.";
        public static string MaintenanceTime = "Sistem bakımı var";
        public static string MaxCarImageCountLimit = "Bir aracın en fazla 5 resmi olabilir";
        public static string CarImageListed = "Resim(ler) listelendi";
    }
}

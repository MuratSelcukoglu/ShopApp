# Shop App

## PROJE

- Murat SELÇUKOĞLU ~ https://github.com/MuratSelcukoglu

## Amaç

Shopp App, belirli kategorilere ait telefon veya farklı bir ürünün kullanıcılar tarafından satın alınması ve admin tarafından ugulamanın kontrol edilmesini sağlayan geliştirme şamasında e-ticaret platformudur.

## Özellikler

- Kullanıcılar ve admin sisteme giriş yapabilir.
- Hesap onayı için sistemden mail gönderilir.
- Admin rolüne sahip lan kişilr sisteme ürün ekleyebilir ve sistemdeki tüm ürünleri görüntüleyebilir.
- Kullanıcılar uygulamaya kayıt olup herhangi bir ürünü satın alabilir ve sipariş sürecini takip edebilir.

## Uygulama Çalıştırma aşamaları

-webui prpjesine konumlanıp npm install ile paketleri yükleyin

- shopdata-concrete-ShopContext dosyasında MSSQL veri tabanı bağlantısı adresini yazınız.
  -webui-appsettings.json hesap onayında mail atacak olan emailsender deki alana mail bilgisini doldurunuz.
  --webui içinde alışveriş sepeti ve kredikartı entegrasyonları için örnek kullanımı Iyzipay.com sitesinden ücretsiz versionunu alıp kullanabilirisiniz. controller-cartcontroller-PaymentProcess hesap açtıktan sonra içinde apıkey,secretkey --ve url alanını doldurmalısınız.

## Kullanılan Teknolojiler

![ShopApp](https://user-images.githubusercontent.com/48556212/71645965-e9880480-2cf0-11ea-9a43-352c8f22cfe4.png)

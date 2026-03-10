# 🍽️ UdemySignalRProject - Anlık Restoran Yönetim Sistemi

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)
![SignalR](https://img.shields.io/badge/SignalR-REALTIME-FF4B4B?style=for-the-badge)
![SQL SERVER](https://img.shields.io/badge/SQL_SERVER-DATABASE-CC2927?style=for-the-badge&logo=microsoftsqlserver)
![MVC](https://img.shields.io/badge/ASP.NET-MVC-512BD4?style=for-the-badge)
![QR CODE](https://img.shields.io/badge/QR-CODE-000000?style=for-the-badge)

**UdemySignalRProject**, SignalR teknolojisi ile gerçek zamanlı veri akışı sağlayan, QR kodlu sipariş yönetimi ve anlık istatistik takibini destekleyen modern bir **restoran yönetim sistemidir**.

Proje; **N-Katmanlı Mimari**, **Repository Pattern** ve **RESTful API** standartları gözetilerek geliştirilmiştir.

---

## 📋 İçindekiler

- [✨ Öne Çıkan Özellikler](#-öne-çıkan-özellikler)
- [🏗️ Proje Yapısı](#️-proje-yapısı)
- [🛠️ Teknoloji Yığını](#️-teknoloji-yığını)
- [🖼️ Ekran Görüntüleri](#️-ekran-görüntüleri)

---

## ✨ Öne Çıkan Özellikler

- 📡 **Anlık SignalR Entegrasyonu** — İstatistikler, kasa, rezervasyon ve bildirimler gerçek zamanlı güncellenir
- 📱 **QR Kod Oluşturma** — Masalar için QR Kod oluşturma
- 🛒 **Sepet & Sipariş Yönetimi** — Dinamik sepet, ürün ve kategori yönetimi
- 💬 **Anlık Mesajlaşma** — SignalR tabanlı canlı müşteri-garson iletişimi
- 📊 **Canlı İstatistikler** — Anlık kasa, masa doluluk ve istatistik paneli
- 🌍 **Rapid API Entegrasyonu** — Dünya mutfağı yemek listeleri
- 🔔 **Bildirim Sistemi** — Gerçek zamanlı bildirimler
- 🪑 **Masa Yönetimi** — Müşteri masa seçimi ve QR ile rezervasyon
- ✉️ **Mail Gönderme** — Sistem üzerinden otomatik mail
- ✅ **Fluent Validation** — Kapsamlı form doğrulama
- 🔐 **Identity ile Kimlik Doğrulama** — Güvenli giriş/kayıt sistemi
- 🗺️ **AutoMapper** — DTO ve Entity eşlemeleri

---

## 🏗️ Proje Yapısı

```
UdemySignalRProject/
├── 📦 SignalR.EntityLayer        # Domain Entity'leri
├── 📦 SignalR.DtoLayer           # Data Transfer Objects
├── 📦 SignalR.DataAccessLayer    # Repository & DbContext & Migrations
├── 📦 SignalR.BusinessLayer      # İş Mantığı Katmanı
├── 🌐 SignalRApi                 # RESTful API (Backend)
└── 🖥️ SignalRWebUI              # MVC Frontend (UI)
```

---

## 🛠️ Teknoloji Yığını

| Teknoloji | Açıklama |
|-----------|----------|
| **ASP.NET Core 8.0** | Backend API ve MVC UI |
| **SignalR** | Gerçek zamanlı iletişim |
| **Entity Framework Core** | ORM & Code First |
| **SQL Server** | Veritabanı |
| **AutoMapper** | DTO - Entity dönüşümleri |
| **Fluent Validation** | Doğrulama katmanı |
| **ASP.NET Core Identity** | Kimlik doğrulama |
| **QR Code Entegrasyonu** | Masa bazlı QR sipariş |
| **Rapid API** | Dünya mutfağı yemek verileri |
| **AJAX & jQuery** | Dinamik sayfa işlemleri |
| **Bootstrap** | Responsive tasarım |

---

## 🖼️ Ekran Görüntüleri

<img width="1920" height="1017" alt="SignalR1" src="https://github.com/user-attachments/assets/7d069a29-1315-4b35-af06-72016341fe1f" />
<img width="1920" height="1015" alt="SignalR2" src="https://github.com/user-attachments/assets/7cc45287-d500-4526-ae04-f79307f93296" />
<img width="1920" height="992" alt="SignalR3" src="https://github.com/user-attachments/assets/ccb20762-2f79-4425-a63b-ee3c71d17b7a" />
<img width="1920" height="1017" alt="SignalR4" src="https://github.com/user-attachments/assets/1c5e263b-247c-45e2-975a-1ad01a5377be" />
<img width="1920" height="1021" alt="SignalR5" src="https://github.com/user-attachments/assets/ad8565d9-96a5-4d5d-bbc2-68579bb7d47b" />
<img width="1920" height="1003" alt="SignalR6" src="https://github.com/user-attachments/assets/06f413ff-2c84-4add-a11a-27930c1fdc91" />
<img width="1920" height="1025" alt="SignalR7" src="https://github.com/user-attachments/assets/245d213f-f986-487d-a75a-40e42dacd36b" />
<img width="1920" height="1014" alt="SignalR8" src="https://github.com/user-attachments/assets/2775591f-96bd-45b9-ad19-45c793864176" />
<img width="1920" height="1023" alt="SignalR9" src="https://github.com/user-attachments/assets/de995592-00cc-4d67-8d9a-70549cf1ffe7" />
<img width="1920" height="1014" alt="SignalR10" src="https://github.com/user-attachments/assets/3c61bec9-a261-4f84-ac87-090803f3a07f" />
<img width="1920" height="1021" alt="SignalR11" src="https://github.com/user-attachments/assets/aef856ce-c96b-49df-bbd8-6d077f422a8a" />
<img width="1920" height="1008" alt="SignalR12" src="https://github.com/user-attachments/assets/86aa03ea-32a0-4302-8a1c-566489f1f4de" />
<img width="1920" height="1021" alt="SignalR13" src="https://github.com/user-attachments/assets/3bcf62f3-01a3-404c-8890-d3beda4f55d5" />
<img width="1920" height="1020" alt="SignalR14" src="https://github.com/user-attachments/assets/f68c1250-36e6-4539-96f5-41b56271420d" />
<img width="1920" height="1014" alt="SignalR15" src="https://github.com/user-attachments/assets/2914ad38-e1ca-414d-9e8f-13b299260361" />
<img width="1920" height="1026" alt="SignalR16" src="https://github.com/user-attachments/assets/38a8df66-c3f6-43b5-8b5e-3da1ab4d4fcf" />
<img width="1920" height="1018" alt="SignalR17" src="https://github.com/user-attachments/assets/916d26c1-0dcb-48bd-a9a2-624ded9a6d51" />
<img width="1920" height="1008" alt="SignalR18" src="https://github.com/user-attachments/assets/a52a7e20-22ff-4000-9407-d56840c018c4" />
<img width="1920" height="1024" alt="SignalR19" src="https://github.com/user-attachments/assets/630421f2-afe5-4499-83da-b435c0b24818" />
<img width="1920" height="1022" alt="SignalR20" src="https://github.com/user-attachments/assets/d65de6e1-9813-4e9b-8345-3956a3991961" />
<img width="1920" height="1018" alt="SignalR21" src="https://github.com/user-attachments/assets/aa13aa4b-e311-498d-9957-6e424fef06b2" />
<img width="1920" height="1011" alt="SignalR22" src="https://github.com/user-attachments/assets/1837e98d-3c60-4ffc-99f2-cf13fec6a719" />

----

## 🚀 Kurulum

```bash
# 1. Repoyu klonla
git clone https://github.com/NurdanOz/UdemySignalRProject.git

# 2. appsettings.json içinde connection string'i düzenle
# 3. Migration uygula
Update-Database

# 4. SignalRApi ve SignalRWebUI projelerini aynı anda çalıştır
```

---

<p align="center">
  💻 <b>ASP.NET Core</b> ile geliştirilmiştir &nbsp;|&nbsp; ⭐ Beğendiysen yıldız vermeyi unutma!
</p>

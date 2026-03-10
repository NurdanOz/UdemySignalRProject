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
- 📱 **QR Kod ile Sipariş** — Müşteriler masadan QR okutarak sipariş verebilir
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

> 📸 Ekran görüntülerini buraya ekleyebilirsin:
> `![Açıklama](screenshots/goruntu.png)`

| Sayfa | Görüntü |
|-------|---------|
| 🏠 Ana Sayfa | *(yakında)* |
| 📊 İstatistik Paneli | *(yakında)* |
| 🛒 Sepet & Sipariş | *(yakında)* |
| 📱 QR Sipariş | *(yakında)* |
| 💬 Canlı Mesajlaşma | *(yakında)* |

---

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

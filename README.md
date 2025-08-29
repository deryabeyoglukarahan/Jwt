# 🔑 JWT Authentication - User Management API

Bu proje, **Entity Framework Core** ve **JWT (JSON Web Token)** kullanarak bir **kimlik doğrulama sistemi** oluşturmayı amaçlamaktadır.  
Kullanıcılar, email ve şifre ile sisteme giriş yapar ve geçerli bir JWT alarak yetkilendirilmiş işlemleri gerçekleştirebilir.

---

## 📂 Proje Gereksinimleri

- **ORM Aracı**: Entity Framework Core  
- **Yaklaşım**: Code First  
- **Tablo**: `Users`  
- **Alanlar**:
  - `Id` (int) → Birincil anahtar  
  - `Email` (string) → Kullanıcının benzersiz e-posta adresi  
  - `Password` (string) → Kullanıcının şifresi (**hashlenmiş olarak saklanmalıdır**)  

- **Özellikler**:
  - Kullanıcı kaydı ve login yapılabilmeli  
  - JWT oluşturulmalı ve kullanıcıya döndürülmeli  
  - JWT doğrulaması yapılmalı, yetkisiz istekler engellenmeli  
  - `[Authorize]` niteliği kullanılarak korunan endpointler oluşturulmalı  

---

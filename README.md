# 🏢 Apartment Management System Backend

A well-structured backend system developed using **ASP.NET Core (C#)** for managing apartments and rental properties. This backend solution supports comprehensive **property, staff, and user management** integrated with **MySQL**, leveraging a layered architecture including **Repository Pattern**, **JWT-based Authentication**, and **Entity Framework Core (EF Core)** for data migrations and operations.

GitHub Repository: [Apartment Management System Backend](https://github.com/Rist-A/Apartment-Management-System-Backend.git)

---

## 🚀 Quick Start

### 📦 Prerequisites

* [.NET SDK 6.0+](https://dotnet.microsoft.com/en-us/download)
* [MySQL Server](https://dev.mysql.com/downloads/mysql/)
* [Visual Studio 2022+](https://visualstudio.microsoft.com/) or Visual Studio Code

### 🔧 Running the Backend

```bash
# Clone the repository
git clone https://github.com/Rist-A/Apartment-Management-System-Backend.git

# Navigate into the project folder
cd Apartment-Management-System-Backend

# Restore dependencies
dotnet restore

# Run migrations to set up database
dotnet ef database update

# Run the backend server
dotnet run
```

The API will be available at `http://localhost:5000` 

---

## ✨ Features

* 🏠 **Apartment & Property Management**: Add, update, delete properties
* 👥 **User & Staff Management**: Register, manage users and admin/staff roles
* 🔐 **JWT Authentication**: Secure login and token-based session management
* 📍 **Leaflet.js Integration**: Store and serve location data for properties
* 📊 **Admin Dashboard**: Aggregate statistics and user/property summaries
* ⚙️ **Repository Pattern**: Clean architecture for maintainability and testing
* 📦 **Migration System**: EF Core-based migrations for database versioning
* 🌐 **Cross-Origin Requests Enabled (CORS)**
* 🗓️ Scheduling for Maintenance Requests 

---

## 🛠 Technologies Used

* ASP.NET Core Web API
* Entity Framework Core + MySQL
* JWT Authentication
* C# + LINQ
* Repository + Service Layers
* Leaflet.js (for frontend mapping)

---

## 📦 Future Enhancements

*  Payment Gateway Integration
* AI-based Price Suggestions
* Mobile App Support (via API)

---

## 👤 Author

**Wubrist Alemu**
GitHub: [@Rist-A](https://github.com/Rist-A)
Linkedin:[Wubrist Alemu](https://www.linkedin.com/in/wubrist-alemu-bb307a361/)

---

✅ Well-structured | 🔒 Secure | 🧠 Smart Integration | 🌍 Location-aware

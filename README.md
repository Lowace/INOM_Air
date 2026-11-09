<p align="center">
  <img src="Resources/66ba3ddf-8faf-4108-a1e3-2e78fb6e00b3NOBG.png" alt="INOM Air Logo" width="240"/>
</p>

<h1 align="center">International NOM Airlines (INOM Air)</h1>
<h3 align="center">✈️ Flight Booking & Management System</h3>

<p align="center">
  <em>"Fly Near, Fly Far, Fly NOM"</em>
</p>

<p align="center">
  <a href="https://dotnet.microsoft.com/"><img src="https://img.shields.io/badge/.NET%2010.0-Windows%20Forms-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 10"/></a>
  <a href="https://learn.microsoft.com/en-us/dotnet/visual-basic/"><img src="https://img.shields.io/badge/Language-Visual%20Basic%20.NET-00599C?style=for-the-badge&logo=visualbasic&logoColor=white" alt="VB.NET"/></a>
  <a href="https://gunai.io/"><img src="https://img.shields.io/badge/UI%20Framework-Guna.UI2%20WinForms-017B80?style=for-the-badge" alt="Guna UI2"/></a>
  <a href="https://www.mysql.com/"><img src="https://img.shields.io/badge/Database-MySQL%20XAMPP-4479A1?style=for-the-badge&logo=mysql&logoColor=white" alt="MySQL"/></a>
  <img src="https://img.shields.io/badge/Status-Completed%20%26%20Active-brightgreen?style=for-the-badge" alt="Status"/>
</p>

---

## 📖 Table of Contents
- [Project Context](#-project-context)
- [Developer & Academic Team](#-project-developer--academic-team)
- [System Color Palette & Design Identity](#-system-color-palette--design-identity)
- [Application Forms & Architecture](#-application-forms--architecture)
- [Key Features & Highlights](#-key-features--highlights)
- [Database Schema & Integration](#-database-schema--integration)
- [Getting Started & Installation](#-getting-started--installation)
- [Demo Credentials](#-demo-credentials)
- [Project Scopes & Limitations](#-project-scopes--limitations)

---

## 🛫 Project Context

**INOM Air** is a digital desktop Flight Booking and Airline Management System built for **International NOM Airlines**. Developed as a case study for **Computer Programming 3** at **Tarlac State University (College of Computer Studies)**, the application replaces manual scheduling with a seamless, user-centric reservation workflow, automated fare and tax calculation, real-time MySQL database synchronization, and robust behind-the-scenes administrative capabilities.

- **Institution:** Tarlac State University — College of Computer Studies, San Isidro, Tarlac City
- **Course:** Case Study in Computer Programming 3
- **Course Instructor:** Mr. Kwinno Pineda
- **Date of Submission:** November 10, 2026

---

## 👨‍💻 Project Developer & Academic Team

### 🌟 Lead Developer & Full-Stack Architect
<p align="center">
  <strong>Luis Antonio Magdangal</strong><br/>
  <em>Sole Full-Stack Developer & UI/UX Designer for INOM Air</em>
</p>

- **Frontend Development:** Built all user and administrative interfaces utilizing **Guna.UI2 WinForms**, seamless multi-step reservation flows, interactive seat map selector, and clean component architecture.
- **Backend Architecture:** Programmed the entire application logic in **Visual Basic .NET**, fare calculation engine, passenger age and concession logic (RA 9994 Senior & RA 10754 PWD), and booking state management.
- **Database Engineering:** Designed, integrated, and synchronized the **MySQL (`inomairtest_db`)** database, automatic migrations, real-time CRUD operations, DBNull-safe data parsing, and offline fallback.
- **UI/UX Design:** Formulated the brand design language, vector-rendered in-textbox eye password toggles, borderless drag-enabled forms, and custom top-most notification dialogs (`CustomMessageBox`).

---

### 🎓 Academic Case Study Group (Tarlac State University — CCS)
Developed and submitted for **Case Study in Computer Programming 3** under the guidance of **Mr. Kwinno Pineda**:

| Member Name | Case Study Contribution |
| :--- | :--- |
| **Magdangal, Luis Antonio** | **Full-Stack Software Development & UI/UX Design** |
| **Manuel, Quervin Kherjie T.** | Project Lead / Case Study Planning & Coordination |
| **Bautista, Neil Patrick** | Academic Documentation & Analysis |
| **Mallari, Ashley Jamilla** | Workflow & Task Analysis |
| **Datu, Mariah Missy** | Testing & Quality Assurance |
| **Gabatino, Jan Micole** | Data Analysis & System Requirements |
| **Roque, Rodney** | Wireframe Verification & Documentation |

---

## 🎨 System Color Palette & Design Identity

The visual language of **INOM Air** is designed around a modern, travel-inspired color palette engineered to instill subconscious trust, clarity, and comfort:

| Color | Hex Code | Visual Sample | Psychology & System Purpose |
| :--- | :---: | :---: | :--- |
| **Teal** | `#017B80` | ![#017B80](https://via.placeholder.com/18/017B80/017B80.png) | **Primary Brand Color.** Cool tone evoking safety, high-altitude stability, corporate dependability, and calm during checkout. |
| **Coral** | `#FE7349` | ![#FE7349](https://via.placeholder.com/18/FE7349/FE7349.png) | **Accent & Action Color.** Vibrant and creative tone used for primary call-to-actions, Business Class selections, and highlights. |
| **Cream** | `#EDE5D8` | ![#EDE5D8](https://via.placeholder.com/18/EDE5D8/EDE5D8.png) | **Canvas Background.** Warm, neutral color conveying comfort, softness, and humility, preventing eye fatigue. |
| **Pure White** | `#FFFFFF` | ![#FFFFFF](https://via.placeholder.com/18/FFFFFF/FFFFFF.png) | **Card Elevation.** Crisp container cards with subtle drop shadows (`Depth = 15`) and 18–24px corner radiuses. |
| **Muted Slate** | `#696969` | ![#696969](https://via.placeholder.com/18/696969/696969.png) | **Typography.** High-contrast, elegant typography using Segoe UI font weights. |

### Aesthetic Highlights:
- **Borderless Modern Forms:** Custom smooth window-drag handling with circular red close buttons (`#DC3545`).
- **Interactive Eye Password Toggles:** Vector-rendered, clickable eye icons directly inside password textboxes (`IconRight`) that toggle between masked bullets (`●`) and plain text, dynamically switching between muted slate (`#8C919B`) and signature teal (`#017B80`).
- **Custom Top-Most Notifications (`CustomMessageBox`):** Custom modal dialog with rounded borders (`BorderRadius = 30`), `TopMost = True` enforcement, scrollable legal agreement views, and input capture dialogs (`ShowInput`).

---

## 🖥️ Application Forms & Architecture

The application is structured into modular Windows Forms covering the complete passenger and administrative lifecycle:

```
INOM_Air/
│
├── 🚀 Startup & Authentication
│   ├── StartingPage.vb          # Brand splash, Login/Signup gateway, Terms & Conditions trigger
│   ├── SignInPage.vb            # Multi-role authentication (Admin & Customer) with live MySQL sync
│   └── SignUpPage.vb            # 2-step onboarding wizard (Credentials → Personal Info & PWD/Senior)
│
├── 👤 Customer Hub
│   ├── CustomerForm.vb          # Passenger dashboard, booking stats, active ticket card, Profile Editor
│   └── BoardingTicket.vb        # Official digital passenger boarding pass
│
├── ✈️ 6-Step Flight Booking Engine
│   ├── BookingStep1.vb          # Step 1: Origin, Destination, Departure Date, Trip Type
│   ├── BookingStep2.vb          # Step 2: Route listings, direct flights, Economy vs. Business selection
│   ├── BookingStep3.vb          # Step 3: Passenger details, Age group, Senior/PWD 20% discount
│   ├── BookingStep5.vb          # Step 4: Concessions (In-flight meals, baggage matrix, Seat Selection)
│   ├── PickSeats.vb             # Step 4 Modal: Interactive Seat Plan (Class-based seat locking)
│   ├── BookingStep6.vb          # Step 5: Refundability Protection (Standard vs. Flexible +₱500)
│   ├── CheckoutForm.vb          # Step 6: Booking summary, itemized fare breakdown, 256-bit SSL badge
│   └── PaymentForm.vb           # Step 6 Gateway: Simulated payment (Cards, Online Bank, GCash/Maya)
│
├── 🛡️ Administration Module
│   └── AdminPanel.vb            # Fleet inventory, customer records, flight crew, schedule management
│
└── ⚙️ Core Engine & Data Access
    ├── CustomMessageBox.vb      # Universal themed notification & input dialog
    └── ModDatabase.vb           # MySQL data layer, schema auto-migrator, offline fallback, pricing engine
```

---

## 🌟 Key Features & Highlights

### 1. Dual-Role Authentication & Live Synchronization
- **Customer Sign-Up & Sign-In:** Automatically generates unique Customer IDs (`CUST-XXXXXX`) and prevents duplicate usernames against the live MySQL database.
- **In-Textbox Eye Password Toggle:** Built-in vector icons in password fields allow easy inspection to prevent typing errors.
- **Persistent Sessions:** Full reload on startup prevents data loss across application restarts.

### 2. Comprehensive 6-Step Flight Booking Engine
- **Domestic & Asian Routes:** Pre-scheduled direct flights covering Manila, Cebu, Davao, Boracay, Iloilo, Puerto Princesa, Bacolod, Tokyo, Singapore, Bangkok, Seoul, Hong Kong, Taipei, Kuala Lumpur, Osaka, and Bali.
- **Dynamic Cabin Class Calculation:** Business Class applies a 1.8× base fare multiplier and locks the seat selection to premium front rows (Rows 1–2 in Coral), while Economy locks to Rows 3–6 (in Teal).
- **Mandatory Senior & PWD Concessions (RA 9994 & RA 10754):** Automatically verifies age $\ge 60$ or PWD status and grants a 20% discount on base fares (capped at 20% per airline guidelines if both apply).
- **Structured Baggage Allowance:**
  - Carry-on: 7kg Free Included.
  - Checked Tiers: 10kg (+₱1,000), 20kg (+₱1,800), 40kg (+₱3,000).
- **Flexible Fare Protection:** Optional +₱500 flexible cancellation insurance allowing a 100% base fare refund if cancelled at least 24 hours prior to departure.

### 3. Customer Profile Self-Management & Booking Control
- **Edit Profile ✎:** Customers can directly update their Given Name, Surname, and Contact Number with instant live synchronization to MySQL.
- **One Active Booking Enforcement:** Restricts passengers to one active confirmed flight at a time to prevent accidental double-booking.
- **Real-Time Booking Cancellation & Refund Request:** Cancelling updates the ticket status to `"Cancelled"` in MySQL and frees the account for rebooking.
- **Digital Boarding Pass:** Displays a crisp, authentic boarding pass with seat, gate, terminal, route, and INOM Air branding.

### 4. Robust Administrative Hub
- **Aircraft Fleet Inventory:** Search, filter by status, and register new planes with capacity tracking.
- **Customer Records:** Real-time search by Customer ID or Name with full passenger profiles.
- **Pilot & Flight Crew Management:** Track active duty, standby, and leave statuses; assign captains to specific flights.
- **Flight Schedules:** Add new flights and modify departure/arrival times and fares.

---

## 🗄️ Database Schema & Integration

The system uses **MySQL (InnoDB, `utf8mb4`)** running on `localhost:3306` with the database name `inomairtest_db`. If MySQL is offline, the system safely operates in **Offline Fallback Mode** using local memory structures.

### Database Tables:
1. **`users`**: Customer and administrator credentials, unique customer ID (`CUST-XXXXXX`), personal info, DOB, contact, role, and Senior/PWD flags.
2. **`aircrafts`**: Fleet aircraft ID (`P001`), model name, seat capacity, and operational status.
3. **`pilots`**: Pilot ID (`PT001`), full name, assigned flight, and duty status (`On Duty`, `Standby`, `On Leave`).
4. **`flights`**: Flight ID (`F001`), origin, destination, date, departure/arrival times, duration, flight type (`Direct Flight`), base fare, and aircraft model.
5. **`bookings`**: Unique ticket number (`INOM-XXXXXXXX`), passenger name, cabin class, seat assignment, gate, baggage weight, meal plan, refund protection, discounts, taxes, and status (`Confirmed`, `Cancelled`, `Completed`).

---

## 🚀 Getting Started & Installation

### Prerequisites
- **Operating System:** Windows 10 / 11
- **Development Tool:** Visual Studio 2022 / 2026 or .NET 10 SDK
- **Database Server:** XAMPP (Apache + MySQL)

### Step-by-Step Setup
1. **Clone the Repository:**
   ```bash
   git clone https://github.com/Lowace/INOM_Air.git
   cd INOM_Air
   ```
2. **Start MySQL Server:**
   - Open **XAMPP Control Panel**.
   - Start the **MySQL** module (default port: `3306`).
   - *(Optional)* Import `inomairtest_db.sql` via phpMyAdmin, or allow the application to automatically initialize tables and seed data upon first run.
3. **Build and Run:**
   - Open `INOM_Air.sln` in **Visual Studio**.
   - Ensure the build configuration is set to `Debug` or `Release` for `net10.0-windows`.
   - Press **F5** or run via command line:
     ```bash
     dotnet run -c Debug
     ```

---

## 🔑 Demo Credentials

| Role | Username | Password | Notes |
| :--- | :--- | :--- | :--- |
| **Administrator** | `admin` | `admin123` | Full access to fleet, customer, crew, and schedule management. |
| **Customer** | `Naruto` | `password` | Pre-configured customer profile with demo confirmed booking. |

*You can also click **"Signup"** on the startup page to register your own custom customer account.*

---

## 📋 Project Scopes & Limitations

In accordance with the **Tarlac State University (TSU) CCS Case Study**:

### Scopes Covered:
- Full Visual Basic .NET Windows Forms implementation.
- Dual-role authentication for Customers and Admins/Staff.
- Flight scheduling across the Philippines and Asian regional destinations.
- Reservation creation, rebooking, and refund cancellations.
- Strict direct flights enforcement.
- Automated Senior Citizen (60+) and PWD concession discounts (20%).
- Customer self-management (Profile view and profile editing).

### Documented System Limitations:
- **Language:** English only interface.
- **Currency:** Philippine Peso (`PHP` / `₱`) only.
- **Email Notifications:** Excluded; all confirmations are displayed on-screen.
- **Simultaneous Bookings:** Strictly limited to 1 active scheduled flight per customer account.
- **Seat Mapping:** Basic conceptual seat arrangement (Rows 1–6) rather than complex 3D fuselage layouts.
- **Payment Processing:** Realistic UI payment simulation (Cards, Online Banking, GCash/Maya); no real monetary transactions.
- **File Export:** Boarding pass displayed interactively; PDF file export is excluded per scope.
- **Barcodes / QR Readers:** Excluded; official airline logo used instead.

---

<p align="center">
  Developed & Designed with ❤️ by <strong>Luis Antonio Magdangal</strong><br/>
  <strong>College of Computer Studies • Tarlac State University</strong>
</p>
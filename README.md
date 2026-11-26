# DS_Team — Starter Project (Cinema Ticket Booking System)

نسخة البداية للفريق (**Starter Template**): جميع الشاشات والتصميمات داخل مجلد `Forms/` (ملفات `.Designer.cs` و `.resx`) مضبوطة وجاهزة كما هي، بينما ملفات الكود في `Models/` و `DataStructures/` و `Services/` وملفات `.cs` للفورم فارغة وجاهزة لكتابة اللوجيك الخاص بكل تاسك.

## هيكل المجلد

```text
DS_Team/
├── DSA Project.sln
├── Fix-BuildErrors.bat
├── README.md
└── DSA Project/
    ├── Program.cs
    ├── App.config
    ├── DSA Project.csproj
    ├── Properties/
    ├── Models/           # كلاسات فارغة جاهزة للتنفيذ (Booking, Customer, Movie, Seat, Showtime)
    ├── DataStructures/   # هياكل بيانات فارغة (MovieDictionary, MovieBST, SeatArray, UndoStack, BookingQueue, BookingHistoryList)
    ├── Services/         # خدمات فارغة (AuthenticationService, MovieService, SeatService, BookingService, TicketService)
    └── Forms/            # التصميمات كاملة (.Designer.cs + .resx) + دوال Event Handlers جاهزة للوجيك داخل .cs
```

## التشغيل

1. افتح `DS_Team/DSA Project.sln` في Visual Studio على Windows.
2. المشروع يبني (`Build`) مباشرةً بدون أخطاء ويشغّل شاشة `Welcome`.
3. لو ظهرت مشكلة "mark of the web" على ملفات `.resx` بعد تحميل المشروع كـ `.zip`، شغّل `Fix-BuildErrors.bat` داخل مجلد `DS_Team`.
4. راجع أوراق التاسكات داخل `DSA Project/Docs/` لتنفيذ المهام وتوزيع الملفات على أعضاء الفريق.

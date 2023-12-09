# Home_library

# Overview and Configuration
The "Home Library" web application is designed to simplify managing home book collections. It features book cataloging by category, tracking of lending history, and user preference-based title recommendations (with an option for 3 random recommendations based on chosen genre and rating). The app aims to offer an intuitive and user-friendly interface for easy book management and is expected to handle libraries with 30 to 50 titles.

# System Architecture and Configuration
Built on .NET Framework 4.8.0, the app ensures wide compatibility with modern Windows environments. User management is powered by ASP.NET Identity, providing robust authentication and secure password storage. It employs the ASP.NET MVC architecture, promoting clear separation between application logic and UI, and uses Entity Framework for efficient database interaction. Development is supported by Microsoft Visual Studio Community 2022, chosen for its comprehensive design, debugging, and profiling tools for ASP.NET applications.

# User Roles and Functionalities
The app supports two user roles: Administrator and User. Administrators have full system control, including CRUD operations and user account management. Users can browse books, manage their loans, and add reviews and ratings. The app focuses on essential library functions, with user-friendly views at its core and robust protection against XSS and SQL Injection attacks for data and system security.

# Installation Requirements and Deployment
Requires a .NET environment (preferably version 6.0 or higher), Visual Studio with ASP.NET web application development options, and specific NuGet packages for Entity Framework and Microsoft Identity functionalities.

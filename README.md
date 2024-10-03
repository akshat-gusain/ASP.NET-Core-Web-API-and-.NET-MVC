# ASP.NET Core Web API and ASP.NET MVC Solution

This solution contains two independent projects: an **ASP.NET Core Web API** and an **ASP.NET MVC** application. Both projects are organized under a single solution for ease of management but operate separately.

## Table of Contents

- [Solution Structure](#solution-structure)
- [ASP.NET MVC Project](#aspnet-mvc-project)
- [API Project](#api-project)
- [Setup Instructions](#setup-instructions)
- [Usage](#usage)
- [License](#license)

---

## Solution Structure


- **AspNetCoreApi**: This directory contains the project files for your Web API, including controllers, models, and related files.
- **AspNetMvcApp**: This directory contains the ASP.NET MVC project, which includes controllers, views, models, and other related files.
- **dotnet-rest-api-with-sql.sln**: The solution file that encompasses both projects under the same umbrella for easier management.

## ASP.NET MVC Project

### Purpose
This project is a standalone web application that follows the **ASP.NET MVC** pattern. It handles user interactions through web pages and renders views (HTML pages).

### Main Features
- **MVC Architecture**: Implements the Model-View-Controller pattern to separate application logic, user interface, and data.
- **Routing**: Defines a default route for MVC at `{controller=Home}/{action=Index}/{id?}`. The `HomeController` serves the home page by default.
- **Static Files**: Serves static content like CSS, JavaScript, and images using `app.UseStaticFiles()`.

### Standalone Nature
This project operates independently and does not directly consume or rely on the API project. It can utilize internal models or services to handle data or connect to external databases or APIs.

## API Project

### Purpose
This project is a separate **RESTful API** designed to handle HTTP requests, including GET, POST, PUT, and DELETE operations. It functions solely as an API service, responding with data in formats like JSON.

### Main Features
- **API Controllers**: Configured to respond to API requests using `services.AddControllers()`. There are no views or user-facing pages.
- **Routing**: API endpoints are defined with `endpoints.MapControllers()`, exposing data and operations based on incoming requests.

### Standalone Nature
The API project operates independently and can be consumed by other applications or systems, including web and mobile apps, but does not interact directly with the ASP.NET MVC project.

## Setup Instructions

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/akshat-gusain/ASP.NET-Core-Web-API-and-.NET-MVC.git




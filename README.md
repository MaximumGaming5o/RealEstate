# Real Estate Listing Website

## Project Overview

This Real Estate Listing Website is a comprehensive platform designed for buying, selling, and managing real estate properties online. Built with ASP.NET, .NET Core, Razor Pages, and C#, this project integrates modern web development frameworks to ensure scalability, security, and performance.

## Features

- User-friendly property listings
- Advanced search and filtering options
- Subscription-based membership benefits
- Secure payment systems
- Admin dashboard for effective management

## Technology Stack

- **Frontend**: ASP.NET, Razor Pages, HTML, CSS
- **Backend**: .NET Core, C#
- **Database**: MongoDB
- **Authentication**: Secure login mechanisms
- **Payment Processing**: Integration with secure payment gateways

## Project Structure

The project follows a three-tier architecture:

1. **Presentation Layer**: Built using ASP.NET, Razor Pages, and HTML/CSS
2. **Application Layer**: Implemented with .NET Core and C#
3. **Data Layer**: MongoDB for flexible and scalable data storage

## Current Progress

- Backend implementation with MongoDB integration
- User management system
- Property listing management
- DataService class for database operations
- Basic testing and validation

## Installation

1. Clone the repository
2. Install the required dependencies
3. Set up MongoDB connection string in the `DataService` class
4. Run the application

## Usage

```csharp
// Example of initializing the DataService
var dataService = new DataService();
dataService.PingDatabase();
dataService.InitUserSystem();
```

## Future Enhancements

- Frontend integration
- Virtual tour functionality
- Advanced search features
- Real-time notifications
- Comprehensive security measures

## Contributors

- Florian Kasperbauer (991681092)
- Adam Zyluk (991646407)


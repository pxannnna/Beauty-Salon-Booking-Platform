# Steelworks Salon Booking Platform

A comprehensive salon management system built with Visual Basic .NET that provides booking functionality, user management, and administrative features for a beauty salon.

## 🏢 About

Steelworks Salon Booking Platform is a desktop application designed to streamline salon operations by providing:

- **User Authentication** - Secure login system for customers, staff, and administrators
- **Booking Management** - Schedule and manage appointments
- **Customer Management** - Maintain customer profiles and booking history
- **Staff Management** - Manage staff schedules and personal details
- **Administrative Controls** - Comprehensive admin panel for system management

## 🚀 Features

### Customer Features
- User account creation and login
- Appointment booking
- Booking history viewing
- Personal profile management

### Staff Features
- Staff login and authentication
- Customer service management
- Booking management
- Personal details management

### Administrative Features
- Complete system administration
- User management (customers and staff)
- Booking oversight
- System configuration
- Staff shift management
- Procedure details management

## 🛠️ Technology Stack

- **Language**: Visual Basic .NET
- **Framework**: .NET Framework
- **Database**: Microsoft Access Database (.accdb)
- **UI**: Windows Forms
- **Architecture**: Desktop Application

## 📁 Project Structure

```
steelworkssalon/
├── Forms/
│   ├── Login.vb                    # User authentication
│   ├── CreateAccount.vb           # New user registration
│   ├── Booking.vb                 # Appointment booking
│   ├── BookingHistory.vb          # View booking history
│   ├── Mainmenuadmin.vb           # Admin dashboard
│   ├── mainmenucustomer.vb        # Customer dashboard
│   ├── mainmenustaff.vb           # Staff dashboard
│   ├── PersonalDetailsCustomers.vb # Customer profile management
│   ├── PersonalDetailsStaff.vb    # Staff profile management
│   ├── UsersDetails.vb            # User management
│   ├── ProceduresDetails.vb       # Service management
│   ├── ShiftsTimetable.vb         # Schedule management
│   └── Password.vb                # Password management
├── Database/
│   ├── DatabaseCon.vb             # Database connection handler
│   └── Users.accdb               # Microsoft Access database
├── Resources/
│   ├── Images/                   # Application images and logos
│   └── Icons/                    # UI icons
└── Configuration/
    ├── App.config               # Application configuration
    └── Module.vb                # Global application module
```

## 🗄️ Database Schema

The application uses Microsoft Access database with the following key tables:

- **Users** - User authentication and profile information
- **Bookings** - Appointment scheduling data
- **Customers** - Customer profile information
- **Staff** - Staff member details and schedules
- **Procedures** - Available salon services
- **Shifts** - Staff working schedules

## 🚀 Getting Started

### Prerequisites

- Windows Operating System
- .NET Framework 4.0 or higher
- Microsoft Access Database Engine
- Visual Studio (for development)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/pxannnna/Beauty-Salon-Booking-Platform.git
   cd Beauty-Salon-Booking-Platform
   ```

2. **Open the project**
   - Open `steelworkssalon.sln` in Visual Studio
   - Restore NuGet packages if prompted

3. **Database Setup**
   - Ensure `Users.accdb` is in the correct location
   - Update connection string in `DatabaseCon.vb` if needed

4. **Build and Run**
   - Build the solution (Ctrl+Shift+B)
   - Run the application (F5)

### Default Login Credentials

The application includes default accounts for testing:

- **Admin**: Contact system administrator for credentials
- **Staff**: Contact system administrator for credentials
- **Customer**: Create new account through registration

## 📱 Usage

### For Customers
1. Launch the application
2. Click "Create Account" to register
3. Login with your credentials
4. Navigate to "Book Appointment" to schedule services
5. View your booking history in "Booking History"

### For Staff
1. Login with staff credentials
2. Access customer management tools
3. View and manage bookings
4. Update personal details as needed

### For Administrators
1. Login with admin credentials
2. Access comprehensive admin panel
3. Manage users, bookings, and system settings
4. Configure procedures and staff schedules

## 🔧 Configuration

### Database Connection
Update the connection string in `DatabaseCon.vb`:

```vb
Public Const CONNECTION_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=path\to\Users.accdb"
```

### Application Settings
Modify `App.config` for application-specific settings:

```xml
<configuration>
  <appSettings>
    <add key="DatabasePath" value="path\to\database" />
  </appSettings>
</configuration>
```

## 🧪 Testing

The application includes comprehensive testing capabilities:

- User authentication testing
- Booking functionality validation
- Database connection testing
- UI component testing

## 📝 Development

### Adding New Features

1. Create new forms in Visual Studio
2. Update database schema if needed
3. Implement business logic
4. Test thoroughly
5. Update documentation

### Code Style Guidelines

- Use meaningful variable and function names
- Include comments for complex logic
- Follow VB.NET naming conventions
- Maintain consistent indentation

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👥 Authors

- **Anna Petrusenko** - *Initial work* - [pxannnna](https://github.com/pxannnna)

## 🙏 Acknowledgments

- Thanks to the Visual Basic .NET community
- Microsoft Access database documentation
- Windows Forms development resources

## 📞 Support

For support and questions:

- Create an issue in this repository
- Contact the development team
- Check the documentation for common solutions

## 🔄 Version History

- **v1.0.0** - Initial release with core functionality
  - User authentication system
  - Booking management
  - Customer and staff management
  - Administrative controls

---

**Note**: This application is designed for educational and small business use. For production environments, consider additional security measures and database optimization.

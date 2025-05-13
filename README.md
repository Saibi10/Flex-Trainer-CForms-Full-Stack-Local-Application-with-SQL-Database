# Flex Trainer - Gym Management System

## Overview
Flex Trainer is a comprehensive gym management system designed to streamline operations for gyms, fitness centers, and personal training businesses. It provides a platform for gym owners, trainers, members, and administrators to manage various aspects of gym operations efficiently.

## Features

### User Types
The system supports four types of users, each with different roles and permissions:

1. **Admin**
   - System administration
   - User management
   - Overall system monitoring

2. **Gym Owner**
   - Gym registration and setup
   - Member management
   - Trainer recruitment and management
   - Performance monitoring and reporting
   - Handling trainer requests

3. **Trainer**
   - Creating and managing workout plans
   - Creating and managing diet plans
   - Managing appointments with members
   - Receiving and reviewing feedback
   - Tracking member progress

4. **Member**
   - Registration and profile management
   - Gym membership management
   - Subscribing to workout and diet plans
   - Scheduling appointments with trainers
   - Providing feedback to trainers
   - Tracking personal fitness journey
   - Submitting requests to become a trainer or gym owner

### Workout and Diet Plan Management
- Creation and customization of workout plans with exercises, sets, reps, and target muscles
- Creation and customization of diet plans with meals, nutritional information, and dietary guidelines
- Plan subscription system for members
- Ability to view and track progress

### Membership Management
- Different membership durations
- Gym-specific pricing
- Membership tracking and renewal notifications

### Appointment System
- Scheduling appointments between trainers and members
- Appointment tracking and management
- Date modification and cancellation

### Feedback System
- Member feedback for trainers
- Rating system
- Detailed feedback comments

### Request System
- Members can request to become trainers
- Members can request to become gym owners
- Approval workflow for administrators and gym owners

## Technical Details

### Architecture
- Windows Forms application built on .NET Framework 4.7.2
- SQL Server database for data storage
- Object-oriented design with clear separation of UI and business logic

### Database Structure
Key tables in the database:
- `account`: Stores user authentication details
- `member`: Member information
- `admin`: Admin information
- `gym_owner`: Gym owner information
- `gym`: Gym details
- `trainer`: Trainer information
- `feedback`: Feedback records
- `appointment`: Appointment scheduling
- `membership`: Membership information
- `diet_plan`: Diet plan details
- `workout_plan`: Workout plan details
- `meals`: Meal information for diet plans
- `exercise`: Exercise details for workout plans
- Various request and review tables

### UI Components
- Login and registration interface
- Dashboard for each user type
- Plan creation and management interfaces
- Appointment scheduling interface
- Feedback and rating interface
- Profile management
- Reports and analytics views

### Dependencies
- Guna.UI2.WinForms: Modern UI components for Windows Forms
- System.Data.SqlClient: SQL Server connectivity
- Other standard .NET Framework libraries

## Getting Started

### Prerequisites
- Windows operating system
- .NET Framework 4.7.2 or higher
- SQL Server (Express or higher)
- Visual Studio (for development)

### Database Setup
1. Create a new SQL Server database named `flex_trainer`
2. Run the SQL scripts in the following order:
   - `SQL_Queries/create_table.sql` (creates the database schema)
   - `SQL_Queries/insert_data.sql` (populates initial data)

### Configuration
Modify the connection string in the `Classes/DB_Access.cs` file to match your SQL Server configuration:

```csharp
public string ConnectionString = "Data Source=YOUR_SERVER;Initial Catalog=flex_trainer;Integrated Security=True;Encrypt=False";
```

### Running the Application
1. Open the solution in Visual Studio
2. Build the solution
3. Run the application
4. Use the login form to access the system with appropriate credentials

## Usage Scenarios

### For Members
1. Register a new account
2. Browse available gyms and membership options
3. Subscribe to a gym membership
4. Explore workout and diet plans
5. Schedule appointments with trainers
6. Track progress and provide feedback

### For Trainers
1. Login with trainer credentials
2. Manage client appointments
3. Create and customize workout/diet plans
4. Review member feedback
5. Track member progress

### For Gym Owners
1. Login with owner credentials
2. Manage gym information and pricing
3. Review and approve trainer applications
4. Monitor gym performance
5. Manage trainers and members

### For Administrators
1. Login with admin credentials
2. Manage all users
3. System-wide monitoring and maintenance
4. Approve gym owner requests

## Project Structure
- `Form1.cs`: Main login and registration form
- `Admin.cs`: Admin interface
- `Member.cs`: Member interface
- `TrainerGYM.cs`: Trainer interface
- `OwnerGYM.cs`: Gym owner interface
- `Classes/DB_Access.cs`: Database connectivity
- `Divs/`: User controls for various UI components
- `SQL_Queries/`: SQL scripts for database setup

## Security
- Password-based authentication
- Role-based access control
- Data validation and sanitization to prevent SQL injection

## Future Enhancements
- Mobile application integration
- Payment gateway integration
- Advanced analytics and reporting
- Biometric integration
- Automated notifications
- Inventory management for gym equipment

## Contributors
- Initial development team members

## License
- Proprietary software for educational purposes

---

*Note: This project was developed as part of a database course and serves as a demonstration of database design, implementation, and integration with a Windows Forms application.* 
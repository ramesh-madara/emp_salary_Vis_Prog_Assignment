# Employee Payroll Management System

A comprehensive Windows Forms application for managing employee payroll, attendance tracking, and generating payroll reports. Built with C# and Material Design UI.

## 📋 Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Database Setup](#database-setup)
- [Project Structure](#project-structure)
- [Usage](#usage)
- [Technologies Used](#technologies-used)
- [Screenshots](#screenshots)
- [Contributing](#contributing)

## ✨ Features

### 1. Employee Management
- **CRUD Operations**: Create, Read, Update, and Delete employee records
- **Employee Information**:
  - Name
  - Join Date
  - Basic Salary
  - Service Charge Percentage
  - Overtime (OT) Rate
  - Employee Photo
- **Image Management**: Upload and store employee photos locally
- **Data Validation**: Input validation for numeric fields with constraints

### 2. Attendance Tracking
- **Date-based Attendance**: View and manage attendance for any selected date
- **Time Tracking**: Record in-time, out-time, and work hours
- **Employee Status**: Mark employees as present or absent
- **Dynamic Interface**: Automatically loads all employees with their attendance status

### 3. Daily Totals Management
- **Service Charge Entry**: Record daily service charge amounts
- **Tip Management**: Track daily tip amounts
- **Date-based Records**: Maintain separate totals for each date
- **Auto-save**: MERGE operations for efficient insert/update

### 4. Payroll Reports
- **Monthly Payroll Generation**: Generate payroll reports for any month
- **Employee Selection**: Generate reports for individual employees or all employees
- **Automatic Calculations**:
  - Basic Salary
  - Service Share (based on service charge percentage)
  - Tip Share
  - Hours Deductions (for incomplete work hours)
  - Gross Pay
  - Net Pay
- **PDF Export**: Export payroll reports to PDF format

## 🔧 Prerequisites

Before running this application, ensure you have the following installed:

- **.NET Framework 4.7.2** or higher
- **Visual Studio 2017** or later (for development)
- **SQL Server Express** or SQL Server (with SQL Server Management Studio)
- **Windows OS** (Windows 7 or later)

## 📦 Installation

1. **Clone the repository**:
   ```bash
   git clone <repository-url>
   cd Assignment
   ```

2. **Restore NuGet packages**:
   - Open the solution in Visual Studio
   - Right-click on the solution and select "Restore NuGet Packages"
   - Or use Package Manager Console: `Update-Package -reinstall`

3. **Build the solution**:
   - Press `Ctrl+Shift+B` or go to `Build > Build Solution`

## 🗄️ Database Setup

1. **Create the Database**:
   - Open SQL Server Management Studio (SSMS)
   - Connect to your SQL Server instance (default: `localhost\SQLEXPRESS`)
   - Create a new database named `EmployeePayrollDB`

2. **Create Required Tables**:
   
   ```sql
   -- Employee Table
   CREATE TABLE employee (
       empID INT PRIMARY KEY IDENTITY(1,1),
       empName NVARCHAR(100) NOT NULL,
       joinDate DATE NOT NULL,
       basicSalary DECIMAL(18,2) NOT NULL,
       serviceChargeTipPercentage DECIMAL(5,2) NOT NULL,
       otRate DECIMAL(18,2) NOT NULL,
       empPicturePath NVARCHAR(500)
   );

   -- Attendance Table
   CREATE TABLE employee (
    empID INT PRIMARY KEY IDENTITY(1,1),
    empName NVARCHAR(150) NOT NULL,
    joinDate DATE NOT NULL,
    basicSalary DECIMAL(10, 2) NOT NULL,
    serviceChargeTipPercentage DECIMAL(5, 2) NOT NULL,
    otRate DECIMAL(10, 2) NOT NULL,
    empPicturePath NVARCHAR(260) NULL
   );

   -- Service Charge Table
   CREATE TABLE serviceCharge (
    [date] DATE PRIMARY KEY,
    serviceCharge DECIMAL(10, 2) NOT NULL
   );

   -- Tip Table
   CREATE TABLE tip (
    [date] DATE PRIMARY KEY,
    tipAmount DECIMAL(10, 2) NOT NULL
   );
   -- Attendance Table
   CREATE TABLE empAttendance (-
    empID INT NOT NULL,
    [date] DATE NOT NULL,
    inTime TIME NULL,
    outTime TIME NULL,
    workHours DECIMAL(4, 2) NULL,

    -- Composite primary key (one entry per employee per day)
    CONSTRAINT PK_empAttendance PRIMARY KEY (empID, [date]),

    -- Foreign key to link to the employee table
    CONSTRAINT FK_empAttendance_employee FOREIGN KEY (empID)
        REFERENCES employee(empID)
        ON DELETE CASCADE
   );
   ```

3. **Update Connection String** (if needed):
   - Open `Assignment/DBConnector.cs`
   - Modify the connection string if your SQL Server instance differs:
   ```csharp
   private const string connectionString =
       @"Data Source=localhost\SQLEXPRESS;Initial Catalog=EmployeePayrollDB;Integrated Security=True;Trust Server Certificate=True";
   ```

## 📁 Project Structure

```
Assignment/
├── Assignment/
│   ├── Form1.cs                    # Main application form
│   ├── Program.cs                  # Application entry point
│   ├── DBConnector.cs              # Database connection manager
│   ├── PayrollReport.cs            # Payroll report data model
│   │
│   ├── ucEmployee.cs               # Employee management module
│   ├── ucAttendance.cs             # Attendance tracking module
│   ├── ucDailyTotals.cs            # Daily totals management module
│   ├── ucPayroll.cs                # Payroll reports module
│   │
│   ├── ucAttendanceRow.cs          # Attendance row control
│   ├── ucPayrollRow.cs             # Payroll row control
│   │
│   ├── EmployeePayrollDBDataSet.*  # Typed dataset files
│   └── Properties/                 # Application properties
│
├── packages/                       # NuGet packages
└── Assignment.sln                  # Solution file
```

## 🚀 Usage

### Running the Application

1. **Start the Application**:
   - Press `F5` in Visual Studio, or
   - Navigate to `bin/Debug/Assignment.exe` and double-click

2. **Main Interface**:
   The application opens with a tabbed interface containing four main sections:
   - **Attendance**: Track daily employee attendance
   - **Employees**: Manage employee information
   - **Daily Totals**: Record service charges and tips
   - **Reports**: Generate and export payroll reports

### Employee Management

1. Navigate to the **Employees** tab
2. Click **Add New** to create a new employee
3. Fill in employee details:
   - Name (required)
   - Join Date
   - Basic Salary (required, numbers only)
   - Service Charge % (0-100)
   - OT Rate (numbers only)
   - Upload employee photo (optional)
4. Click **Save** to store the employee
5. Select an employee from the grid to edit or delete

### Attendance Tracking

1. Navigate to the **Attendance** tab
2. Select a date using the date picker
3. For each employee:
   - Mark as present/absent
   - Enter in-time and out-time
   - Work hours are automatically calculated
4. Changes are saved automatically

### Daily Totals

1. Navigate to the **Daily Totals** tab
2. Select a date
3. Enter Service Charge amount (decimal values allowed)
4. Enter Tip Amount (decimal values allowed)
5. Click **Save Totals** to store the values

### Payroll Reports

1. Navigate to the **Reports** tab
2. Select a month using the month picker
3. Choose an employee from the dropdown (or select "[All Employees]")
4. Click **Generate** to calculate payroll
5. Review the generated report
6. Click **Export PDF** to save the report as a PDF file

## 🛠️ Technologies Used

- **.NET Framework 4.7.2**
- **C#** (Windows Forms)
- **MaterialSkin 2.3.1** - Modern Material Design UI
- **PDFsharp-GDI 6.2.2** - PDF generation
- **SQL Server** - Database
- **Microsoft.Extensions.* 8.0.x** - Dependency injection and logging

## 📸 Screenshots

![Screenshot 1](https://raw.githubusercontent.com/ramesh-madara/emp_salary_Vis_Prog_Assignment/main/readMeImgs/Screenshot%202025-11-09%20004645.png)

![Screenshot 2](https://raw.githubusercontent.com/ramesh-madara/emp_salary_Vis_Prog_Assignment/main/readMeImgs/Screenshot%202025-11-09%20004744.png)

![Screenshot 3](https://raw.githubusercontent.com/ramesh-madara/emp_salary_Vis_Prog_Assignment/main/readMeImgs/Screenshot%202025-11-09%20004828.png)

![Screenshot 4](https://raw.githubusercontent.com/ramesh-madara/emp_salary_Vis_Prog_Assignment/main/readMeImgs/Screenshot%202025-11-09%200048h28.png)

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📝 License

This project is part of a Visual Programming assignment.

## 👤 Author

Developed as part of Visual Programming I course group assignment.

**Group Members:**
- Member 1 - Student Number: XXXXXX
- Member 2 - Student Number: XXXXXX
- Member 3 - Student Number: XXXXXX
- Member 4 - Student Number: XXXXXX
- Member 5 - Student Number: XXXXXX


## 📞 Support

For issues or questions, please open an issue in the repository.

---

**Note**: Make sure SQL Server is running and the database is properly configured before running the application. The application will display error messages if it cannot connect to the database.


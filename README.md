"# ASP.NetCore_Student" 

# Student Management System

This is a **Student Management System** built using ASP.NET Core and Entity Framework Core. It provides a web-based interface for managing student records, including adding, editing, listing, and viewing student details.

## Features

1. **Add New Student**:
   - Users can add new student records with details like name, department, and session.

2. **View All Students**:
   - Displays a table with all student records, including their ID, name, department, and session.

3. **Edit Student Details**:
   - Allows users to update existing student records using the `Edit` feature.

4. **Responsive Design**:
   - Built with Bootstrap for a responsive user interface.

5. **Entity Framework Integration**:
   - Uses Entity Framework Core for database operations.

---

## Project Structure

```plaintext
Studentinfo/
├── Controllers/
│   └── AdminStudentController.cs
├── Models/
│   ├── Domain/
│   │   └── Student.cs
│   └── ViewModel/
│       ├── AddStudentRequest.cs
│       └── EditStudentRequest.cs
├── Data/
│   └── StudentDbcontext.cs
├── Views/
│   ├── AdminStudent/
│   │   ├── Add.cshtml
│   │   ├── Edit.cshtml
│   │   └── List.cshtml
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
└── appsettings.json
```

---

## Installation

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/) or any IDE with ASP.NET Core support

### Steps

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repository.git
   cd your-repository
   ```

2. Update the database connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
       "StudentDbConnectionString": "Server=YOUR_SERVER_NAME;Database=StudentDb;Trusted_Connection=True;TrustServerCertificate=Yes;"
   }
   ```

3. Apply migrations and update the database:
   ```bash
   dotnet ef database update
   ```

4. Run the project:
   ```bash
   dotnet run
   ```

5. Open your browser and navigate to `https://localhost:7244/`.

---

---

## Technologies Used

- **ASP.NET Core** for backend development
- **Entity Framework Core** for ORM and database interaction
- **Bootstrap** for responsive design
- **SQL Server** as the database

---

## How It Works

1. **Add Student**:
   - Navigate to the "Add Student" page via the dropdown menu.
   - Fill in the form and submit to add a new record to the database.

2. **View Students**:
   - The "View Students" page displays a list of all students in a table.

3. **Edit Student**:
   - Click the "Edit" button on a specific student record to update their details.

---

## Contributing

Contributions are welcome! Feel free to fork the repository and submit a pull request.

---

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

---

## Contact

If you have any questions or issues, feel free to contact me at `your-email@example.com`.


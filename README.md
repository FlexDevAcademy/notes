# Notes Application

This project is the final assignment for FlexDevAcademy, developed collaboratively by course participants. The application is designed to manage and organize notes efficiently.

## Features

- **Create Notes:** Add new notes with titles and content.
- **Edit Notes:** Modify existing notes.
- **Delete Notes:** Remove notes that are no longer needed.
- **Search Functionality:** Search through notes by keywords.
- **User Authentication:** Secure login and registration system.

## Technologies Used

- **Backend:**
  - C# with ASP.NET Core
  - Entity Framework Core
  - RESTful API design

- **Frontend:**
  - HTML5
  - CSS3
  - JavaScript

## Project Structure
notes/ <br>
├── Controllers/ <br>
│ ├── NotesController.cs <br>
│ └── AccountController.cs <br>
├── Models/ <br>
│├── Note.cs <br>
│└── User.cs <br>
├── Views/ <br>
│ ├── Notes/ <br>
│ └── Account/ <br>
├── wwwroot/ <br>
│ ├── css/ <br>
│ ├── js/ <br>
│ └── images/ <br>
├── Data/ <br>
│ ├── ApplicationDbContext.cs <br>
│ └── Migrations/ <br>
├── Services/ <br>
│ └── NoteService.cs <br>
├── ViewModels/ <br>
│ ├── NoteViewModel.cs <br>
│ └── UserViewModel.cs <br>
├── Program.cs <br>
├── Startup.cs <br>
└── notes.sln<br>

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [SQLite](https://www.sqlite.org/download.html)

### Installation

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/FlexDevAcademy/notes.git
   cd notes
   ```
2. **Set Up the Database:**

Update the connection string in appsettings.json to point to your database.

Apply migrations to set up the database schema:

  ```bash
  dotnet ef database update
  ```

Run the Application:
  ```bash
  dotnet run
  ```

The application will be accessible at ```http://localhost:5000.```

### Usage
Register: Create a new user account.<br>
Login: Access your account.<br>
Create Note: Add a new note.<br>
Edit Note: Update an existing note.<br>
Delete Note: Remove a note.<br>
Search Notes: Use the search bar to find notes by title or content.<br>


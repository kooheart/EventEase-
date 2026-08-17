# EventEase

EventEase is a Blazor Web App built with .NET 9 and Microsoft Copilot.

## Features

- Event Card component with reusable fields and two-way binding
- Event search and filtering
- Blazor routing
- Registration form with DataAnnotations validation
- User session state management
- Attendance Tracker
- Responsive UI
- Performance-conscious rendering using filtered in-memory collections

## Run locally

1. Install the .NET 9 SDK.
2. Open `EventEase.csproj` in Visual Studio 2022 or run:
   ```bash
   dotnet restore
   dotnet run
   ```
3. Open the HTTPS URL shown in the terminal.

## Project structure

- `Components/Pages` - application pages
- `Components/Shared` - reusable components
- `Models` - application models
- `Services` - event and session state services
- `wwwroot/app.css` - application styling

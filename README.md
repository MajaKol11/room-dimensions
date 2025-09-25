# Room Calculator (Blazor WebAssembly, .NET 8)

A simple Blazor WebAssembly app that calculates **area**, **perimeter**, and **volume** of a room based on user-provided dimensions (length, breadth, height).

---

## Features
- Built with **Blazor WebAssembly** (.NET 8).
- User inputs length, breadth, and height through a form.
- Real-time validation using **Data Annotations** (values must be positive).
- Calculates:
  - **Area** (m²)
  - **Perimeter** (m)
  - **Volume** (m³)
- Clean form layout and result display.

---

## Project Structure
```bash
RoomCalculator/
    Layout/
        MainLayout.razor/
            MainLayout.razor.css
        NavMenu.razor/
            NavMenu.razor.css
    Models/
        Room.cs
        RoomDimensions.cs
        RoomResult.cs
    Services/
        IRoomCalculator.cs
        RoomCalculator.cs
    Pages/
        RoomPage.razor
    wwwroot/
        css/
            app.css
    Program.cs
    README.md
```

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)  
- [Node.js](https://nodejs.org/) (optional, only if you add frontend tooling)  
- [Git](https://git-scm.com/)  

### Clone the repository
```bash
git clone https://github.com/MajaKol11/RoomCalculator.git
cd RoomCalculator
```

### Run The App
```bash
dotnet watch
```
Then open the URL shown in the console (usually http://localhost:5000 or http://localhost:5173)

## Example

**Input**
```text
Length: 3.5 m
Breadth: 2.5 m
Height: 2.3 m
```

**Output**
```text
Area = 8.75 m²
Perimeter = 12 m
Volume = 20.125 m³
```
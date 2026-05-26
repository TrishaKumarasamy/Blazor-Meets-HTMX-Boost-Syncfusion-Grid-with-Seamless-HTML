  <h1>Blazor HTMX Integration</h1>
  <p>A Blazor Server application that integrates HTMX with Blazor Grid for seamless dynamic content updates</p>

## Overview

This project demonstrates how to combine Blazor's powerful component model with HTMX's lightweight HTTP request capabilities. The application showcases a Blazor Grid with order data, where each row features an HTMX-powered update button that fetches and displays content dynamically without a full page reload.

## Features

- **Blazor Server Mode** - Interactive server-side rendering with .NET 9
- **Grid** - Feature-rich data grid with sorting and custom column templates
- **HTMX Integration** - Smooth partial page updates using HTMX AJAX requests
- **Order Management Demo** - Sample order data with customer names, dates, and freight costs
- **Real-time Content Updates** - Dynamic HTML content loaded via `/htmx/message` endpoint

## Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
- [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the repository

```bash
git clone https://github.com/SyncfusionExamples/Blazor-Meets-HTMX-Boost-Syncfusion-Grid-with-Seamless-HTML.git
cd Blazor-Meets-HTMX-Boost-Syncfusion-Grid-with-Seamless-HTML
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run
```
## References

- [Blazor DataGrid Documentation](https://blazor.syncfusion.com/documentation/datagrid/getting-started-with-web-app)
- [Blazor Documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor)

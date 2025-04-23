# API Versioning in .NET with Swagger

[![Build Status](https://github.com/saideldah/api-versioining-dot-net/actions/workflows/dotnet.yml/badge.svg)](https://github.com/saideldah/api-versioining-dot-net/actions)
[![Coverage Report](https://img.shields.io/badge/Coverage-Report-blue)](https://saideldah.github.io/api-versioining-dot-net)

This repository demonstrates how to implement API versioning in a .NET application using Swagger for API documentation. It provides a sample project showcasing best practices for managing multiple API versions effectively.

## Features

- **API Versioning**: Supports versioning through URL segments, headers, and media types.
- **Swagger Integration**: Automatically generates Swagger documentation for each API version.
- **Default API Version**: Configures a default API version when none is specified.
- **Version Reporting**: Includes version information in API responses.

## Prerequisites

To run this project, ensure you have the following installed:

- .NET 9 or higher
- An IDE such as JetBrains Rider, Visual Studio, or Visual Studio Code

## Getting Started

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd <repository-folder>
   ```
2. Build and run the application:
`dotnet run`

3. Access the Swagger UI in your browser:
   - Development environment: http://localhost:5198/swagger


## API Versioning Details
This project uses the Asp.Versioning library to manage API versions. The following versioning methods are supported:


- URL Segment: Specify the version in the URL (e.g., /v1/endpoint).
- Header: Use the x-api-version header to specify the version.
- Media Type: Specify the version in the Content-Type or Accept headers.

Default API Version
If no version is specified, the application defaults to version 1.0.


Swagger Documentation
Swagger is configured to display separate documentation for each API version. You can switch between versions in the Swagger UI.


Project Structure
- Program.cs: Configures API versioning and Swagger.
- appsettings.Development.json: Contains logging configuration for the development environment.
- launchSettings.json: Defines application launch profiles.

## License
This project is licensed under the MIT License. See the LICENSE file for details.
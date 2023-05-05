# Gaming Quiz Web API

This is an ASP.NET Web API application for a Gaming Quiz.

## Overview

The Gaming Quiz Web API provides three GET endpoints for accessing gaming-related questions and answers. The API can be used to build gaming quiz applications.

## Endpoints

The following endpoints are currently available:

### 1. `GET https://gamingquizapi.azurewebsites.net/api/card`

Returns a list of all the available gaming-related questions in the database.

### 2. `GET https://gamingquizapi.azurewebsites.net/api/card/{id}`

Returns a specific gaming-related question by ID.

### 3. `GET https://gamingquizapi.azurewebsites.net/api/random/card`

Returns a randomly selected gaming-related question.

## Schema

The following is the schema of the `Card` entity:

```scheme
{
  "id": int,
  "question": string,
  "answer": string
}
```

## Running the API

To run the API, you will need to have .NET 6 SDK installed on your machine. Then, follow these steps:

1. Clone this repository
2. Open the command prompt and navigate to the root directory of the cloned repository
3. Run `dotnet run` command
4. The API will be available at `https://localhost:7014`

## Technologies Used

- ASP.NET Web API
- Entity Framework
- Microsoft SQL Server

## Future Development

In the future, this API may be expanded to include more endpoints for managing and creating questions. Additionally, authentication and authorization may be added to protect the API and prevent unauthorized access.

## Contributing

Contributions to this project are welcome. If you find a bug or have a suggestion for improvement, please open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

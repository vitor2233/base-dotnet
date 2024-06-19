# .NET API Base Architecture Repository

This repository serves as a foundational structure for building .NET APIs adhering to SOLID design principles and Clean Architecture practices. It is structured into multiple projects to segregate concerns and promote maintainability and scalability.

## Projects Overview

### API
Contains API controllers, error filters, and configuration settings necessary for hosting and managing the API endpoints. This project handles the HTTP layer and serves as the entry point for client requests.

### Application
This project encapsulates all use cases or application logic of the API. It implements business rules and orchestrates the flow of data between the API layer and the Domain layer. Use cases are defined here to ensure separation of concerns and maintain a clear business logic layer.

### Domain
Houses domain entities and repository interfaces. It defines the core business models and logic without being dependent on any external layers or frameworks. Interfaces for repositories are specified here to abstract data access operations.

### Communication
Manages user requests and API responses, serving as a bridge between the API layer and the Application layer. This project ensures that data is appropriately formatted and serialized for communication over the network.

### Exception
Centralizes custom exceptions that can be thrown by use cases within the Application layer. This project aids in structured error handling and provides a mechanism for the API layer to catch and appropriately respond to exceptions thrown during business logic execution.

### Infra
Implements repository patterns to communicate with the database. This project encapsulates data access logic, providing methods to persist and retrieve data from the underlying data store. It promotes separation of concerns by isolating database interactions from other layers.

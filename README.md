# TaskManagerAPI

A simple RESTful Task Management API built using ASP.NET Core Web API and Entity Framework Core. 
This project allows users to Create, Read, Update, and Delete (CRUD) tasks and serves as a great starting point for backend development.

#how run locally
-.NET 8 SDK
-Visual Studio 2022+

#clone the repository 
1. Clone the repo:
   ```bash
   git clone https://github.com/maheshkhare/TaskManagerAPI.git
   cd TaskManagerAPI
#run the app using http only and 
#Open Swagger UI: https://localhost:5126/swagger


API Endpoints
Method	Endpoint	Description
GET	/api/tasks	Get all tasks
GET	/api/tasks/{id}	Get task by ID
POST	/api/tasks	Add a new task
PUT	/api/tasks/{id}	Update a task
DELETE	/api/tasks/{id}	Delete a task

Technologies Used
-.NET 8 - Backend Framework
-ASP.NET Core Web API - RESTful API Development
-Entity Framework Core (InMemory) - ORM & InMemory database
-Swagger / Swashbuckle - API documentation
-Visual Studio 2022 - IDE

Features
-Full CRUD operations
-InMemory database for quick prototyping
-Swagger for testing API
-Modular code structure (Models, Data, Controllers)

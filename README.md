# TaskManagerAPI

A simple RESTful Task Management API built using ASP.NET Core Web API and Entity Framework Core. 
This project allows users to Create, Read, Update, and Delete (CRUD) tasks and serves as a great starting point for backend development.

#how run locally
-.NET 8 SDK
-Visual Studio 2022+

#clone the repository 
1. Clone the repo:
   ```bash
   git clone https://github.com/maheshkhare/TaskManagerApiProject.git
   cd TaskManagerAPI
#run the app using http only and 
#Open Swagger UI: https://localhost:5126/swagger


API Endpoints
1.GET	/api/tasks	Get all tasks
2.GET	/api/tasks/{id}	Get task by ID
3.POST	/api/tasks	Add a new task
4.PUT	/api/tasks/{id}	Update a task
5.DELETE	/api/tasks/{id}	Delete a task

Technologies Used
1. .NET 8 - Backend Framework
2. ASP.NET Core Web API - RESTful API Development
3. Entity Framework Core (InMemory) - ORM & InMemory database
4. Swagger / Swashbuckle - API documentation
5. Visual Studio 2022 - IDE

Features
1. Full CRUD operations
2. InMemory database for quick prototyping
3. Swagger for testing API
4. Modular code structure (Models, Data, Controllers)

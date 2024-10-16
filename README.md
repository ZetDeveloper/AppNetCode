# AppNetCode
 
Description
This project is a .NET application that interacts with a SQL Server database to manage products. The following instructions will help you set up and run the project locally using Docker Compose, as well as test the application using curl.

Prerequisites
Docker and Docker Compose installed on your system.
.NET 6.0 SDK or higher (if you plan to run the application locally without Docker).
Setup and Execution
1. Clone the Repository
Clone this repository to your local machine:

bash
git clone https://github.com/your_username/your_repository.git
cd your_repository
2. Run Docker Compose
In the root directory of the project, execute the following command to start the SQL Server instance:

bash
docker-compose up -d
This command will start the services defined in the docker-compose.yml file, including the SQL Server database required by the application.

3. Run the Application
You can run the application in two ways:

a) Using the .NET CLI
Ensure you are in the project's root directory and run:

bash
dotnet run
The application will start and listen on http://localhost:8080.

b) Using Docker (Optional)
If you prefer to run the application in a Docker container, you can build and run the image:

bash
docker build -t your_app_name .
docker run -p 8080:8080 your_app_name
Testing the Application
You can test the application using the following curl command:

bash
curl --location --request GET 'http://localhost:8080/api/Product/2' \
--header 'Content-Type: application/json' \
--data '{
  "name": "Product Name",
  "description": "Product Description",
  "price": 99.99
}'
This command sends a GET request to the endpoint /api/Product/2, passing JSON data in the request body.

Note: Ensure that the application is running and listening on port 8080.

Available Endpoints
GET /api/Product/{id}: Retrieves the product with the specified ID.
POST /api/Product: Creates a new product.
PUT /api/Product/{id}: Updates the product with the specified ID.
DELETE /api/Product/{id}: Deletes the product with the specified ID.
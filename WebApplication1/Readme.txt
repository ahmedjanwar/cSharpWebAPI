1. Base URL for the API
Base URL: https://localhost:5001/api/products
2. CRUD Operations in Postman
GET: Retrieve All Products
Method: GET
Endpoint: /api/products
Description: This request will fetch all products stored in the database.
Steps in Postman:
Open Postman.
Set the request method to GET.
Enter the URL: https://localhost:5001/api/products.
Click Send.
Expected Response (200 OK):
json
Kopioi koodi
[
    {
        "id": 1,
        "name": "Laptop",
        "description": "A high-performance laptop",
        "price": 999.99,
        "stock": 10
    },
    {
        "id": 2,
        "name": "Smartphone",
        "description": "Latest model smartphone",
        "price": 599.99,
        "stock": 25
    }
]
GET: Retrieve a Product by ID
Method: GET
Endpoint: /api/products/{id}
Description: Fetch details of a specific product by providing its ID.
Steps in Postman:
Set the request method to GET.
Enter the URL with the product ID: https://localhost:5001/api/products/1.
Click Send.
Expected Response (200 OK):
json
Kopioi koodi
{
    "id": 1,
    "name": "Laptop",
    "description": "A high-performance laptop",
    "price": 999.99,
    "stock": 10
}
If the product is not found, you will receive a 404 Not Found response:
json
Kopioi koodi
{
    "status": 404,
    "message": "Product not found."
}
POST: Add a New Product
Method: POST
Endpoint: /api/products
Description: Create a new product by sending product details in the request body.
Steps in Postman:
Set the request method to POST.
Enter the URL: https://localhost:5001/api/products.
Select the Body tab.
Choose raw and set the format to JSON.
Enter the following JSON data for the new product:
json
Kopioi koodi
{
    "name": "Keyboard",
    "description": "Mechanical keyboard with RGB lighting",
    "price": 89.99,
    "stock": 40
}
Click Send.
Expected Response (201 Created):
json
Kopioi koodi
{
    "id": 3,
    "name": "Keyboard",
    "description": "Mechanical keyboard with RGB lighting",
    "price": 89.99,
    "stock": 40
}
PUT: Update an Existing Product
Method: PUT
Endpoint: /api/products/{id}
Description: Update the details of an existing product by providing its ID and new data in the request body.
Steps in Postman:
Set the request method to PUT.
Enter the URL with the product ID: https://localhost:5001/api/products/1.
Select the Body tab.
Choose raw and set the format to JSON.
Enter the updated product data:
json
Kopioi koodi
{
    "id": 1,
    "name": "Laptop",
    "description": "Updated description for high-performance laptop",
    "price": 1050.00,
    "stock": 8
}
Click Send.
Expected Response (204 No Content):
If the update is successful, you will receive a 204 No Content response.
If the product is not found, you will receive a 404 Not Found response:
json
Kopioi koodi
{
    "status": 404,
    "message": "Product not found."
}
DELETE: Remove a Product by ID
Method: DELETE
Endpoint: /api/products/{id}
Description: Delete a product from the database by specifying its ID.
Steps in Postman:
Set the request method to DELETE.
Enter the URL with the product ID: https://localhost:5001/api/products/2.
Click Send.
Expected Response (204 No Content):
If the deletion is successful, you will receive a 204 No Content response.
If the product is not found, you will receive a 404 Not Found response:
json
Kopioi koodi
{
    "status": 404,
    "message": "Product not found."
}
Summary of API Endpoints
Operation	Method	URL	Description
Get All	GET	/api/products	Retrieve all products
Get by ID	GET	/api/products/{id}	Retrieve a product by its ID
Add	POST	/api/products	Add a new product
Update	PUT	/api/products/{id}	Update an existing product
Delete	DELETE	/api/products/{id}	Delete a product by its ID

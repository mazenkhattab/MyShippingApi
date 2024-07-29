# Shipping API

This is a simple ASP.NET Core application that calculates shipping costs using the Air shipping method. It demonstrates the use of the Strategy and Factory design patterns.



## Getting Started

### Prerequisites

- .NET 8 SDK 
### Installation

1. **Clone the repository**

    ```bash
    git clone https://github.com/mazenkhattab/MyShippingApi.git
    cd shipping-api
    ```

2. **Restore the dependencies**

    ```bash
    dotnet restore
    ```

3. **Build the project**

    ```bash
    dotnet build
    ```

### Configuration

No additional configuration is needed for this simple example. The default settings are suitable for running the application.

### Running the Application

1. **Run the application**

    ```bash
    dotnet watch run
    ```

2. The application will start, and you should see output similar to:

    ```
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: http://localhost:5254
    info: Microsoft.Hosting.Lifetime[0]
          Application started. Press Ctrl+C to shut down.
    info: Microsoft.Hosting.Lifetime[0]
          Hosting environment: Development
    ```

3. **Test the API**

    You can use tools like [Postman](https://www.postman.com/) or [cURL](https://curl.se/) to test the API endpoints.

    **Example Request:**

    ```bash
    curl -X POST "http://localhost:5254/api/shipping/calculate?shippingMethod=Air&shippingType=Standard" -H "Content-Type: application/json" -d '{"Id": 1, "Weight": 10, "Distance": 100}'
    ```

    **Example Response:**

    ```json
    10.0
    ```

## Project Structure

- **Factories**: Contains the `AirShippingFactory` class that creates instances of Air shipping strategies.
- **Strategies**: Contains the strategy classes for calculating Air shipping costs (e.g., `AirStandardStrategy`, `AirExpressStrategy`).
- **Controllers**: Contains the `ShippingController` for handling HTTP requests and calculating shipping costs.
- **Models**: Contains the `Order` model used in the application.

## Design Patterns Used

- **Strategy Pattern**: Used to define different shipping cost calculation algorithms and make them interchangeable.
- **Factory Pattern**: Used to create the appropriate shipping strategy based on the type of shipping requested.





# okhttp-gson-awsv4signature

OpenAPI Petstore
- API version: 1.0.0

This is a sample server Petstore server. For this sample, you can use the api key `special-key` to test the authorization filters.


*Automatically generated by the [OpenAPI Generator](https://openapi-generator.tech)*


## Requirements

Building the API client library requires:
1. Java 1.8+
2. Maven (3.8.3+)/Gradle (7.2+)

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn clean install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn clean deploy
```

Refer to the [OSSRH Guide](http://central.sonatype.org/pages/ossrh-guide.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
  <groupId>org.openapitools</groupId>
  <artifactId>okhttp-gson-awsv4signature</artifactId>
  <version>1.0.0</version>
  <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
  repositories {
    mavenCentral()     // Needed if the 'okhttp-gson-awsv4signature' jar has been published to maven central.
    mavenLocal()       // Needed if the 'okhttp-gson-awsv4signature' jar has been published to the local maven repo.
  }

  dependencies {
     implementation "org.openapitools:okhttp-gson-awsv4signature:1.0.0"
  }
```

### Others

At first generate the JAR by executing:

```shell
mvn clean package
```

Then manually install the following JARs:

* `target/okhttp-gson-awsv4signature-1.0.0.jar`
* `target/lib/*.jar`

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.PetApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("http://petstore.swagger.io/v2");
    // Configure AWS Signature V4 authorization
    defaultClient.setAWS4Configuration("YOUR_ACCESS_KEY", "YOUR_SECRET_KEY", "REGION", "SERVICE")
    
    // Configure OAuth2 access token for authorization: petstore_auth
    OAuth petstore_auth = (OAuth) defaultClient.getAuthentication("petstore_auth");
    petstore_auth.setAccessToken("YOUR ACCESS TOKEN");

    PetApi apiInstance = new PetApi(defaultClient);
    Pet pet = new Pet(); // Pet | Pet object that needs to be added to the store
    try {
      Pet result = apiInstance.addPet(pet);
      System.out.println(result);
    } catch (ApiException e) {
      System.err.println("Exception when calling PetApi#addPet");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}

```

## Documentation for API Endpoints

All URIs are relative to *http://petstore.swagger.io/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PetApi* | [**addPet**](docs/PetApi.md#addPet) | **POST** /pet | Add a new pet to the store
*PetApi* | [**deletePet**](docs/PetApi.md#deletePet) | **DELETE** /pet/{petId} | Deletes a pet
*PetApi* | [**findPetsByStatus**](docs/PetApi.md#findPetsByStatus) | **GET** /pet/findByStatus | Finds Pets by status
*PetApi* | [**findPetsByTags**](docs/PetApi.md#findPetsByTags) | **GET** /pet/findByTags | Finds Pets by tags
*PetApi* | [**getPetById**](docs/PetApi.md#getPetById) | **GET** /pet/{petId} | Find pet by ID
*PetApi* | [**updatePet**](docs/PetApi.md#updatePet) | **PUT** /pet | Update an existing pet
*PetApi* | [**updatePetWithForm**](docs/PetApi.md#updatePetWithForm) | **POST** /pet/{petId} | Updates a pet in the store with form data
*PetApi* | [**uploadFile**](docs/PetApi.md#uploadFile) | **POST** /pet/{petId}/uploadImage | uploads an image
*StoreApi* | [**deleteOrder**](docs/StoreApi.md#deleteOrder) | **DELETE** /store/order/{orderId} | Delete purchase order by ID
*StoreApi* | [**getInventory**](docs/StoreApi.md#getInventory) | **GET** /store/inventory | Returns pet inventories by status
*StoreApi* | [**getOrderById**](docs/StoreApi.md#getOrderById) | **GET** /store/order/{orderId} | Find purchase order by ID
*StoreApi* | [**placeOrder**](docs/StoreApi.md#placeOrder) | **POST** /store/order | Place an order for a pet
*UserApi* | [**createUser**](docs/UserApi.md#createUser) | **POST** /user | Create user
*UserApi* | [**createUsersWithArrayInput**](docs/UserApi.md#createUsersWithArrayInput) | **POST** /user/createWithArray | Creates list of users with given input array
*UserApi* | [**createUsersWithListInput**](docs/UserApi.md#createUsersWithListInput) | **POST** /user/createWithList | Creates list of users with given input array
*UserApi* | [**deleteUser**](docs/UserApi.md#deleteUser) | **DELETE** /user/{username} | Delete user
*UserApi* | [**getUserByName**](docs/UserApi.md#getUserByName) | **GET** /user/{username} | Get user by user name
*UserApi* | [**loginUser**](docs/UserApi.md#loginUser) | **GET** /user/login | Logs user into the system
*UserApi* | [**logoutUser**](docs/UserApi.md#logoutUser) | **GET** /user/logout | Logs out current logged in user session
*UserApi* | [**updateUser**](docs/UserApi.md#updateUser) | **PUT** /user/{username} | Updated user


## Documentation for Models

 - [Category](docs/Category.md)
 - [ModelApiResponse](docs/ModelApiResponse.md)
 - [Order](docs/Order.md)
 - [Pet](docs/Pet.md)
 - [Tag](docs/Tag.md)
 - [User](docs/User.md)


## Documentation for Authorization

Authentication schemes defined for the API:
### petstore_auth

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: http://petstore.swagger.io/api/oauth/dialog
- **Scopes**: 
  - write:pets: modify pets in your account
  - read:pets: read your pets

### api_key

- **Type**: API key
- **API key parameter name**: api_key
- **Location**: HTTP header


## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author



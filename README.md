# com.arpg.api - the C# library for the FastAPI

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.0.1
- SDK version: 1.0.0
- Generator version: 7.7.0-SNAPSHOT
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using com.arpg.api.arpg;
using com.arpg.api.Client;
using com.arpg.api.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out com.arpg.api.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.arpg.api.arpg;
using com.arpg.api.Client;
using com.arpg.api.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var username = "username_example";  // string | 
            var password = "password_example";  // string | 
            var grantType = "grantType_example";  // string? |  (optional) 
            var scope = "\"\"";  // string? |  (optional)  (default to "")
            var clientId = "clientId_example";  // string? |  (optional) 
            var clientSecret = "clientSecret_example";  // string? |  (optional) 

            try
            {
                // Auth:Unity.Login
                BearerResponse result = apiInstance.AuthUnityLoginAuthJwtLoginPost(username, password, grantType, scope, clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUnityLoginAuthJwtLoginPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthApi* | [**AuthUnityLoginAuthJwtLoginPost**](docs/AuthApi.md#authunityloginauthjwtloginpost) | **POST** /auth/jwt/login | Auth:Unity.Login
*AuthApi* | [**AuthUnityLogoutAuthJwtLogoutPost**](docs/AuthApi.md#authunitylogoutauthjwtlogoutpost) | **POST** /auth/jwt/logout | Auth:Unity.Logout
*AuthApi* | [**SecureEndpointAuthSecureEndpointGet**](docs/AuthApi.md#secureendpointauthsecureendpointget) | **GET** /auth/secure-endpoint | Secure Endpoint
*AuthApi* | [**VerifyRequestTokenAuthRequestVerifyTokenPost**](docs/AuthApi.md#verifyrequesttokenauthrequestverifytokenpost) | **POST** /auth/request-verify-token | Verify:Request-Token
*AuthApi* | [**VerifyVerifyAuthVerifyPost**](docs/AuthApi.md#verifyverifyauthverifypost) | **POST** /auth/verify | Verify:Verify
*UsersApi* | [**UsersCurrentUserUsersMeGet**](docs/UsersApi.md#userscurrentuserusersmeget) | **GET** /users/me | Users:Current User
*UsersApi* | [**UsersDeleteUserUsersIdDelete**](docs/UsersApi.md#usersdeleteuserusersiddelete) | **DELETE** /users/{id} | Users:Delete User
*UsersApi* | [**UsersPatchCurrentUserUsersMePatch**](docs/UsersApi.md#userspatchcurrentuserusersmepatch) | **PATCH** /users/me | Users:Patch Current User
*UsersApi* | [**UsersPatchUserUsersIdPatch**](docs/UsersApi.md#userspatchuserusersidpatch) | **PATCH** /users/{id} | Users:Patch User
*UsersApi* | [**UsersUserUsersIdGet**](docs/UsersApi.md#usersuserusersidget) | **GET** /users/{id} | Users:User


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.BearerResponse](docs/BearerResponse.md)
 - [Model.BodyVerifyRequestTokenAuthRequestVerifyTokenPost](docs/BodyVerifyRequestTokenAuthRequestVerifyTokenPost.md)
 - [Model.BodyVerifyVerifyAuthVerifyPost](docs/BodyVerifyVerifyAuthVerifyPost.md)
 - [Model.Detail](docs/Detail.md)
 - [Model.ErrorModel](docs/ErrorModel.md)
 - [Model.HTTPValidationError](docs/HTTPValidationError.md)
 - [Model.UserRead](docs/UserRead.md)
 - [Model.UserUpdate](docs/UserUpdate.md)
 - [Model.ValidationError](docs/ValidationError.md)
 - [Model.ValidationErrorLocInner](docs/ValidationErrorLocInner.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="OAuth2PasswordBearer"></a>
### OAuth2PasswordBearer

- **Type**: OAuth
- **Flow**: password
- **Authorization URL**: 
- **Scopes**: N/A


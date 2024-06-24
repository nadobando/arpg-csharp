# com.arpg.api.arpg.AuthApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthUnityLoginAuthJwtLoginPost**](AuthApi.md#authunityloginauthjwtloginpost) | **POST** /auth/jwt/login | Auth:Unity.Login |
| [**AuthUnityLogoutAuthJwtLogoutPost**](AuthApi.md#authunitylogoutauthjwtlogoutpost) | **POST** /auth/jwt/logout | Auth:Unity.Logout |
| [**SecureEndpointAuthSecureEndpointGet**](AuthApi.md#secureendpointauthsecureendpointget) | **GET** /auth/secure-endpoint | Secure Endpoint |
| [**VerifyRequestTokenAuthRequestVerifyTokenPost**](AuthApi.md#verifyrequesttokenauthrequestverifytokenpost) | **POST** /auth/request-verify-token | Verify:Request-Token |
| [**VerifyVerifyAuthVerifyPost**](AuthApi.md#verifyverifyauthverifypost) | **POST** /auth/verify | Verify:Verify |

<a id="authunityloginauthjwtloginpost"></a>
# **AuthUnityLoginAuthJwtLoginPost**
> BearerResponse AuthUnityLoginAuthJwtLoginPost (string username, string password, string? grantType = null, string? scope = null, string? clientId = null, string? clientSecret = null)

Auth:Unity.Login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.arpg.api.arpg;
using com.arpg.api.Client;
using com.arpg.api.Model;

namespace Example
{
    public class AuthUnityLoginAuthJwtLoginPostExample
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
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUnityLoginAuthJwtLoginPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUnityLoginAuthJwtLoginPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Auth:Unity.Login
    ApiResponse<BearerResponse> response = apiInstance.AuthUnityLoginAuthJwtLoginPostWithHttpInfo(username, password, grantType, scope, clientId, clientSecret);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUnityLoginAuthJwtLoginPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** |  |  |
| **password** | **string** |  |  |
| **grantType** | **string?** |  | [optional]  |
| **scope** | **string?** |  | [optional] [default to &quot;&quot;] |
| **clientId** | **string?** |  | [optional]  |
| **clientSecret** | **string?** |  | [optional]  |

### Return type

[**BearerResponse**](BearerResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad Request |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authunitylogoutauthjwtlogoutpost"></a>
# **AuthUnityLogoutAuthJwtLogoutPost**
> Object AuthUnityLogoutAuthJwtLogoutPost ()

Auth:Unity.Logout

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.arpg.api.arpg;
using com.arpg.api.Client;
using com.arpg.api.Model;

namespace Example
{
    public class AuthUnityLogoutAuthJwtLogoutPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthApi(config);

            try
            {
                // Auth:Unity.Logout
                Object result = apiInstance.AuthUnityLogoutAuthJwtLogoutPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.AuthUnityLogoutAuthJwtLogoutPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthUnityLogoutAuthJwtLogoutPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Auth:Unity.Logout
    ApiResponse<Object> response = apiInstance.AuthUnityLogoutAuthJwtLogoutPostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthUnityLogoutAuthJwtLogoutPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[OAuth2PasswordBearer](../README.md#OAuth2PasswordBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **401** | Missing token or inactive user. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="secureendpointauthsecureendpointget"></a>
# **SecureEndpointAuthSecureEndpointGet**
> Object SecureEndpointAuthSecureEndpointGet ()

Secure Endpoint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.arpg.api.arpg;
using com.arpg.api.Client;
using com.arpg.api.Model;

namespace Example
{
    public class SecureEndpointAuthSecureEndpointGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthApi(config);

            try
            {
                // Secure Endpoint
                Object result = apiInstance.SecureEndpointAuthSecureEndpointGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.SecureEndpointAuthSecureEndpointGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SecureEndpointAuthSecureEndpointGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Secure Endpoint
    ApiResponse<Object> response = apiInstance.SecureEndpointAuthSecureEndpointGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.SecureEndpointAuthSecureEndpointGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[OAuth2PasswordBearer](../README.md#OAuth2PasswordBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="verifyrequesttokenauthrequestverifytokenpost"></a>
# **VerifyRequestTokenAuthRequestVerifyTokenPost**
> Object VerifyRequestTokenAuthRequestVerifyTokenPost (BodyVerifyRequestTokenAuthRequestVerifyTokenPost bodyVerifyRequestTokenAuthRequestVerifyTokenPost)

Verify:Request-Token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.arpg.api.arpg;
using com.arpg.api.Client;
using com.arpg.api.Model;

namespace Example
{
    public class VerifyRequestTokenAuthRequestVerifyTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var bodyVerifyRequestTokenAuthRequestVerifyTokenPost = new BodyVerifyRequestTokenAuthRequestVerifyTokenPost(); // BodyVerifyRequestTokenAuthRequestVerifyTokenPost | 

            try
            {
                // Verify:Request-Token
                Object result = apiInstance.VerifyRequestTokenAuthRequestVerifyTokenPost(bodyVerifyRequestTokenAuthRequestVerifyTokenPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.VerifyRequestTokenAuthRequestVerifyTokenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VerifyRequestTokenAuthRequestVerifyTokenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify:Request-Token
    ApiResponse<Object> response = apiInstance.VerifyRequestTokenAuthRequestVerifyTokenPostWithHttpInfo(bodyVerifyRequestTokenAuthRequestVerifyTokenPost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.VerifyRequestTokenAuthRequestVerifyTokenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bodyVerifyRequestTokenAuthRequestVerifyTokenPost** | [**BodyVerifyRequestTokenAuthRequestVerifyTokenPost**](BodyVerifyRequestTokenAuthRequestVerifyTokenPost.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="verifyverifyauthverifypost"></a>
# **VerifyVerifyAuthVerifyPost**
> UserRead VerifyVerifyAuthVerifyPost (BodyVerifyVerifyAuthVerifyPost bodyVerifyVerifyAuthVerifyPost)

Verify:Verify

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.arpg.api.arpg;
using com.arpg.api.Client;
using com.arpg.api.Model;

namespace Example
{
    public class VerifyVerifyAuthVerifyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthApi(config);
            var bodyVerifyVerifyAuthVerifyPost = new BodyVerifyVerifyAuthVerifyPost(); // BodyVerifyVerifyAuthVerifyPost | 

            try
            {
                // Verify:Verify
                UserRead result = apiInstance.VerifyVerifyAuthVerifyPost(bodyVerifyVerifyAuthVerifyPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.VerifyVerifyAuthVerifyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VerifyVerifyAuthVerifyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify:Verify
    ApiResponse<UserRead> response = apiInstance.VerifyVerifyAuthVerifyPostWithHttpInfo(bodyVerifyVerifyAuthVerifyPost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.VerifyVerifyAuthVerifyPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bodyVerifyVerifyAuthVerifyPost** | [**BodyVerifyVerifyAuthVerifyPost**](BodyVerifyVerifyAuthVerifyPost.md) |  |  |

### Return type

[**UserRead**](UserRead.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad Request |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


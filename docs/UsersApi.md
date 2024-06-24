# com.arpg.api.arpg.UsersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UsersCurrentUserUsersMeGet**](UsersApi.md#userscurrentuserusersmeget) | **GET** /users/me | Users:Current User |
| [**UsersDeleteUserUsersIdDelete**](UsersApi.md#usersdeleteuserusersiddelete) | **DELETE** /users/{id} | Users:Delete User |
| [**UsersPatchCurrentUserUsersMePatch**](UsersApi.md#userspatchcurrentuserusersmepatch) | **PATCH** /users/me | Users:Patch Current User |
| [**UsersPatchUserUsersIdPatch**](UsersApi.md#userspatchuserusersidpatch) | **PATCH** /users/{id} | Users:Patch User |
| [**UsersUserUsersIdGet**](UsersApi.md#usersuserusersidget) | **GET** /users/{id} | Users:User |

<a id="userscurrentuserusersmeget"></a>
# **UsersCurrentUserUsersMeGet**
> UserRead UsersCurrentUserUsersMeGet ()

Users:Current User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.arpg.api.arpg;
using com.arpg.api.Client;
using com.arpg.api.Model;

namespace Example
{
    public class UsersCurrentUserUsersMeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);

            try
            {
                // Users:Current User
                UserRead result = apiInstance.UsersCurrentUserUsersMeGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersCurrentUserUsersMeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersCurrentUserUsersMeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Users:Current User
    ApiResponse<UserRead> response = apiInstance.UsersCurrentUserUsersMeGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersCurrentUserUsersMeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserRead**](UserRead.md)

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

<a id="usersdeleteuserusersiddelete"></a>
# **UsersDeleteUserUsersIdDelete**
> void UsersDeleteUserUsersIdDelete (string id)

Users:Delete User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.arpg.api.arpg;
using com.arpg.api.Client;
using com.arpg.api.Model;

namespace Example
{
    public class UsersDeleteUserUsersIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Users:Delete User
                apiInstance.UsersDeleteUserUsersIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersDeleteUserUsersIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersDeleteUserUsersIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Users:Delete User
    apiInstance.UsersDeleteUserUsersIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersDeleteUserUsersIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[OAuth2PasswordBearer](../README.md#OAuth2PasswordBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful Response |  -  |
| **401** | Missing token or inactive user. |  -  |
| **403** | Not a superuser. |  -  |
| **404** | The user does not exist. |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userspatchcurrentuserusersmepatch"></a>
# **UsersPatchCurrentUserUsersMePatch**
> UserRead UsersPatchCurrentUserUsersMePatch (UserUpdate userUpdate)

Users:Patch Current User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.arpg.api.arpg;
using com.arpg.api.Client;
using com.arpg.api.Model;

namespace Example
{
    public class UsersPatchCurrentUserUsersMePatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var userUpdate = new UserUpdate(); // UserUpdate | 

            try
            {
                // Users:Patch Current User
                UserRead result = apiInstance.UsersPatchCurrentUserUsersMePatch(userUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersPatchCurrentUserUsersMePatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersPatchCurrentUserUsersMePatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Users:Patch Current User
    ApiResponse<UserRead> response = apiInstance.UsersPatchCurrentUserUsersMePatchWithHttpInfo(userUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersPatchCurrentUserUsersMePatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userUpdate** | [**UserUpdate**](UserUpdate.md) |  |  |

### Return type

[**UserRead**](UserRead.md)

### Authorization

[OAuth2PasswordBearer](../README.md#OAuth2PasswordBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **401** | Missing token or inactive user. |  -  |
| **400** | Bad Request |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userspatchuserusersidpatch"></a>
# **UsersPatchUserUsersIdPatch**
> UserRead UsersPatchUserUsersIdPatch (string id, UserUpdate userUpdate)

Users:Patch User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.arpg.api.arpg;
using com.arpg.api.Client;
using com.arpg.api.Model;

namespace Example
{
    public class UsersPatchUserUsersIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | 
            var userUpdate = new UserUpdate(); // UserUpdate | 

            try
            {
                // Users:Patch User
                UserRead result = apiInstance.UsersPatchUserUsersIdPatch(id, userUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersPatchUserUsersIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersPatchUserUsersIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Users:Patch User
    ApiResponse<UserRead> response = apiInstance.UsersPatchUserUsersIdPatchWithHttpInfo(id, userUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersPatchUserUsersIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **userUpdate** | [**UserUpdate**](UserUpdate.md) |  |  |

### Return type

[**UserRead**](UserRead.md)

### Authorization

[OAuth2PasswordBearer](../README.md#OAuth2PasswordBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **401** | Missing token or inactive user. |  -  |
| **403** | Not a superuser. |  -  |
| **404** | The user does not exist. |  -  |
| **400** | Bad Request |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usersuserusersidget"></a>
# **UsersUserUsersIdGet**
> UserRead UsersUserUsersIdGet (string id)

Users:User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.arpg.api.arpg;
using com.arpg.api.Client;
using com.arpg.api.Model;

namespace Example
{
    public class UsersUserUsersIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Users:User
                UserRead result = apiInstance.UsersUserUsersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserUsersIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserUsersIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Users:User
    ApiResponse<UserRead> response = apiInstance.UsersUserUsersIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UsersUserUsersIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**UserRead**](UserRead.md)

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
| **403** | Not a superuser. |  -  |
| **404** | The user does not exist. |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


/* 
 * nexjs-ws.demo-project.server-nestjs
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using demo.httpclient.Client;
using demo.httpclient.Model;

namespace demo.httpclient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>AuthJwtLoginResponseDto</returns>
        AuthJwtLoginResponseDto AuthControllerJwtLogin (AuthLoginDto authLoginDto);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>ApiResponse of AuthJwtLoginResponseDto</returns>
        ApiResponse<AuthJwtLoginResponseDto> AuthControllerJwtLoginWithHttpInfo (AuthLoginDto authLoginDto);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>AuthUserDto</returns>
        AuthUserDto AuthControllerLocalLogin (AuthLoginDto authLoginDto);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>ApiResponse of AuthUserDto</returns>
        ApiResponse<AuthUserDto> AuthControllerLocalLoginWithHttpInfo (AuthLoginDto authLoginDto);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void AuthControllerLocalLogout ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AuthControllerLocalLogoutWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>AuthUserDto</returns>
        AuthUserDto AuthControllerRegister (AuthLoginDto authLoginDto);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>ApiResponse of AuthUserDto</returns>
        ApiResponse<AuthUserDto> AuthControllerRegisterWithHttpInfo (AuthLoginDto authLoginDto);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>Task of AuthJwtLoginResponseDto</returns>
        System.Threading.Tasks.Task<AuthJwtLoginResponseDto> AuthControllerJwtLoginAsync (AuthLoginDto authLoginDto);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>Task of ApiResponse (AuthJwtLoginResponseDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthJwtLoginResponseDto>> AuthControllerJwtLoginAsyncWithHttpInfo (AuthLoginDto authLoginDto);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>Task of AuthUserDto</returns>
        System.Threading.Tasks.Task<AuthUserDto> AuthControllerLocalLoginAsync (AuthLoginDto authLoginDto);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>Task of ApiResponse (AuthUserDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthUserDto>> AuthControllerLocalLoginAsyncWithHttpInfo (AuthLoginDto authLoginDto);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AuthControllerLocalLogoutAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AuthControllerLocalLogoutAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>Task of AuthUserDto</returns>
        System.Threading.Tasks.Task<AuthUserDto> AuthControllerRegisterAsync (AuthLoginDto authLoginDto);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>Task of ApiResponse (AuthUserDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthUserDto>> AuthControllerRegisterAsyncWithHttpInfo (AuthLoginDto authLoginDto);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthApi : IAuthApi
    {
        private demo.httpclient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthApi(String basePath)
        {
            this.Configuration = new demo.httpclient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = demo.httpclient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// </summary>
        /// <returns></returns>
        public AuthApi()
        {
            this.Configuration = demo.httpclient.Client.Configuration.Default;

            ExceptionFactory = demo.httpclient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthApi(demo.httpclient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = demo.httpclient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = demo.httpclient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public demo.httpclient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public demo.httpclient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>AuthJwtLoginResponseDto</returns>
        public AuthJwtLoginResponseDto AuthControllerJwtLogin (AuthLoginDto authLoginDto)
        {
             ApiResponse<AuthJwtLoginResponseDto> localVarResponse = AuthControllerJwtLoginWithHttpInfo(authLoginDto);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>ApiResponse of AuthJwtLoginResponseDto</returns>
        public ApiResponse<AuthJwtLoginResponseDto> AuthControllerJwtLoginWithHttpInfo (AuthLoginDto authLoginDto)
        {
            // verify the required parameter 'authLoginDto' is set
            if (authLoginDto == null)
                throw new ApiException(400, "Missing required parameter 'authLoginDto' when calling AuthApi->AuthControllerJwtLogin");

            var localVarPath = "/api/auth/jwtLogin";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authLoginDto != null && authLoginDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(authLoginDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authLoginDto; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthControllerJwtLogin", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthJwtLoginResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value), StringComparer.OrdinalIgnoreCase),
                (AuthJwtLoginResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthJwtLoginResponseDto)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>Task of AuthJwtLoginResponseDto</returns>
        public async System.Threading.Tasks.Task<AuthJwtLoginResponseDto> AuthControllerJwtLoginAsync (AuthLoginDto authLoginDto)
        {
             ApiResponse<AuthJwtLoginResponseDto> localVarResponse = await AuthControllerJwtLoginAsyncWithHttpInfo(authLoginDto);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>Task of ApiResponse (AuthJwtLoginResponseDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthJwtLoginResponseDto>> AuthControllerJwtLoginAsyncWithHttpInfo (AuthLoginDto authLoginDto)
        {
            // verify the required parameter 'authLoginDto' is set
            if (authLoginDto == null)
                throw new ApiException(400, "Missing required parameter 'authLoginDto' when calling AuthApi->AuthControllerJwtLogin");

            var localVarPath = "/api/auth/jwtLogin";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authLoginDto != null && authLoginDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(authLoginDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authLoginDto; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthControllerJwtLogin", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthJwtLoginResponseDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value), StringComparer.OrdinalIgnoreCase),
                (AuthJwtLoginResponseDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthJwtLoginResponseDto)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>AuthUserDto</returns>
        public AuthUserDto AuthControllerLocalLogin (AuthLoginDto authLoginDto)
        {
             ApiResponse<AuthUserDto> localVarResponse = AuthControllerLocalLoginWithHttpInfo(authLoginDto);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>ApiResponse of AuthUserDto</returns>
        public ApiResponse<AuthUserDto> AuthControllerLocalLoginWithHttpInfo (AuthLoginDto authLoginDto)
        {
            // verify the required parameter 'authLoginDto' is set
            if (authLoginDto == null)
                throw new ApiException(400, "Missing required parameter 'authLoginDto' when calling AuthApi->AuthControllerLocalLogin");

            var localVarPath = "/api/auth/localLogin";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authLoginDto != null && authLoginDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(authLoginDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authLoginDto; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthControllerLocalLogin", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthUserDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value), StringComparer.OrdinalIgnoreCase),
                (AuthUserDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthUserDto)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>Task of AuthUserDto</returns>
        public async System.Threading.Tasks.Task<AuthUserDto> AuthControllerLocalLoginAsync (AuthLoginDto authLoginDto)
        {
             ApiResponse<AuthUserDto> localVarResponse = await AuthControllerLocalLoginAsyncWithHttpInfo(authLoginDto);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>Task of ApiResponse (AuthUserDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthUserDto>> AuthControllerLocalLoginAsyncWithHttpInfo (AuthLoginDto authLoginDto)
        {
            // verify the required parameter 'authLoginDto' is set
            if (authLoginDto == null)
                throw new ApiException(400, "Missing required parameter 'authLoginDto' when calling AuthApi->AuthControllerLocalLogin");

            var localVarPath = "/api/auth/localLogin";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authLoginDto != null && authLoginDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(authLoginDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authLoginDto; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthControllerLocalLogin", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthUserDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value), StringComparer.OrdinalIgnoreCase),
                (AuthUserDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthUserDto)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void AuthControllerLocalLogout ()
        {
             AuthControllerLocalLogoutWithHttpInfo();
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AuthControllerLocalLogoutWithHttpInfo ()
        {

            var localVarPath = "/api/auth/localLogout";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthControllerLocalLogout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value), StringComparer.OrdinalIgnoreCase),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AuthControllerLocalLogoutAsync ()
        {
             await AuthControllerLocalLogoutAsyncWithHttpInfo();

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AuthControllerLocalLogoutAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/auth/localLogout";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthControllerLocalLogout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value), StringComparer.OrdinalIgnoreCase),
                null);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>AuthUserDto</returns>
        public AuthUserDto AuthControllerRegister (AuthLoginDto authLoginDto)
        {
             ApiResponse<AuthUserDto> localVarResponse = AuthControllerRegisterWithHttpInfo(authLoginDto);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>ApiResponse of AuthUserDto</returns>
        public ApiResponse<AuthUserDto> AuthControllerRegisterWithHttpInfo (AuthLoginDto authLoginDto)
        {
            // verify the required parameter 'authLoginDto' is set
            if (authLoginDto == null)
                throw new ApiException(400, "Missing required parameter 'authLoginDto' when calling AuthApi->AuthControllerRegister");

            var localVarPath = "/api/auth/register";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authLoginDto != null && authLoginDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(authLoginDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authLoginDto; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthControllerRegister", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthUserDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value), StringComparer.OrdinalIgnoreCase),
                (AuthUserDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthUserDto)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>Task of AuthUserDto</returns>
        public async System.Threading.Tasks.Task<AuthUserDto> AuthControllerRegisterAsync (AuthLoginDto authLoginDto)
        {
             ApiResponse<AuthUserDto> localVarResponse = await AuthControllerRegisterAsyncWithHttpInfo(authLoginDto);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="demo.httpclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authLoginDto"></param>
        /// <returns>Task of ApiResponse (AuthUserDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthUserDto>> AuthControllerRegisterAsyncWithHttpInfo (AuthLoginDto authLoginDto)
        {
            // verify the required parameter 'authLoginDto' is set
            if (authLoginDto == null)
                throw new ApiException(400, "Missing required parameter 'authLoginDto' when calling AuthApi->AuthControllerRegister");

            var localVarPath = "/api/auth/register";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authLoginDto != null && authLoginDto.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(authLoginDto); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authLoginDto; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthControllerRegister", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthUserDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value), StringComparer.OrdinalIgnoreCase),
                (AuthUserDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthUserDto)));
        }

    }
}
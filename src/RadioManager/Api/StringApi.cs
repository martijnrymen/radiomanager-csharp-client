/* 
 * RadioManager
 *
 * RadioManager
 *
 * OpenAPI spec version: 2.0
 * Contact: support@pluxbox.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using RadioManager.Client;
using RadioManager.Model;

namespace RadioManager.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStringApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Strings (formatted)
        /// </summary>
        /// <remarks>
        /// Get Strings (formatted)
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of Strings **(Required)**</param>
        /// <param name="fullModel">Full model or content only **(Required)**</param>
        /// <returns>TextString</returns>
        TextString GetStringsByName (string name, bool? fullModel);

        /// <summary>
        /// Get Strings (formatted)
        /// </summary>
        /// <remarks>
        /// Get Strings (formatted)
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of Strings **(Required)**</param>
        /// <param name="fullModel">Full model or content only **(Required)**</param>
        /// <returns>ApiResponse of TextString</returns>
        ApiResponse<TextString> GetStringsByNameWithHttpInfo (string name, bool? fullModel);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Strings (formatted)
        /// </summary>
        /// <remarks>
        /// Get Strings (formatted)
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of Strings **(Required)**</param>
        /// <param name="fullModel">Full model or content only **(Required)**</param>
        /// <returns>Task of TextString</returns>
        System.Threading.Tasks.Task<TextString> GetStringsByNameAsync (string name, bool? fullModel);

        /// <summary>
        /// Get Strings (formatted)
        /// </summary>
        /// <remarks>
        /// Get Strings (formatted)
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of Strings **(Required)**</param>
        /// <param name="fullModel">Full model or content only **(Required)**</param>
        /// <returns>Task of ApiResponse (TextString)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextString>> GetStringsByNameAsyncWithHttpInfo (string name, bool? fullModel);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StringApi : IStringApi
    {
        private RadioManager.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StringApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = RadioManager.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StringApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = RadioManager.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public RadioManager.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Get Strings (formatted) Get Strings (formatted)
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of Strings **(Required)**</param>
        /// <param name="fullModel">Full model or content only **(Required)**</param>
        /// <returns>TextString</returns>
        public TextString GetStringsByName (string name, bool? fullModel)
        {
             ApiResponse<TextString> localVarResponse = GetStringsByNameWithHttpInfo(name, fullModel);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Strings (formatted) Get Strings (formatted)
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of Strings **(Required)**</param>
        /// <param name="fullModel">Full model or content only **(Required)**</param>
        /// <returns>ApiResponse of TextString</returns>
        public ApiResponse< TextString > GetStringsByNameWithHttpInfo (string name, bool? fullModel)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling StringApi->GetStringsByName");
            // verify the required parameter 'fullModel' is set
            if (fullModel == null)
                throw new ApiException(400, "Missing required parameter 'fullModel' when calling StringApi->GetStringsByName");

            var localVarPath = "/strings/{name}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            if (fullModel != null) localVarQueryParams.Add("full_model", Configuration.ApiClient.ParameterToString(fullModel)); // query parameter

            // authentication (API Key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStringsByName", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextString>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextString) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TextString)));
        }

        /// <summary>
        /// Get Strings (formatted) Get Strings (formatted)
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of Strings **(Required)**</param>
        /// <param name="fullModel">Full model or content only **(Required)**</param>
        /// <returns>Task of TextString</returns>
        public async System.Threading.Tasks.Task<TextString> GetStringsByNameAsync (string name, bool? fullModel)
        {
             ApiResponse<TextString> localVarResponse = await GetStringsByNameAsyncWithHttpInfo(name, fullModel);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Strings (formatted) Get Strings (formatted)
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of Strings **(Required)**</param>
        /// <param name="fullModel">Full model or content only **(Required)**</param>
        /// <returns>Task of ApiResponse (TextString)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextString>> GetStringsByNameAsyncWithHttpInfo (string name, bool? fullModel)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling StringApi->GetStringsByName");
            // verify the required parameter 'fullModel' is set
            if (fullModel == null)
                throw new ApiException(400, "Missing required parameter 'fullModel' when calling StringApi->GetStringsByName");

            var localVarPath = "/strings/{name}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            if (fullModel != null) localVarQueryParams.Add("full_model", Configuration.ApiClient.ParameterToString(fullModel)); // query parameter

            // authentication (API Key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStringsByName", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextString>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextString) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TextString)));
        }

    }
}

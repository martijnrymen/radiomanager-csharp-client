/* 
 * Pluxbox Radiomanager Client
 *
 * Pluxbox RadioManager gives you the power, flexibility and speed you always wanted in a lightweight and easy-to-use web-based radio solution. With Pluxbox RadioManager you can organise your radio workflow and automate your omnichannel communication with your listeners. We offer wide range specialised services for the radio and connections like Hybrid Radio, Visual Radio, your website and social media without losing focus on your broadcast. For more information visit https://pluxbox.com
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
    public interface IVisualSlideApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Visual Slide Image as JPEG
        /// </summary>
        /// <remarks>
        /// Get Visual Slide Image as JPEG
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VisualImageResult</returns>
        VisualImageResult DownloadVisualSlide ();

        /// <summary>
        /// Get Visual Slide Image as JPEG
        /// </summary>
        /// <remarks>
        /// Get Visual Slide Image as JPEG
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VisualImageResult</returns>
        ApiResponse<VisualImageResult> DownloadVisualSlideWithHttpInfo ();
        /// <summary>
        /// Get Visual Slide Image as Base64
        /// </summary>
        /// <remarks>
        /// Get Visual Slide Image as Base64
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VisualResult</returns>
        VisualResult GetVisualSlide ();

        /// <summary>
        /// Get Visual Slide Image as Base64
        /// </summary>
        /// <remarks>
        /// Get Visual Slide Image as Base64
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VisualResult</returns>
        ApiResponse<VisualResult> GetVisualSlideWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Visual Slide Image as JPEG
        /// </summary>
        /// <remarks>
        /// Get Visual Slide Image as JPEG
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VisualImageResult</returns>
        System.Threading.Tasks.Task<VisualImageResult> DownloadVisualSlideAsync ();

        /// <summary>
        /// Get Visual Slide Image as JPEG
        /// </summary>
        /// <remarks>
        /// Get Visual Slide Image as JPEG
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VisualImageResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<VisualImageResult>> DownloadVisualSlideAsyncWithHttpInfo ();
        /// <summary>
        /// Get Visual Slide Image as Base64
        /// </summary>
        /// <remarks>
        /// Get Visual Slide Image as Base64
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VisualResult</returns>
        System.Threading.Tasks.Task<VisualResult> GetVisualSlideAsync ();

        /// <summary>
        /// Get Visual Slide Image as Base64
        /// </summary>
        /// <remarks>
        /// Get Visual Slide Image as Base64
        /// </remarks>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VisualResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<VisualResult>> GetVisualSlideAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VisualSlideApi : IVisualSlideApi
    {
        private RadioManager.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualSlideApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VisualSlideApi(String basePath)
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
        /// Initializes a new instance of the <see cref="VisualSlideApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VisualSlideApi(Configuration configuration = null)
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
        /// Get Visual Slide Image as JPEG Get Visual Slide Image as JPEG
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VisualImageResult</returns>
        public VisualImageResult DownloadVisualSlide ()
        {
             ApiResponse<VisualImageResult> localVarResponse = DownloadVisualSlideWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Visual Slide Image as JPEG Get Visual Slide Image as JPEG
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VisualImageResult</returns>
        public ApiResponse< VisualImageResult > DownloadVisualSlideWithHttpInfo ()
        {

            var localVarPath = "/visual/image";
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
                Exception exception = ExceptionFactory("DownloadVisualSlide", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VisualImageResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VisualImageResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VisualImageResult)));
        }

        /// <summary>
        /// Get Visual Slide Image as JPEG Get Visual Slide Image as JPEG
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VisualImageResult</returns>
        public async System.Threading.Tasks.Task<VisualImageResult> DownloadVisualSlideAsync ()
        {
             ApiResponse<VisualImageResult> localVarResponse = await DownloadVisualSlideAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Visual Slide Image as JPEG Get Visual Slide Image as JPEG
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VisualImageResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VisualImageResult>> DownloadVisualSlideAsyncWithHttpInfo ()
        {

            var localVarPath = "/visual/image";
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
                Exception exception = ExceptionFactory("DownloadVisualSlide", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VisualImageResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VisualImageResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VisualImageResult)));
        }

        /// <summary>
        /// Get Visual Slide Image as Base64 Get Visual Slide Image as Base64
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VisualResult</returns>
        public VisualResult GetVisualSlide ()
        {
             ApiResponse<VisualResult> localVarResponse = GetVisualSlideWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Visual Slide Image as Base64 Get Visual Slide Image as Base64
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VisualResult</returns>
        public ApiResponse< VisualResult > GetVisualSlideWithHttpInfo ()
        {

            var localVarPath = "/visual";
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
                Exception exception = ExceptionFactory("GetVisualSlide", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VisualResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VisualResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VisualResult)));
        }

        /// <summary>
        /// Get Visual Slide Image as Base64 Get Visual Slide Image as Base64
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VisualResult</returns>
        public async System.Threading.Tasks.Task<VisualResult> GetVisualSlideAsync ()
        {
             ApiResponse<VisualResult> localVarResponse = await GetVisualSlideAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Visual Slide Image as Base64 Get Visual Slide Image as Base64
        /// </summary>
        /// <exception cref="RadioManager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VisualResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VisualResult>> GetVisualSlideAsyncWithHttpInfo ()
        {

            var localVarPath = "/visual";
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
                Exception exception = ExceptionFactory("GetVisualSlide", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VisualResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VisualResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VisualResult)));
        }

    }
}
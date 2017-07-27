using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Core
{
    /// <summary>
    /// Client for interacting with the search API's. This is an abstract class.
    /// </summary>
    public abstract class SearchClient
    {
        #region Fields

        private const string APPLICATION_JSON_CONTENT_TYPE = "application/json";

        private const string GET_METHOD = "GET";

        private const string OCP_APIM_SUBSCRIPTION_KEY = "Ocp-Apim-Subscription-Key";

        private const string POST_METHOD = "POST";

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public SearchClient(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        /// <value>
        /// The API key.
        /// </value>
        public string ApiKey
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Sends the post.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        protected string SendPost(string data)
        {
            return SendPost(this.Url, data);
        }

        /// <summary>
        /// Sends the post.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        protected string SendPost(string url, string data)
        {
            return this.SendPostAsync(url, data).Result;
        }

        /// <summary>
        /// Sends the post asynchronously.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        protected async Task<string> SendPostAsync(string data)
        {
            return await SendPostAsync(this.Url, data);
        }

        /// <summary>
        /// Sends the post asynchronously.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">
        /// url
        /// or
        /// ApiKey
        /// or
        /// data
        /// </exception>
        protected async Task<string> SendPostAsync(string url, string data)
        {
            if (String.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException(nameof(url));
            }

            if (String.IsNullOrWhiteSpace(this.ApiKey))
            {
                throw new ArgumentException(nameof(ApiKey));
            }

            if (String.IsNullOrWhiteSpace(data))
            {
                throw new ArgumentException(nameof(data));
            }

            byte[] reqData = Encoding.UTF8.GetBytes(data);

            var responseData = "";

            using (var client = new HttpClient { BaseAddress = new Uri(url) })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(APPLICATION_JSON_CONTENT_TYPE));
                client.DefaultRequestHeaders.Add(OCP_APIM_SUBSCRIPTION_KEY, ApiKey);

                var content = new StringContent(data, Encoding.UTF8, "application/json");

                using (var response = await client.PostAsync(url, content))
                {
                    responseData = await response.Content.ReadAsStringAsync();
                }
            }

            return responseData;
        }

        /// <summary>
        /// Sends the get.
        /// </summary>
        /// <returns></returns>
        protected string SendGet()
        {
            return SendGet(this.Url);
        }

        /// <summary>
        /// Sends the get.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        protected string SendGet(string url)
        {
            return SendGetAsync(url).Result;
        }

        /// <summary>
        /// Sends the get asynchronous.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">
        /// url
        /// or
        /// ApiKey
        /// </exception>
        protected async Task<string> SendGetAsync(string url)
        {
            if (String.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException(nameof(url));
            }

            if (String.IsNullOrWhiteSpace(this.ApiKey))
            {
                throw new ArgumentException(nameof(ApiKey));
            }

            var responseData = "";

            using (var client = new HttpClient { BaseAddress = new Uri(url) })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(APPLICATION_JSON_CONTENT_TYPE));
                client.DefaultRequestHeaders.Add(OCP_APIM_SUBSCRIPTION_KEY, ApiKey);

                using (var response = await client.GetAsync(url))
                {
                    responseData = await response.Content.ReadAsStringAsync();
                }
            }

            return responseData;
        }

        #endregion Methods
    }
}

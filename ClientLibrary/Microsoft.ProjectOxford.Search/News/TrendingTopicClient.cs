using Microsoft.ProjectOxford.Search.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.News
{
    /// <summary>
    /// Client for trending topic API.
    /// </summary>
    public class TrendingTopicClient : SearchClient
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingTopicClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public TrendingTopicClient(string apiKey)
            : base(apiKey)
        {
            this.Url = "https://api.cognitive.microsoft.com/bing/v5.0/news/trendingtopics";
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the trending topics.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public TrendingTopicResponse GetTrendingTopics(TrendingTopicRequest request)
        {
            return GetTrendingTopicsAsync(request).Result;
        }

        /// <summary>
        /// Gets the trending topics asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<TrendingTopicResponse> GetTrendingTopicsAsync(TrendingTopicRequest request)
        {
            var responseJson = await this.SendGetAsync(this.Url);
            var response = JsonConvert.DeserializeObject<TrendingTopicResponse>(responseJson);

            return response;
        }

        #endregion Methods
    }
}

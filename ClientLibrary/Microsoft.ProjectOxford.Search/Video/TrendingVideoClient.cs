using Microsoft.ProjectOxford.Search.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Video
{
    /// <summary>
    /// Client for interacting with the trending video API.
    /// </summary>
    /// <seealso cref="SearchClient" />
    public class TrendingVideoClient : SearchClient
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingVideoClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public TrendingVideoClient(string apiKey)
            : base(apiKey)
        {
            this.Url = "https://api.cognitive.microsoft.com/bing/v5.0/videos/trending";
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the videos.
        /// </summary>
        /// <returns></returns>
        public TrendingVideoResponse GetVideos()
        {
            return this.GetVideosAsync().Result;
        }

        /// <summary>
        /// Gets the videos asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<TrendingVideoResponse> GetVideosAsync()
        {
            var responseJson = await this.SendGetAsync(this.Url);
            var response = JsonConvert.DeserializeObject<TrendingVideoResponse>(responseJson);

            return response;
        }

        #endregion Methods
    }
}

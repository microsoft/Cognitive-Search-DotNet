using Microsoft.ProjectOxford.Search.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Video
{
    /// <summary>
    /// Client for interacting with the video search API.
    /// </summary>
    /// <seealso cref="Microsoft.ProjectOxford.Search.Core.SearchClient" />
    public class VideoSearchClient : SearchClient
    {
        #region Constructors

        #endregion Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSearchClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public VideoSearchClient(string apiKey)
            : base(apiKey)
        {
            this.Url = "https://api.cognitive.microsoft.com/bing/v5.0/videos/search";
        }

        #region Methods

        /// <summary>
        /// Gets the videos.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public VideoSearchResponse GetVideos(VideoSearchRequest request)
        {
            return GetVideosAsync(request).Result;
        }

        /// <summary>
        /// Gets the videos asynchronously.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<VideoSearchResponse> GetVideosAsync(VideoSearchRequest request)
        {
            request.Validate();

            var requestUrl = string.Format("{0}?q={1}", this.Url, WebUtility.UrlEncode(request.Query));

            if (request.Count > 0)
                requestUrl = string.Format("{0}&count={1}", requestUrl, request.Count.ToString());

            if (request.Offset >= 0)
                requestUrl = string.Format("{0}&offset={1}", requestUrl, request.Offset.ToString());

            if (!string.IsNullOrEmpty(request.Market))
                requestUrl = string.Format("{0}&mkt={1}", requestUrl, request.Market);

            requestUrl = string.Format("{0}&safeSearch={1}", requestUrl, request.SafeSearch.ToString());

            var responseJson = await this.SendGetAsync(requestUrl);
            var response = JsonConvert.DeserializeObject<VideoSearchResponse>(responseJson);

            return response;
        }

        #endregion Methods
    }
}

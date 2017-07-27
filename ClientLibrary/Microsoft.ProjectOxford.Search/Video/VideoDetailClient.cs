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
    /// Client for interacting with the video detail API.
    /// </summary>
    /// <seealso cref="Microsoft.ProjectOxford.Search.Core.SearchClient" />
    public class VideoDetailClient : SearchClient
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoDetailClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public VideoDetailClient(string apiKey)
            : base(apiKey)
        {
            this.Url = "https://api.cognitive.microsoft.com/bing/v5.0/videos/details";
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the video details.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public VideoDetailResponse GetVideoDetails(VideoDetailRequest request)
        {
            return GetVideoDetailsAsync(request).Result;
        }

        /// <summary>
        /// Gets the video details asynchronously.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<VideoDetailResponse> GetVideoDetailsAsync(VideoDetailRequest request)
        {
            request.Validate();

            var requestUrl = string.Format("{0}?id={1}&modulesRequested=RelatedVideos&modulesRequested=VideoResult", Url, request.Id);

            var responseJson = await SendGetAsync(requestUrl);
            var response = JsonConvert.DeserializeObject<VideoDetailResponse>(responseJson);

            return response;
        }

        #endregion Methods
    }
}

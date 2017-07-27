using Microsoft.ProjectOxford.Search.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Image
{
    /// <summary>
    /// Client to interact with the image search API.
    /// </summary>
    /// <seealso cref="Microsoft.ProjectOxford.Search.Core.SearchClient" />
    public class ImageSearchClient : SearchClient
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchClient" /> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public ImageSearchClient(string apiKey)
                    : base(apiKey)
        {
            this.Url = "https://api.cognitive.microsoft.com/bing/v5.0/images/search";
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the images.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public ImageSearchResponse GetImages(ImageSearchRequest request)
        {
            return GetImagesAsync(request).Result;
        }

        /// <summary>
        /// Gets the images asynchronously.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<ImageSearchResponse> GetImagesAsync(ImageSearchRequest request)
        {
            request.Validate();

            var requestUrl = string.Format("{0}?q={1}", this.Url, request.Query);

            if (request.Count > 0)
                requestUrl = string.Format("{0}&count={1}", requestUrl, request.Count.ToString());

            if (request.Offset > 0)
                requestUrl = string.Format("{0}&offset={1}", requestUrl, request.Offset.ToString());

            if (!string.IsNullOrEmpty(request.Market))
                requestUrl = string.Format("{0}&mkt={1}", requestUrl, request.Market);

            requestUrl = string.Format("{0}&safeSearch={1}", requestUrl, request.SafeSearch.ToString());

            var responseJson = await this.SendGetAsync(requestUrl);
            var response = JsonConvert.DeserializeObject<ImageSearchResponse>(responseJson);

            return response;
        }

        #endregion Methods
    }
}

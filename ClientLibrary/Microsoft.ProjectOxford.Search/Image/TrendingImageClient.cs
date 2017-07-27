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
    /// Client to interact with the trending image API.
    /// </summary>
    /// <seealso cref="Microsoft.ProjectOxford.Search.Core.SearchClient" />
    public class TrendingImageClient : SearchClient
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingImageClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public TrendingImageClient(string apiKey)
            : base(apiKey)
        {
            this.Url = "https://api.cognitive.microsoft.com/bing/v5.0/images/trending";
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the images.
        /// </summary>
        /// <returns></returns>
        public TrendingImageResponse GetImages()
        {
            return GetImagesAsync().Result;
        }

        /// <summary>
        /// Gets the images asynchronously.
        /// </summary>
        /// <returns></returns>
        public async Task<TrendingImageResponse> GetImagesAsync()
        {
            var responseJson = await SendGetAsync(this.Url);
            var response = JsonConvert.DeserializeObject<TrendingImageResponse>(responseJson);

            return response;
        }

        #endregion Methods
    }
}

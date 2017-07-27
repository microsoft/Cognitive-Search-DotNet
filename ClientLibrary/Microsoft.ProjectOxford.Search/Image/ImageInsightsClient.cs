using Microsoft.ProjectOxford.Search.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Image
{
    /// <summary>
    /// Client for interacting with the image insights API.
    /// </summary>
    /// <seealso cref="Microsoft.ProjectOxford.Search.Core.SearchClient" />
    public class ImageInsightsClient : SearchClient
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageInsightsClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public ImageInsightsClient(string apiKey)
            : base(apiKey)
        {
            this.Url = "https://api.cognitive.microsoft.com/bing/v5.0/images/search ";
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the image insights.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public string GetImageInsights(ImageInsightsRequest request)
        {
            return GetImageInsightsAsync(request).Result;
        }

        /// <summary>
        /// Gets the image insights asynchronously.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<string> GetImageInsightsAsync(ImageInsightsRequest request)
        {
            request.Validate();

            //todo

            var responseJson = await this.SendGetAsync("");

            throw new NotImplementedException();
           
            //https://dev.cognitive.microsoft.com/docs/services/56b43f0ccf5ff8098cef3808/operations/571fab09dbe2d933e891028f
        }

        #endregion Methods
    }
}

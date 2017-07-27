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
    /// Client to interact with the category news search API.
    /// </summary>
    /// <seealso cref="Microsoft.ProjectOxford.Search.Core.SearchClient" />
    public class CategoryNewsClient : SearchClient
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryNewsClient" /> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public CategoryNewsClient(string apiKey)
                    : base(apiKey)
        {
            this.Url = "https://api.cognitive.microsoft.com/bing/v5.0/news/?Category=";
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the category news.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public CategoryNewsResponse GetCategoryNews(CategoryNewsRequest request)
        {
            return GetCategoryNewsAsync(request).Result;
        }

        /// <summary>
        /// Gets the category news asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<CategoryNewsResponse> GetCategoryNewsAsync(CategoryNewsRequest request)
        {
            request.Validate();

            var category = GetCategoryForQueryString(request);

            var requestUrl = string.Format("{0}{1}", this.Url, category);

            var responseJson = await this.SendGetAsync(requestUrl);
            var response = JsonConvert.DeserializeObject<CategoryNewsResponse>(responseJson);

            return response;
        }

        /// <summary>
        /// Gets the category for query string.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        private string GetCategoryForQueryString(CategoryNewsRequest request)
        {
            if(request.Category == Category.UsUk)
            {
                return "US/UK";
            }
            else
            {
                return request.Category.ToString();
            }
        }

        #endregion Methods
    }
}

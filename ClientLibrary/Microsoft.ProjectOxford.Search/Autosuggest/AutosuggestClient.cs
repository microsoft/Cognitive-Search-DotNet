using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ProjectOxford.Search.Core;
using Newtonsoft.Json;
using System.Net;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    /// <summary>
    /// Client for interacting with the search autosuggest API.
    /// </summary>
    /// <seealso cref="Microsoft.ProjectOxford.Search.Core.SearchClient" />
    public class AutosuggestClient : SearchClient
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AutosuggestClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public AutosuggestClient(string apiKey)
            : base(apiKey)
        {
            this.Url = "https://api.cognitive.microsoft.com/bing/v5.0/suggestions";
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the suggestions.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public AutosuggestResponse GetSuggestions(AutosuggestRequest request)
        {
            return GetSuggestionsAsync(request).Result;
        }

        /// <summary>
        /// Gets the suggestions asynchronously.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<AutosuggestResponse> GetSuggestionsAsync(AutosuggestRequest request)
        {
            var requestUrl = string.Format("{0}/?q={1}", this.Url, WebUtility.UrlEncode(request.Query));

            if (!string.IsNullOrEmpty(request.Market))
                requestUrl = string.Format("{0}&mkt={1}", requestUrl, request.Market);

            var responseJson = await this.SendGetAsync(requestUrl);
            var response = JsonConvert.DeserializeObject<AutosuggestResponse>(responseJson);

            return response;
        }

        #endregion Methods
    }
}

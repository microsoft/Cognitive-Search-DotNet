using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Web
{
    /// <summary>
    /// Web pages returned by web search API.
    /// </summary>
    public class WebPages
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WebPages"/> class.
        /// </summary>
        public WebPages()
        {
            Results = new List<WebPageResult>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the web search URL.
        /// </summary>
        /// <value>
        /// The web search URL.
        /// </value>
        [JsonProperty("webSearchUrl")]
        public string WebSearchUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the web search URL ping suffix.
        /// </summary>
        /// <value>
        /// The web search URL ping suffix.
        /// </value>
        [JsonProperty("webSearchUrlPingSuffix")]
        public string WebSearchUrlPingSuffix
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the total estimated matches.
        /// </summary>
        /// <value>
        /// The total estimated matches.
        /// </value>
        [JsonProperty("totalEstimatedMatches")]
        public int TotalEstimatedMatches
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the results.
        /// </summary>
        /// <value>
        /// The results.
        /// </value>
        [JsonProperty("value")]
        public List<WebPageResult> Results
        {
            get;
            set;
        }

        #endregion Properties
    }
}

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.News
{
    /// <summary>
    /// Result from trending topic API.
    /// </summary>
    public class TrendingTopicResult
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingTopicResult"/> class.
        /// </summary>
        public TrendingTopicResult()
        {
            Image = new TrendingTopicImage();
            Query = new Query();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        [JsonProperty("image")]
        public TrendingTopicImage Image
        {
            get;
            set;
        }

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
        /// Gets or sets a value indicating whether this instance is breaking news.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is breaking news; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("isBreakingNews")]
        public bool IsBreakingNews
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>
        /// The query.
        /// </value>
        [JsonProperty("query")]
        public Query Query
        {
            get;
            set;
        }

        #endregion Properties
    }
}

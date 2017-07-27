using Microsoft.ProjectOxford.Search.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Web
{
    /// <summary>
    /// Response from web search API.
    /// </summary>
    public class WebSearchResponse
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchResponse"/> class.
        /// </summary>
        public WebSearchResponse()
        {
            Instrumentation = new Instrumentation();
            WebPages = new WebPages();
            Images = new Images();
            News = new News();
            RelatedSearches = new RelatedSearches();
            Videos = new Videos();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonProperty("_type")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the instrumentation.
        /// </summary>
        /// <value>
        /// The instrumentation.
        /// </value>
        [JsonProperty("instrumentation")]
        public Instrumentation Instrumentation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the web pages.
        /// </summary>
        /// <value>
        /// The web pages.
        /// </value>
        [JsonProperty("webPages")]
        public WebPages WebPages
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        [JsonProperty("images")]
        public Images Images
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the news.
        /// </summary>
        /// <value>
        /// The news.
        /// </value>
        [JsonProperty("news")]
        public News News
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the related searches.
        /// </summary>
        /// <value>
        /// The related searches.
        /// </value>
        [JsonProperty("relatedSearches")]
        public RelatedSearches RelatedSearches
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the videos.
        /// </summary>
        /// <value>
        /// The videos.
        /// </value>
        [JsonProperty("videos")]
        public Videos Videos
        {
            get;
            set;
        }

        #endregion Properties
    }
}

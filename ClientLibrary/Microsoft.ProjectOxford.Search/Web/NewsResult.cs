using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Web
{
    /// <summary>
    /// Detailed news result returned by web search API.
    /// </summary>
    public class NewsResult
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NewsResult" /> class.
        /// </summary>
        public NewsResult()
        {
            Image = new NewsImage();
            About = new List<NewsAbout>();
            Provider = new List<NewsProvider>();
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
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the URL ping suffix.
        /// </summary>
        /// <value>
        /// The URL ping suffix.
        /// </value>
        [JsonProperty("urlPingSuffix")]
        public string UrlPingSuffix
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
        public NewsImage Image
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [JsonProperty("description")]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the about.
        /// </summary>
        /// <value>
        /// The about.
        /// </value>
        [JsonProperty("about")]
        public List<NewsAbout> About
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        [JsonProperty("provider")]
        public List<NewsProvider> Provider
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the date published.
        /// </summary>
        /// <value>
        /// The date published.
        /// </value>
        [JsonProperty("datePublished")]
        public DateTime DatePublished
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        [JsonProperty("category")]
        public string Category
        {
            get;
            set;
        }

        #endregion Properties
    }
}

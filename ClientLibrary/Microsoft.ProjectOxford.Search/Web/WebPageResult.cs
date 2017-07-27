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
    public class WebPageResult
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WebPageResult" /> class.
        /// </summary>
        public WebPageResult()
        {
            About = new List<WebPageAbout>();
            DeepLinks = new List<WebPageDeepLink>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public string Id
        {
            get;
            set;
        }

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
        /// Gets or sets the about.
        /// </summary>
        /// <value>
        /// The about.
        /// </value>
        [JsonProperty("about")]
        public List<WebPageAbout> About
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the display URL.
        /// </summary>
        /// <value>
        /// The display URL.
        /// </value>
        [JsonProperty("displayUrl")]
        public string DisplayUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the snippet.
        /// </summary>
        /// <value>
        /// The snippet.
        /// </value>
        [JsonProperty("snippet")]
        public string Snippet
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the deep links.
        /// </summary>
        /// <value>
        /// The deep links.
        /// </value>
        [JsonProperty("deepLinks")]
        public List<WebPageDeepLink> DeepLinks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the date last crawled.
        /// </summary>
        /// <value>
        /// The date last crawled.
        /// </value>
        [JsonProperty("dateLastCrawled")]
        public DateTime DateLastCrawled
        {
            get;
            set;
        }

        #endregion Properties
    }
}

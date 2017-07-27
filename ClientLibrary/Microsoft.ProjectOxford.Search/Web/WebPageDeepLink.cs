using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Web
{
    /// <summary>
    /// Deep links for web search API.
    /// </summary>
    public class WebPageDeepLink
    {
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

        #endregion
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    /// <summary>
    /// Search suggestion returned by the search autosuggest API.
    /// </summary>
    public class SearchSuggestion
    {
        #region Properties

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
        /// Gets or sets the display text.
        /// </summary>
        /// <value>
        /// The display text.
        /// </value>
        [JsonProperty("displayText")]
        public string DisplayText
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
        public string Query
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the kind of the search.
        /// </summary>
        /// <value>
        /// The kind of the search.
        /// </value>
        [JsonProperty("documents")]
        public string SearchKind
        {
            get;
            set;
        }

        #endregion Properties
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Web
{
    /// <summary>
    /// Videos returned by the web search API.
    /// </summary>
    public class Videos
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Videos"/> class.
        /// </summary>
        public Videos()
        {
            Results = new List<VideoResult>();
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
        /// Gets or sets the read link.
        /// </summary>
        /// <value>
        /// The read link.
        /// </value>
        [JsonProperty("readLink")]
        public string ReadLink
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
        /// Gets or sets a value indicating whether this instance is family friendly.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is family friendly; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("isFamilyFriendly")]
        public bool IsFamilyFriendly
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
        public List<VideoResult> Results
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the scenario.
        /// </summary>
        /// <value>
        /// The scenario.
        /// </value>
        [JsonProperty("scenario")]
        public string Scenario
        {
            get;
            set;
        }

        #endregion Properties
    }
}

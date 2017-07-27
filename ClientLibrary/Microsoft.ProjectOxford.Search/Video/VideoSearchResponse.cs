using Microsoft.ProjectOxford.Search.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Video
{
    /// <summary>
    /// Response from video search API.
    /// </summary>
    public class VideoSearchResponse
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSearchResponse" /> class.
        /// </summary>
        public VideoSearchResponse()
        {
            this.Instrumentation = new Instrumentation();
            this.Videos = new List<Video>();
            this.QueryExpansions = new List<QueryExpansion>();
            this.PivotSuggestions = new List<PivotSuggestion>();
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
        /// Gets or sets the total estimated matches.
        /// </summary>
        /// <value>
        /// The total estimated matches.
        /// </value>
        [JsonProperty("totalEstimatedMatches")]
        public string TotalEstimatedMatches
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
        [JsonProperty("value")]
        public List<Video> Videos
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the next offset add count.
        /// </summary>
        /// <value>
        /// The next offset add count.
        /// </value>
        [JsonProperty("nextOffsetAddCount")]
        public int NextOffsetAddCount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the query expansions.
        /// </summary>
        /// <value>
        /// The query expansions.
        /// </value>
        [JsonProperty("queryExpansions")]
        public List<QueryExpansion> QueryExpansions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pivot suggestions.
        /// </summary>
        /// <value>
        /// The pivot suggestions.
        /// </value>
        [JsonProperty("pivotSuggestions")]
        public List<PivotSuggestion> PivotSuggestions
        {
            get;
            set;
        }

        #endregion Properties
    }
}

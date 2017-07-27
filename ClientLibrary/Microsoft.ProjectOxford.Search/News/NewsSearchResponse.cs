using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.News
{
    /// <summary>
    /// Response from news search API.
    /// </summary>
    public class NewsSearchResponse
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NewsSearchResponse"/> class.
        /// </summary>
        public NewsSearchResponse()
        {
            Sort = new List<NewsSort>();
            Results = new List<NewsSearchResult>();
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
        /// Gets or sets the sort.
        /// </summary>
        /// <value>
        /// The sort.
        /// </value>
        [JsonProperty("sort")]
        public List<NewsSort> Sort
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
        public List<NewsSearchResult> Results
        {
            get;
            set;
        }

        #endregion Properties
    }
}

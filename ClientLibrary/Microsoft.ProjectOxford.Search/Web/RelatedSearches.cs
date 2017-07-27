using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Web
{
    /// <summary>
    /// Related searches returned by web search API.
    /// </summary>
    public class RelatedSearches
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedSearches"/> class.
        /// </summary>
        public RelatedSearches()
        {
            Results = new List<RelatedSearchResult>();
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
        /// Gets or sets the results.
        /// </summary>
        /// <value>
        /// The results.
        /// </value>
        [JsonProperty("value")]
        public List<RelatedSearchResult> Results
        {
            get;
            set;
        }

        #endregion Properties
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    /// <summary>
    /// Response from the search autosuggest API.
    /// </summary>
    public class AutosuggestResponse
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AutosuggestResponse"/> class.
        /// </summary>
        public AutosuggestResponse()
        {
            this.QueryContext = new QueryContext();
            this.SuggestionGroups = new List<SuggestionGroup>();
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
        /// Gets or sets the query context.
        /// </summary>
        /// <value>
        /// The query context.
        /// </value>
        [JsonProperty("queryConext")]
        public QueryContext QueryContext
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the suggestion groups.
        /// </summary>
        /// <value>
        /// The suggestion groups.
        /// </value>
        [JsonProperty("suggestionGroups")]
        public List<SuggestionGroup> SuggestionGroups
        {
            get;
            set;
        }

        #endregion Properties
    }
}

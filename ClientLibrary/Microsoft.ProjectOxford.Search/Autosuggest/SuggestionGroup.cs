using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    /// <summary>
    /// Suggestion group returned by the search autosuggest API.
    /// </summary>
    public class SuggestionGroup
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestionGroup"/> class.
        /// </summary>
        public SuggestionGroup()
        {
            this.SearchSuggestions = new List<SearchSuggestion>();
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
        /// Gets or sets the search suggestions.
        /// </summary>
        /// <value>
        /// The search suggestions.
        /// </value>
        [JsonProperty("searchSuggestions")]
        public List<SearchSuggestion> SearchSuggestions
        {
            get;
            set;
        }

        #endregion Properties
    }
}

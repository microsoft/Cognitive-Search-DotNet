using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Core
{
    /// <summary>
    /// Pivot suggestion returned by search API's.
    /// </summary>
    public class PivotSuggestion
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PivotSuggestion"/> class.
        /// </summary>
        public PivotSuggestion()
        {
            this.Suggestions = new List<Suggestion>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the pivot.
        /// </summary>
        /// <value>
        /// The pivot.
        /// </value>
        [JsonProperty("pivot")]
        public string Pivot
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the suggestions.
        /// </summary>
        /// <value>
        /// The suggestions.
        /// </value>
        [JsonProperty("suggestions")]
        public List<Suggestion> Suggestions
        {
            get;
            set;
        }

        #endregion
    }
}

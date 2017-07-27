using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    /// <summary>
    /// Query context returned by the search autosuggest API.
    /// </summary>
    public class QueryContext
    {
        #region Properties

        /// <summary>
        /// Gets or sets the original query.
        /// </summary>
        /// <value>
        /// The original query.
        /// </value>
        [JsonProperty("originalQuery")]
        public string OriginalQuery
        {
            get;
            set;
        }

        #endregion Properties
    }
}

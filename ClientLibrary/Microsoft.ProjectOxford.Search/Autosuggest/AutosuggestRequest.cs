using Microsoft.ProjectOxford.Search.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Autosuggest
{
    /// <summary>
    /// Request for interacting with the search autosuggest API.
    /// </summary>
    /// <seealso cref="Microsoft.ProjectOxford.Search.Core.ISearchRequest" />
    public class AutosuggestRequest : ISearchRequest
    {
        #region Properties

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>
        /// The query.
        /// </value>
        public string Query
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the market.
        /// </summary>
        /// <value>
        /// The market.
        /// </value>
        public string Market
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Validates this instance.
        /// </summary>
        /// <exception cref="QueryNotSpecifiedException"></exception>
        public void Validate()
        {
            if (String.IsNullOrWhiteSpace(this.Query))
            {
                throw new QueryNotSpecifiedException();
            }
        }

        #endregion Methods
    }
}

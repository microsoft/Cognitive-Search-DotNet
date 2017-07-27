using Microsoft.ProjectOxford.Search.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Image
{
    /// <summary>
    /// Request for interacting with the image search API.
    /// </summary>
    /// <seealso cref="Microsoft.ProjectOxford.Search.Core.ISearchRequest" />
    public class ImageSearchRequest : ISearchRequest
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchRequest" /> class.
        /// </summary>
        public ImageSearchRequest()
        {
            this.SafeSearch = SafeSearch.Moderate;
            this.Count = 0;
            this.Offset = 0;
        }

        #endregion Constructors

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
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        /// <value>
        /// The offset.
        /// </value>
        public int Offset
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

        /// <summary>
        /// Gets or sets the safe search.
        /// </summary>
        /// <value>
        /// The safe search.
        /// </value>
        public SafeSearch SafeSearch
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

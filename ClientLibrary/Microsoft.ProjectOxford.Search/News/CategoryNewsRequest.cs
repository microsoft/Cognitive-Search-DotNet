using Microsoft.ProjectOxford.Search.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.News
{
    /// <summary>
    /// Request for interacting with the category news API.
    /// </summary>
    public class CategoryNewsRequest : ISearchRequest
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryNewsRequest" /> class.
        /// </summary>
        public CategoryNewsRequest() { }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The query.
        /// </value>
        public Category Category
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
            
        }

        #endregion Methods
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.News
{
    /// <summary>
    /// Response from category news APi.
    /// </summary>
    public class CategoryNewsResponse
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryNewsResponse"/> class.
        /// </summary>
        public CategoryNewsResponse()
        {
            Results = new List<CategoryNewsResult>();
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
        /// Gets or sets the results.
        /// </summary>
        /// <value>
        /// The results.
        /// </value>
        [JsonProperty("value")]
        public List<CategoryNewsResult> Results
        {
            get;
            set;
        }

        #endregion Properties
    }
}

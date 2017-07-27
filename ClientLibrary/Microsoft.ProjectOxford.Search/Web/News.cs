using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Web
{
    /// <summary>
    /// News articles returned by web search API.
    /// </summary>
    public class News
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="News" /> class.
        /// </summary>
        public News()
        {
            Results = new List<NewsResult>();
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
        /// Gets or sets the results.
        /// </summary>
        /// <value>
        /// The results.
        /// </value>
        [JsonProperty("value")]
        public List<NewsResult> Results
        {
            get;
            set;
        }

        #endregion Properties
    }
}

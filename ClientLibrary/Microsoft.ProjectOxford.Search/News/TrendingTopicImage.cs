using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.News
{
    /// <summary>
    /// Image for trending topic API.
    /// </summary>
    public class TrendingTopicImage
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingTopicImage" /> class.
        /// </summary>
        public TrendingTopicImage()
        {
            Providers = new List<Provider>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the providers.
        /// </summary>
        /// <value>
        /// The providers.
        /// </value>
        [JsonProperty("provider")]
        public List<Provider> Providers
        {
            get;
            set;
        }

        #endregion Properties
    }
}

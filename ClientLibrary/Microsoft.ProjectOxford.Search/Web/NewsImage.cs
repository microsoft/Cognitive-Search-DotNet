using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Web
{
    /// <summary>
    /// IMage for news article returned by web search API.
    /// </summary>
    public class NewsImage
    {
        #region Constructors

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the thumbnail.
        /// </summary>
        /// <value>
        /// The thumbnail.
        /// </value>
        [JsonProperty("thumbnail")]
        public NewsThumbnail Thumbnail
        {
            get;
            set;
        }

        #endregion Properties
    }
}

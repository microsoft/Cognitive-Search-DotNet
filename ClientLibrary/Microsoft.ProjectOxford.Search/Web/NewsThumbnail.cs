using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Web
{
    /// <summary>
    /// Thumbnail for news results returned by web search API.
    /// </summary>
    public class NewsThumbnail
    {
        #region Properties

        /// <summary>
        /// Gets or sets the content URL.
        /// </summary>
        /// <value>
        /// The content URL.
        /// </value>
        [JsonProperty("contentUrl")]
        public string ContentUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        [JsonProperty("height")]
        public int Height
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        [JsonProperty("width")]
        public int Width
        {
            get;
            set;
        }

        #endregion Properties
    }
}

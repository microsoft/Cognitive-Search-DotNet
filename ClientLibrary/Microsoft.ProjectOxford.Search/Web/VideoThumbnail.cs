using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Web
{
    /// <summary>
    /// Video thumbnail returned by web search API.
    /// </summary>
    public class VideoThumbnail
    {
        #region Properties

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

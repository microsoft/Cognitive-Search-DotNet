using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Core
{
    /// <summary>
    /// Thumbnail returned from search API's.
    /// </summary>
    public class Thumbnail
    {
        #region Properties

        /// <summary>
        /// Gets or sets the thumbnail URL.
        /// </summary>
        /// <value>
        /// The thumbnail URL.
        /// </value>
        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl
        {
            get;
            set;
        }

        #endregion Properties
    }
}

using Microsoft.ProjectOxford.Search.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Image
{
    /// <summary>
    /// Tile image returned from the trending images API.
    /// </summary>
    public class TileImage
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TileImage" /> class.
        /// </summary>
        public TileImage()
        {
            Thumbnail = new ThumbnailDimensions();
        }

        #endregion Constructors

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
        /// Gets or sets the thumbnail.
        /// </summary>
        /// <value>
        /// The thumbnail.
        /// </value>
        [JsonProperty("thumbnail")]
        public ThumbnailDimensions Thumbnail
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the image identifier.
        /// </summary>
        /// <value>
        /// The image identifier.
        /// </value>
        [JsonProperty("imageId")]
        public string ImageId
        {
            get;
            set;
        }

        #endregion Properties
    }
}

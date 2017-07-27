using Microsoft.ProjectOxford.Search.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Video
{
    /// <summary>
    /// Response from trending video API.
    /// </summary>
    public class TrendingVideoResponse
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingVideoResponse"/> class.
        /// </summary>
        public TrendingVideoResponse()
        {
            this.Instrumentation = new Instrumentation();
            this.BannerTiles = new List<Tile>();
            this.Categories = new List<Category>();
        }

        #endregion

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
        /// Gets or sets the instrumentation.
        /// </summary>
        /// <value>
        /// The instrumentation.
        /// </value>
        [JsonProperty("instrumentation")]
        public Instrumentation Instrumentation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the banner tiles.
        /// </summary>
        /// <value>
        /// The banner tiles.
        /// </value>
        [JsonProperty("bannerTiles")]
        public List<Tile> BannerTiles
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>
        /// The categories.
        /// </value>
        [JsonProperty("categories")]
        public List<Category> Categories
        {
            get;
            set;
        }

        #endregion Properties
    }
}

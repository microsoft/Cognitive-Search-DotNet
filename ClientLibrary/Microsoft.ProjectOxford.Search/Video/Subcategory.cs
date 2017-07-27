using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Video
{
    /// <summary>
    /// Subcategory returned from the video details API.
    /// </summary>
    public class Subcategory
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Subcategory"/> class.
        /// </summary>
        public Subcategory()
        {
            this.Tiles = new List<Tile>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the tiles.
        /// </summary>
        /// <value>
        /// The tiles.
        /// </value>
        [JsonProperty("tiles")]
        public List<Tile> Tiles
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }

        #endregion Properties
    }
}

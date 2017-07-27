using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Image
{
    /// <summary>
    /// Tile returned by the trending images API.
    /// </summary>
    public class Tile
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Tile" /> class.
        /// </summary>
        public Tile()
        {
            Query = new TileQuery();
            Image = new TileImage();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>
        /// The query.
        /// </value>
        [JsonProperty("query")]
        public TileQuery Query
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        [JsonProperty("image")]
        public TileImage Image
        {
            get;
            set;
        }

        #endregion Properties
    }
}

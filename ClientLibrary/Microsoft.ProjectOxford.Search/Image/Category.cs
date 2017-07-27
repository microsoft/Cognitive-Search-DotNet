using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Image
{
    /// <summary>
    /// Category returned by trending images API.
    /// </summary>
    public class Category
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        public Category()
        {
            Tiles = new List<Tile>();
        }

        #endregion Constructors

        #region Properties

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

        #endregion Properties
    }
}

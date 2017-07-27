using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Video
{
    /// <summary>
    /// Category returned from video detail API.
    /// </summary>
    public class Category
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        public Category()
        {
            this.Subcategories = new List<Subcategory>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the subcategories.
        /// </summary>
        /// <value>
        /// The subcategories.
        /// </value>
        [JsonProperty("subcategories")]
        public List<Subcategory> Subcategories
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

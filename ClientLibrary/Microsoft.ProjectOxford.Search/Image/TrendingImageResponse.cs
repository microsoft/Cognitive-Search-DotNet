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
    /// Response from trending image API.
    /// </summary>
    public class TrendingImageResponse
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingImageResponse"/> class.
        /// </summary>
        public TrendingImageResponse()
        {
            Instrumentation = new Instrumentation();
            Categories = new List<Category>();
        }

        #endregion Constructors

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

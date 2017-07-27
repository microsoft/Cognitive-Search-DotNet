using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Image
{
    /// <summary>
    /// Insights sources summary returned from image search API.
    /// </summary>
    public class InsightsSourcesSummary
    {
        #region Properties

        /// <summary>
        /// Gets or sets the shopping sources count.
        /// </summary>
        /// <value>
        /// The shopping sources count.
        /// </value>
        [JsonProperty("shoppingSourcesCount")]
        public int ShoppingSourcesCount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the recipe sources count.
        /// </summary>
        /// <value>
        /// The recipe sources count.
        /// </value>
        [JsonProperty("recipeSourcesCount")]
        public int RecipeSourcesCount
        {
            get;
            set;
        }

        #endregion Properties
    }
}

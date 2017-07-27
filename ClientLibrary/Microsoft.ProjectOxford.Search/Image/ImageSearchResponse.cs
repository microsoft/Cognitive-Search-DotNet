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
    /// Response from image search API.
    /// </summary>
    public class ImageSearchResponse
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchResponse" /> class.
        /// </summary>
        public ImageSearchResponse()
        {
            Instrumentation = new Instrumentation();
            Images = new List<Image>();
            QueryExpansions = new List<QueryExpansion>();
            PivotSuggestions = new List<PivotSuggestion>();
            SimilarTerms = new List<SimilarTerm>();
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
        /// Gets or sets the web search URL.
        /// </summary>
        /// <value>
        /// The web search URL.
        /// </value>
        [JsonProperty("webSearchUrl")]
        public string WebSearchUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the total estimated matches.
        /// </summary>
        /// <value>
        /// The total estimated matches.
        /// </value>
        [JsonProperty("totalEstimatedMatches")]
        public int TotalEstimatedMatches
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        [JsonProperty("value")]
        public List<Image> Images
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the query expansions.
        /// </summary>
        /// <value>
        /// The query expansions.
        /// </value>
        [JsonProperty("queryExpansions")]
        public List<QueryExpansion> QueryExpansions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the next offset add count.
        /// </summary>
        /// <value>
        /// The next offset add count.
        /// </value>
        [JsonProperty("nextOffsetAddCount")]
        public int NextOffsetAddCount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the pivot suggestions.
        /// </summary>
        /// <value>
        /// The pivot suggestions.
        /// </value>
        [JsonProperty("pivotSuggestions")]
        public List<PivotSuggestion> PivotSuggestions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether [display shipping sources badges].
        /// </summary>
        /// <value>
        /// <c>true</c> if [display shipping sources badges]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("displayShoppingSourcesBadges")]
        public bool DisplayShippingSourcesBadges
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether [display recipe sources badges].
        /// </summary>
        /// <value>
        /// <c>true</c> if [display recipe sources badges]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("displayRecipeSourcesBadges")]
        public bool DisplayRecipeSourcesBadges
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the similar terms.
        /// </summary>
        /// <value>
        /// The similar terms.
        /// </value>
        [JsonProperty("similarTerms")]
        public List<SimilarTerm> SimilarTerms
        {
            get;
            set;
        }

        #endregion Properties
    }
}

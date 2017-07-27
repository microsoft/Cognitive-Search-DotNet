using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ProjectOxford.Search.Core;

namespace Microsoft.ProjectOxford.Search.Core
{
    /// <summary>
    /// Suggestiong returned by search API's.
    /// </summary>
    public class Suggestion
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Suggestion"/> class.
        /// </summary>
        public Suggestion()
        {
            this.Thumbnail = new Thumbnail();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the display text.
        /// </summary>
        /// <value>
        /// The display text.
        /// </value>
        [JsonProperty("displayText")]
        public string DisplayText
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
        /// Gets or sets the web search URL ping suffix.
        /// </summary>
        /// <value>
        /// The web search URL ping suffix.
        /// </value>
        [JsonProperty("webSearchUrlPingSuffix")]
        public string WebSearchUrlPingSuffix
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the search link.
        /// </summary>
        /// <value>
        /// The search link.
        /// </value>
        [JsonProperty("searchLink")]
        public string SearchLink
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
        public Thumbnail Thumbnail
        {
            get;
            set;
        }

        #endregion Properties
    }
}

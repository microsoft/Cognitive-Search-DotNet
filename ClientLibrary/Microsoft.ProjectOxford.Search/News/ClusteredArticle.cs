using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.News
{
    /// <summary>
    /// 
    /// </summary>
    public class ClusteredArticle
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusteredArticle"/> class.
        /// </summary>
        public ClusteredArticle()
        {
            About = new List<About>();
            Mentions = new List<Mention>();
            Provider = new List<Provider>();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [JsonProperty("description")]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the about.
        /// </summary>
        /// <value>
        /// The about.
        /// </value>
        [JsonProperty("about")]
        public List<About> About
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the mentions.
        /// </summary>
        /// <value>
        /// The mentions.
        /// </value>
        [JsonProperty("mentions")]
        public List<Mention> Mentions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        [JsonProperty("provider")]
        public List<Provider> Provider
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the date published.
        /// </summary>
        /// <value>
        /// The date published.
        /// </value>
        [JsonProperty("datePublished")]
        public DateTime DatePublished
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        [JsonProperty("category")]
        public string Category
        {
            get;
            set;
        }

        #endregion Properties
    }
}

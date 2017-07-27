using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.News
{
    /// <summary>
    /// Results from category news search API.
    /// </summary>
    public class CategoryNewsResult
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryNewsResult"/> class.
        /// </summary>
        public CategoryNewsResult()
        {
            Image = new Image();
            About = new List<About>();
            Provider = new List<Provider>();
            ClusteredArticles = new List<ClusteredArticle>();
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
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        [JsonProperty("image")]
        public Image Image
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

        /// <summary>
        /// Gets or sets the clustered articles.
        /// </summary>
        /// <value>
        /// The clustered articles.
        /// </value>
        [JsonProperty("clusteredArticles")]
        public List<ClusteredArticle> ClusteredArticles
        {
            get;
            set;
        }

        #endregion Properties
    }
}

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
    /// Image returned from the image search API.
    /// </summary>
    public class Image
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Image"/> class.
        /// </summary>
        public Image()
        {
            Thumbnail = new Thumbnail();
            InsightsSourcesSummary = new InsightsSourcesSummary();
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
        /// Gets or sets the thumbnail URL.
        /// </summary>
        /// <value>
        /// The thumbnail URL.
        /// </value>
        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl
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
        /// Gets or sets the content URL.
        /// </summary>
        /// <value>
        /// The content URL.
        /// </value>
        [JsonProperty("contentUrl")]
        public string ContentUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the host page URL.
        /// </summary>
        /// <value>
        /// The host page URL.
        /// </value>
        [JsonProperty("hostPageUrl")]
        public string HostPageUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the size of the content.
        /// </summary>
        /// <value>
        /// The size of the content.
        /// </value>
        [JsonProperty("contentSize")]
        public string ContentSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the encoding format.
        /// </summary>
        /// <value>
        /// The encoding format.
        /// </value>
        [JsonProperty("encodingFormat")]
        public string EncodingFormat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the host page display URL.
        /// </summary>
        /// <value>
        /// The host page display URL.
        /// </value>
        [JsonProperty("hostPageDisplayUrl")]
        public string HostPageDisplayUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        [JsonProperty("width")]
        public int Width
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        [JsonProperty("height")]
        public int Height
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

        /// <summary>
        /// Gets or sets the image insights token.
        /// </summary>
        /// <value>
        /// The image insights token.
        /// </value>
        [JsonProperty("imageInsightsToken")]
        public string ImageInsightsToken
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the insight sources summary.
        /// </summary>
        /// <value>
        /// The insight sources summary.
        /// </value>
        [JsonProperty("insightsSourcesSummar")]
        public InsightsSourcesSummary InsightsSourcesSummary
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the image identifier.
        /// </summary>
        /// <value>
        /// The image identifier.
        /// </value>
        [JsonProperty("imageId")]
        public string ImageId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the color of the accent.
        /// </summary>
        /// <value>
        /// The color of the accent.
        /// </value>
        [JsonProperty("accentColor")]
        public string AccentColor
        {
            get;
            set;
        }

        #endregion Properties
    }
}

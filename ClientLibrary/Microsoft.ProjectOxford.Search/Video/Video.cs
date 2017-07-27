using Microsoft.ProjectOxford.Search.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Video
{
    /// <summary>
    /// Video returned by video search API.
    /// </summary>
    public class Video
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Video"/> class.
        /// </summary>
        public Video()
        {
            this.Publisher = new List<Publisher>();
            this.Creator = new Creator();
            this.Thumbnail = new ThumbnailDimensions();
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
        /// Gets or sets the publisher.
        /// </summary>
        /// <value>
        /// The publisher.
        /// </value>
        [JsonProperty("publisher")]
        public List<Publisher> Publisher
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the creator.
        /// </summary>
        /// <value>
        /// The creator.
        /// </value>
        [JsonProperty("creator")]
        public Creator Creator
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
        /// Gets or sets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        [JsonProperty("duration")]
        public string Duration
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the motion thumbnail URL.
        /// </summary>
        /// <value>
        /// The motion thumbnail URL.
        /// </value>
        [JsonProperty("motionThumbnailUrl")]
        public string MotionThumbnailUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the embed HTML.
        /// </summary>
        /// <value>
        /// The embed HTML.
        /// </value>
        [JsonProperty("embedHtml")]
        public string EmbedHtml
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether [allow HTTPS embed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow HTTPS embed]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("allowHttpsEmbed")]
        public bool AllowHttpsEmbed
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the view count.
        /// </summary>
        /// <value>
        /// The view count.
        /// </value>
        [JsonProperty("viewCount")]
        public int ViewCount
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
        public ThumbnailDimensions Thumbnail
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the video identifier.
        /// </summary>
        /// <value>
        /// The video identifier.
        /// </value>
        [JsonProperty("videoId")]
        public string VideoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether [allow mobile embed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow mobile embed]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("allowMobileEmbed")]
        public bool AllowMobileEmbed
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is super fresh.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is super fresh; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("isSuperfresh")]
        public bool IsSuperFresh
        {
            get;
            set;
        }

        #endregion Properties
    }
}

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
    /// Response from video detail API.
    /// </summary>
    public class VideoDetailResponse
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoDetailResponse"/> class.
        /// </summary>
        public VideoDetailResponse()
        {
            this.Instrumentation = new Instrumentation();
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
        /// Gets or sets the related videos.
        /// </summary>
        /// <value>
        /// The related videos.
        /// </value>
        [JsonProperty("relatedVideos")]
        public List<Video> RelatedVideos
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the video result.
        /// </summary>
        /// <value>
        /// The video result.
        /// </value>
        [JsonProperty("videoResult")]
        public Video VideoResult
        {
            get;
            set;
        }

        #endregion Properties
    }
}

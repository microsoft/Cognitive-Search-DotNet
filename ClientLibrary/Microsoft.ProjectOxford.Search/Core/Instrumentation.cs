using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Core
{
    /// <summary>
    /// Instrumentation returned from video search API.
    /// </summary>
    public class Instrumentation
    {
        #region Properties

        /// <summary>
        /// Gets or sets the page load ping URL.
        /// </summary>
        /// <value>
        /// The page load ping URL.
        /// </value>
        [JsonProperty("pageLoadPingUrl")]
        public string PageLoadPingUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ping URL base.
        /// </summary>
        /// <value>
        /// The ping URL base.
        /// </value>
        [JsonProperty("pingUrlBase")]
        public string PingUrlBase
        {
            get;
            set;
        }

        #endregion
    }
}

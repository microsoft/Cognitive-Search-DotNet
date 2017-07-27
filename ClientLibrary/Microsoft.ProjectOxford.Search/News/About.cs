using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.News
{
    /// <summary>
    /// About data returned by News API.
    /// </summary>
    public class About
    {
        #region Properties

        /// <summary>
        /// Gets or sets the read link.
        /// </summary>
        /// <value>
        /// The read link.
        /// </value>
        [JsonProperty("readLink")]
        public string ReadLink
        {
            get;
            set;
        }

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

        #endregion Properties
    }
}

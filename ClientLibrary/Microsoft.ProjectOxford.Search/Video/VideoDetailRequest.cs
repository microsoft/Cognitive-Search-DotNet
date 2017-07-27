using Microsoft.ProjectOxford.Search.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Video
{
    /// <summary>
    /// Request for interacting with the video detail API.
    /// </summary>
    /// <seealso cref="Microsoft.ProjectOxford.Search.Core.ISearchRequest" />
    public class VideoDetailRequest : ISearchRequest
    {
        #region Properties

        #endregion Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id
        {
            get;
            set;
        }

        #region Methods

        /// <summary>
        /// Validates this instance.
        /// </summary>
        public void Validate()
        {
            if(string.IsNullOrEmpty(this.Id))
            {
                throw new IdNotSpecifiedException();
            }
        }

        #endregion Methods
    }
}

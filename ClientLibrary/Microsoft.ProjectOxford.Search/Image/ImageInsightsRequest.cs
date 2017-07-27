using Microsoft.ProjectOxford.Search.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Image
{
    /// <summary>
    /// Request for interacting with the image insights API.
    /// </summary>
    /// <seealso cref="Microsoft.ProjectOxford.Search.Core.ISearchRequest" />
    public class ImageInsightsRequest : ISearchRequest
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageInsightsRequest"/> class.
        /// </summary>
        public ImageInsightsRequest()
        {
            ContentType = "multipart/form-data";
        }


        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the type of the content.
        /// </summary>
        /// <value>
        /// The type of the content.
        /// </value>
        public string ContentType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the image data.
        /// </summary>
        /// <value>
        /// The image data.
        /// </value>
        public byte[] ImageData
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Validates this instance.
        /// </summary>
        /// <exception cref="Microsoft.ProjectOxford.Search.Image.ImageDataNotProvidedException"></exception>
        public void Validate()
        {
            if(ImageData == null || ImageData.Length <= 0)
            {
                throw new ImageDataNotProvidedException();
            }
        }

        #endregion Methods
    }
}

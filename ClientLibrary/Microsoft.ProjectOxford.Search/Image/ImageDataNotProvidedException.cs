using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Image
{
    /// <summary>
    /// Exception thrown when image data is not provided.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ImageDataNotProvidedException : Exception
    {
        #region Properties

        /// <summary>
        /// Gets a message that describes the current exception.
        /// </summary>
        public override string Message
        {
            get
            {
                return "Image data not provided.";
            }
        }

        #endregion Properties
    }
}

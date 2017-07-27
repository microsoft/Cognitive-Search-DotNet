using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Core
{
    /// <summary>
    /// Interface to be implemented by search requests.
    /// </summary>
    public interface ISearchRequest
    {
        #region Methods

        /// <summary>
        /// Validates this instance.
        /// </summary>
        void Validate();

        #endregion Methods
    }
}

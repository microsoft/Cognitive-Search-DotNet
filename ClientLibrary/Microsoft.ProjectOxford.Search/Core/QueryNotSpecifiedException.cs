using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Core
{
    /// <summary>
    /// Exception thrown when a query is not specified.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class QueryNotSpecifiedException : Exception
    {
        #region Properties

        /// <summary>
        /// Gets a message that describes the current exception.
        /// </summary>
        public override string Message
        {
            get
            {
                return "Query not specified.";
            }
        }

        #endregion Properties
    }
}

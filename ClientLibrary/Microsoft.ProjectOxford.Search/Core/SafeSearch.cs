using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ProjectOxford.Search.Core
{
    /// <summary>
    /// Safe search filter for video search API's.
    /// </summary>
    public enum SafeSearch
    {
        /// <summary>
        /// No restrictors
        /// </summary>
        Off,
        /// <summary>
        /// Moderate search
        /// </summary>
        Moderate,
        /// <summary>
        /// Strict search
        /// </summary>
        Strict
    }
}

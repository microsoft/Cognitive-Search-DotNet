using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Microsoft.ProjectOxford.Search.Core;
using Microsoft.ProjectOxford.Search.Video;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for the VideoSearchClient class.
    /// </summary>
    [TestClass]
    public class VideoSearchClientTest
    {
        #region Fields

        private string apiKey = "";

        #endregion Fields

        #region Test Initialization

        /// <summary>
        /// Intializes this instance.
        /// </summary>
        [TestInitialize]
        public void Intialize()
        {
            apiKey = Environment.GetEnvironmentVariable("COG_API_KEY_SEARCH");
        }

        #endregion Test Initialization

        #region Test Methods

        /// <summary>
        /// Tests the Validate() method to ensure a query is specified.
        /// </summary>
        [TestMethod]
        [TestCategory("Video search")]
        [ExpectedException(typeof(QueryNotSpecifiedException))]
        public void ValidateTest_QueryNotSpecified()
        {
            var request = new VideoSearchRequest();
            request.Validate();
        }

        /// <summary>
        /// Tests the GetVideos() method.
        /// </summary>
        [TestMethod]
        [TestCategory("Video search")]
        public void GetVideosTest()
        {
            var request = new VideoSearchRequest();
            request.Query = "cats";
            request.Count = 10;
            request.Offset = 0;
            request.Market = "en-US";
            request.SafeSearch = SafeSearch.Moderate;

            var client = new VideoSearchClient(this.apiKey);

            var response = client.GetVideos(request);

            Assert.IsTrue(response.Videos.Count > 0);
        }

        #endregion Test Methods
    }
}

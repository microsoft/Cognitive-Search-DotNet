using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Microsoft.ProjectOxford.Search.Core;
using Microsoft.ProjectOxford.Search.Video;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for the VideoDetailClient class.
    /// </summary>
    [TestClass]
    public class VideoDetailClientTest
    {
        #region Fields

        private string apiKey = "";
        private string videoId = "42E6E500F763A94EB0F442E6E500F763A94EB0F4";

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
        [TestCategory("Video detail")]
        [ExpectedException(typeof(IdNotSpecifiedException))]
        public void ValidateTest_IdNotSpecified()
        {
            var request = new VideoDetailRequest();
            request.Validate();
        }

        /// <summary>
        /// Tests the GetVideoDetails() method.
        /// </summary>
        [TestMethod]
        [TestCategory("Video detail")]
        public void GetVideoDetailsTest()
        {
            var request = new VideoDetailRequest() { Id = this.videoId };

            var client = new VideoDetailClient(this.apiKey);

            var response = client.GetVideoDetails(request);

            Assert.IsNotNull(response.VideoResult);
            Assert.IsTrue(response.RelatedVideos.Count > 0);
        }

        #endregion Test Methods
    }
}

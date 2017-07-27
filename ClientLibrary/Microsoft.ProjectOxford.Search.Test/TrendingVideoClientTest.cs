using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Microsoft.ProjectOxford.Search.Video;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for the VideoSearchClient class.
    /// </summary>
    [TestClass]
    public class TrendingVideoClientTest
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
            apiKey = ConfigurationManager.AppSettings["searchApiKey"];
        }

        #endregion Test Initialization

        #region Test Methods

        /// <summary>
        /// Tests the GetVideos() method.
        /// </summary>
        [TestMethod]
        [TestCategory("Trending video")]
        public void GetVideosTest()
        {
            var client = new TrendingVideoClient(this.apiKey);

            var response = client.GetVideos();

            Assert.IsTrue(response.BannerTiles.Count > 0);
            Assert.IsTrue(response.Categories.Count > 0);
        }

        #endregion Test Methods
    }
}

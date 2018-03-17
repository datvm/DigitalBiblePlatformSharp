using DigitalBiblePlatformSharp.ApiModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBiblePlatformSharp.Test
{

    [TestClass]
    public class VersionListingTest
    {
        private DigitalBiblePlatformService service;

        [TestInitialize]
        public void Initialize()
        {
            this.service = TestUtils.GetService();
        }

        [TestMethod]
        public async Task TestVersionListingAsync1()
        {
            var result = await this.service.VersionListingAsync(new VersionListingRequest());

            TestUtils.WriteLogFile(result);

            TestUtils.IsNotNullOrEmpty(result);

            var nivItem = result.FirstOrDefault(q => q.VersionCode == "NIV");
            this.AssertNIVItem(nivItem);
        }

        [TestMethod]
        public async Task TestVersionListingAsync2()
        {
            var result = await this.service.VersionListingAsync(new VersionListingRequest()
            {
                Code = "NIV",
            });

            TestUtils.WriteLogFile(result);

            TestUtils.IsNotNullOrEmpty(result);

            var nivItem = result.FirstOrDefault();
            this.AssertNIVItem(nivItem);
        }

        [TestMethod]
        public async Task TestVersionListingAsync3()
        {
            var result = await this.service.VersionListingAsync(new VersionListingRequest()
            {
                Name = "International Version",
            });

            TestUtils.WriteLogFile(result);

            TestUtils.IsNotNullOrEmpty(result);

            var nivItem = result.FirstOrDefault(q => q.VersionCode == "NIV");
            this.AssertNIVItem(nivItem);
        }

        private void AssertNIVItem(VersionListingResponse firstItem)
        {
            Assert.IsNotNull(firstItem);
            Assert.AreEqual("New International Version", firstItem.VersionName);
            Assert.AreEqual(null, firstItem.VersionEnglish);
        }

    }
    
}

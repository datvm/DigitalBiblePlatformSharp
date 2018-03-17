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
    public class LanguageListingTest
    {
        private DigitalBiblePlatformService service;

        [TestInitialize]
        public void Initialize()
        {
            this.service = TestUtils.GetService();
        }

        [TestMethod]
        public async Task TestLanguageListingAsync1()
        {
            var result = await this.service.LanguageListingAsync(new LanguageListingRequest());
            TestUtils.WriteLogFile(nameof(TestLanguageListingAsync1), result);

            TestUtils.IsNotNullOrEmpty(result);

            var vietnameseItem = result.FirstOrDefault(q => q.EnglishName == "Vietnamese");
            this.AssertVietnameseItem(vietnameseItem);
        }

        [TestMethod]
        public async Task TestLanguageListingAsync2()
        {
            var result = await this.service.LanguageListingAsync(new LanguageListingRequest()
            {
                Name = "Vietnamese",
            });
            TestUtils.WriteLogFile(nameof(TestLanguageListingAsync2), result);

            TestUtils.IsNotNullOrEmpty(result);

            var firstItem = result[0];
            this.AssertVietnameseItem(firstItem);
        }

        private void AssertVietnameseItem(LanguageListingResponse firstItem)
        {
            Assert.IsNotNull(firstItem);

            Assert.AreEqual("Vietnamese", firstItem.EnglishName);
            Assert.AreEqual("Tiếng Việt", firstItem.LanguageName);
            Assert.AreEqual("VIE", firstItem.LanguageCode);
            Assert.AreEqual("vi", firstItem.LanguageIso1);
        }

    }
    
}

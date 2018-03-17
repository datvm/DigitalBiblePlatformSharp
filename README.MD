A wrapper API call to the Developer API of [Digital Bible Platform](https://www.digitalbibleplatform.com/).

# Usage
Example API call:

    // apiKey is your API Key
    var service = new DigitalBiblePlatformService(apiKey);
    var result = await this.service.LanguageListingAsync(new LanguageListingRequest()
    {
        Name = "Vietnamese",
    });

Consult [Test Project](https://github.com/datvm/DigitalBiblePlatformSharp/tree/master/DigitalBiblePlatformSharp.Test) for more use cases.
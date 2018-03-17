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

# Test Project
Since Private API Key is needed for calling API and I cannot just ignore Config file, Environment Variable is the best place to put in the key for testing.

Before running the test, please set a Environment Variable `DBPSharpApiKey` with your API Key (remember to restart Visual Studio because Environment Variables are only read at program startup.

In TestUtils file I have also defined a compiler variable:

        #define WRITELOGFILE
    
to enable writing log files to:

        public const string LogFileLocation = @"D:\Temp\TestLog";
        
Remove/Change the variable to disable JSON responses files writing.
using System;
using Shouldly;
using Xunit;

namespace RestService.Tests
{
    public class MapBoxServiceTests
    {
        [Fact]
        public void WhenInstatiatingIsNotNull()
        {
            var apiService = new MapBoxService();
            
            apiService.ShouldNotBeNull();
        }

        [Fact]
        public void WhenMakingCallWithoutTokenReturnsUnauthorizedStatus()
        {
            var apiService = new MapBoxService();
            var searchValue = "580 N Fourth Street Columbus OH";

            var result = apiService.MakeCall(searchValue, string.Empty);
            
            result.ShouldBe("The remote server returned an error: (401) Unauthorized.");
        }

        [Fact]
        public void WhenMakingCallWithValidTokenAndAddressReturnsJsonString()
        {
            var apiService = new MapBoxService();
            var searchValue = "580 N Fourth Street Columbus OH";
            var token =
                "pk.eyJ1Ijoiam9obmF0cGlsbGFyIiwiYSI6ImNqdG9nZTd2bTA3dmEzeW1yOHd0MG0zYWkifQ.27oEPRXBIcsInc5zmcGpHA";

            var result = apiService.MakeCall(searchValue, token);
            
            result.ShouldContain("FeatureCollection");
        }
    }
}
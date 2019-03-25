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
    }
}
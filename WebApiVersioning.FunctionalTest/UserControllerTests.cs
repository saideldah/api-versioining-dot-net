using Microsoft.AspNetCore.Mvc.Testing;

namespace WebApiVersioning.FunctionalTest;


public class UserControllerTests(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
{
    [Fact]
    public async Task Get_ReturnsV1Response()
    {
        // Arrange
        var client = factory.CreateClient();

        // Act
        var response = await client.GetAsync("/api/v1/User");

        // Assert
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        Assert.Equal("V1", content);
    }
    
    [Fact]
    public async Task Get_ReturnsV2Response()
    {
        // Arrange
        var client = factory.CreateClient();

        // Act
        var response = await client.GetAsync("/api/v2/User");

        // Assert
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        Assert.Equal("V2", content);
    }
    
    [Fact]
    public async Task Get_ReturnsV1_As_Default()
    {
        // Arrange
        var client = factory.CreateClient();
        var request = new HttpRequestMessage(HttpMethod.Get, "/api/User");

        // Act
        var response = await client.SendAsync(request);

        // Assert
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        Assert.Equal("V1", content);
    }
    [Fact]
    public async Task Get_ReturnsV1_WhenVersionIsPassedInHeader()
    {
        // Arrange
        var client = factory.CreateClient();
        var request = new HttpRequestMessage(HttpMethod.Get, "/api/User");
        request.Headers.Add("x-api-version", "1");

        // Act
        var response = await client.SendAsync(request);

        // Assert
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        Assert.Equal("V1", content);
    }
    
    [Fact]
    public async Task Get_ReturnsV2_WhenVersionIsPassedInHeader()
    {
        // Arrange
        var client = factory.CreateClient();
        var request = new HttpRequestMessage(HttpMethod.Get, "/api/User");
        request.Headers.Add("x-api-version", "2");

        // Act
        var response = await client.SendAsync(request);

        // Assert
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        Assert.Equal("V2", content);
    }
}
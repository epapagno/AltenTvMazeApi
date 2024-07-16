using Moq;
using System.Threading.Tasks;
using Xunit;
using AltenTvMazeServices;
using AltenTvMazeModels;
using AltenTvMazeRepositories;
using AltenTvMazeRepositories.Interfaces;

public class ShowServiceTests
{

    private readonly Mock<IShowRepository> _showRepositoryMock;
    private readonly ShowService _showService;

    public ShowServiceTests()
    {
        _showRepositoryMock = new Mock<IShowRepository>();
        _showService = new ShowService(new HttpClient(), _showRepositoryMock.Object);
    }

    [Fact]
    public async Task GetShowByIdAsync_ShowExists_ReturnsShow()
    {
        // Arrange
        var showId = 1;
        var expectedShow = new Show { Id = showId, Name = "Test Show" };
        _showRepositoryMock.Setup(repo => repo.GetShowByIdAsync(showId)).ReturnsAsync(expectedShow);

        // Act
        var actualShow = await _showService.GetShowByIdAsync(showId);

        // Assert
        Assert.NotNull(actualShow);
        Assert.Equal(expectedShow.Id, actualShow.Id);
        Assert.Equal(expectedShow.Name, actualShow.Name);
    }

    [Fact]
    public async Task GetShowByIdAsync_ShowDoesNotExist_ReturnsNull()
    {
        // Arrange
        var showId = 1;
        _showRepositoryMock.Setup(repo => repo.GetShowByIdAsync(showId)).ReturnsAsync((Show)null);

        // Act
        var actualShow = await _showService.GetShowByIdAsync(showId);

        // Assert
        Assert.Null(actualShow);
    }
}
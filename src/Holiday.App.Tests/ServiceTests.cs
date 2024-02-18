using Holiday.App.Infrastructure;
using Holiday.App.Infrastructure.Interfaces;

namespace Holiday.App.Tests;

[TestFixture]
public class ServiceTests
{
    private IService service;

    [SetUp]
    public void Setup()
    {
        service = new Service();
    }

    [Test]
    public void CalculateHolidayByYear_Success()
    {
        // Arrange
        int year = 2024;

        // Act
        var holidays = service.CalculateHolidayByYear(year);

        // Assert
        Assert.IsNotNull(holidays);
        Assert.AreEqual(4, holidays.Count);
    }

    [Test]
    public void CalculateHolidayByYear_Failure()
    {
        // Arrange
        int year = -1; // Invalid year

        Assert.Throws<ArgumentException>(() => service.CalculateHolidayByYear(year));
    }
}

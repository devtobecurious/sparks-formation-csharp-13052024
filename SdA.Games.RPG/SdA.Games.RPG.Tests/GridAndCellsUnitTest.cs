using SdA.Games.RPG.Core.Presentations;

namespace SdA.Games.RPG.Tests
{
    public class GridAndCellsUnitTest
    {
        [Fact(DisplayName = "Should display ....")]
        public void ShouldDisplayTwoCharsWithTwoCells()
        {
            // Arrange
            Grid grid = new Grid();
            grid.Add(new Cell());
            grid.Add(new Cell());

            // Act
            var content = grid.Display();

            // Assert
            Assert.Contains("__", content);
        }
    }
}
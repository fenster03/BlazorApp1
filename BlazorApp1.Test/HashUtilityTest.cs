using FluentAssertions;

namespace BlazorApp1.Test
{
    public class HashUtilityTest
    {
        [Fact]
        public void MD5Hash_ShouldReturnHashResult()
        {
            // Act
            var value = "foo";

            // Arrange
            var result = HashUtility.MD5Hash(value);

            // Assert
            result.Should().Be("acbd18db4cc2f85cedef654fccc4a4d8");
        }
    }
}
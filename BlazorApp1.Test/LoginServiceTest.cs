using FluentAssertions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Test
{
    public class LoginServiceTest
    {
        private IUserRepository _userRepository;
        private IHashProvider _hashProvider;

        private LoginService _sut;

        public LoginServiceTest()
        {
            _userRepository = Substitute.For<IUserRepository>();
            _hashProvider = Substitute.For<IHashProvider>();

            _sut = new LoginService();
        }

        [Fact]
        public async Task AuthenticateAsync_ShouldReturnSuccess()
        {
            // Arrange
            LoginAuthenticateRequestArgs args = new();

            // Act
            var result = _sut.AuthenticateAsync(args);

            // Assert
            result.Should().NotBeNull();
        }
    }
}

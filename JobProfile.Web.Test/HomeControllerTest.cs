using JOBProfile.Core.Repositories;
using Moq;
using Xunit;

namespace JobProfile.Web.Test
{

    public class Test_Home_Controller_Get_Recipes
    {
        private readonly Mock<IRecipiesRepository> _recipiesRepositoryMoc = new Mock<IRecipiesRepository>();

        [Fact]
        public void GetRecipies_Returns_ViewResult()
        {
            //Arrange
            //Act
            //Assert
        }
    }
}
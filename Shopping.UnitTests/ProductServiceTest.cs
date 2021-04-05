using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shopping.UnitTests
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IProductService _productService;
    public TestVoterDetailsService()
    {
        _serviceProvider = new ContainerResolver().ServiceProvider;

        _voterSurveyService = _serviceProvider.GetRequiredService<IVoterSurveyService>();
    }
    [TestClass]
    public class ProductServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

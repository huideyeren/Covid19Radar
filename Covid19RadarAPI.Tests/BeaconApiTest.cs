using Covid19Radar.Api;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Covid19Radar.Tests
{
    [TestClass]
    public class BeaconApiTest
    {
        [TestMethod]
        public void CreateMethod()
        {
            // preparation
            var cosmos = new Mock.CosmosMock();
            var logger = new Mock.LoggerMock<BeaconApi>();
            var beaconApi = new BeaconApi(cosmos, logger);
        }

        [TestMethod]
        public void RunMethod()
        {
            // preparation
            var cosmos = new Mock.CosmosMock();
            var logger = new Mock.LoggerMock<BeaconApi>();
            var beaconApi = new BeaconApi(cosmos, logger);
            var context = new Mock.HttpContextMock();
            // action
            beaconApi.Run(context.Request);
            // assert
        }
    }
}

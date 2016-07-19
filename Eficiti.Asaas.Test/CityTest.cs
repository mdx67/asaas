using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eficiti.Asaas.Factory;
using Eficiti.Asaas.Core;

namespace Eficiti.Asaas.Test
{
    [TestClass]
    public class CityTest
    {
        public ICityService cityService;

        public CityTest()
        {
            var asaasSettings = AsaasSettingsFactory.Create(SettingEnum.SandBox, "yourApiKey");
            cityService = CityFactory.CreateService(asaasSettings);
        }

        [TestMethod]
        public void Read()
        {
            var cityFilter = new CityFilter()
            {
                State = "SP"
            };

            var result = cityService.Read(cityFilter);
        }
    }
}

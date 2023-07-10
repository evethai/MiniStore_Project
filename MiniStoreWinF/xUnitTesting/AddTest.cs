using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTesting
{
    public class MockMoMoService : MoMoService
    {
        public bool CreateMethodCalled { get; private set; }
        public MoMo CreatedMoMo { get; private set; }

        public override void Create(MoMo entity)
        {
            base.Create(entity);
            CreateMethodCalled = true;
            CreatedMoMo = entity;
        }
    }
    public class AddTest
    {
        
        public void TestAddSuccessUsingMoq()
        {
            var mockMoMOService = new MockMoMoService();

            MoMo newFakeMoMo = new MoMo()
            {
                Name = "c",
                Phone = "0789654321",
                Gmail = "C@gamil.com",
                Active = true
            };

            mockMoMOService.Create(newFakeMoMo);

            Assert.True(mockMoMOService.CreateMethodCalled);
            Assert.Equal(newFakeMoMo, mockMoMOService.CreatedMoMo);
        }
    
}
}

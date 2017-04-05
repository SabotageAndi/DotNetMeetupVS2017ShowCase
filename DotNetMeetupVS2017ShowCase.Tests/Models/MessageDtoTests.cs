using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetMeetupVS2017ShowCase.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetMeetupVS2017ShowCase.Tests.Models
{
    [TestClass]
    public class MessageDtoTests
    {
        [TestMethod]
        public void Message_Set_Works()
        {
            //ARRANGE
            var testObject = new MessageDto();

            //ACT
            testObject.Message = "property was set";

            //ASSERT
            Assert.AreEqual("property was set", testObject.Message);
        }
    }
}

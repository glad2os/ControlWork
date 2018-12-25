using System;
using NUnit.Framework;

namespace ControlWork
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Check_Input_Data()
        {
            Straight Straight = new ControlWork.Straight(3, 2,0,6);
            Straight.check();
            Assert.True(true);
        }
    }
}
namespace SharpAima.Tests.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SharpAima.Agents;

    [TestClass]
    public class VacuumPerceptionTests
    {
        [TestMethod]
        public void Equals()
        {
            VacuumPerception p1 = new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean);
            VacuumPerception p2 = new VacuumPerception(VacuumLocation.B, VacuumStatus.Clean);
            VacuumPerception p3 = new VacuumPerception(VacuumLocation.A, VacuumStatus.Dirty);
            VacuumPerception p4 = new VacuumPerception(VacuumLocation.B, VacuumStatus.Dirty);
            VacuumPerception p5 = new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean);

            Assert.IsTrue(p1.Equals(p1));
            Assert.IsTrue(p1.Equals(p5));
            Assert.IsTrue(p5.Equals(p1));
            Assert.AreEqual(p1.GetHashCode(), p5.GetHashCode());

            Assert.IsFalse(p1.Equals(null));
            Assert.IsFalse(p1.Equals(123));
            Assert.IsFalse(p1.Equals(p2));
            Assert.IsFalse(p2.Equals(p1));
            Assert.IsFalse(p1.Equals(p3));
            Assert.IsFalse(p3.Equals(p1));
            Assert.IsFalse(p1.Equals(p4));
            Assert.IsFalse(p4.Equals(p1));
        }
    }
}

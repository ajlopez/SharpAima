namespace SharpAima.Tests.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SharpAima.Agents;

    [TestClass]
    public class VacuumPerceptionListTests
    {
        [TestMethod]
        public void Equals()
        {
            VacuumPerceptionList l1 = new VacuumPerceptionList(new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean));
            VacuumPerceptionList l2 = new VacuumPerceptionList(new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean), new VacuumPerception(VacuumLocation.B, VacuumStatus.Clean));
            VacuumPerceptionList l3 = new VacuumPerceptionList(new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean), new VacuumPerception(VacuumLocation.B, VacuumStatus.Dirty));
            VacuumPerceptionList l4 = new VacuumPerceptionList(new VacuumPerception(VacuumLocation.A, VacuumStatus.Dirty));
            VacuumPerceptionList l5 = new VacuumPerceptionList(new VacuumPerception(VacuumLocation.A, VacuumStatus.Clean));

            Assert.IsTrue(l1.Equals(l5));
            Assert.IsTrue(l5.Equals(l1));
            Assert.AreEqual(l1.GetHashCode(), l5.GetHashCode());

            Assert.IsFalse(l1.Equals(null));
            Assert.IsFalse(l1.Equals(123));
            Assert.IsFalse(l1.Equals(l2));
            Assert.IsFalse(l2.Equals(l1));
            Assert.IsFalse(l1.Equals(l3));
            Assert.IsFalse(l3.Equals(l1));
            Assert.IsFalse(l1.Equals(l4));
            Assert.IsFalse(l4.Equals(l1));
        }
    }
}

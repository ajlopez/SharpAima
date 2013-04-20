namespace SharpAmia.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RandomVacuumAgent
    {
        public VacuumAction GetAction(VacuumPerception perception)
        {
            return VacuumAction.Left;
        }
    }
}

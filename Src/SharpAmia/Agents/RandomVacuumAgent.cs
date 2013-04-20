namespace SharpAmia.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RandomVacuumAgent
    {
        private static VacuumAction[] actions = new VacuumAction[] { VacuumAction.NoOp, VacuumAction.Suck, VacuumAction.Left, VacuumAction.Right };
        private Random random = new Random();

        public VacuumAction GetAction(VacuumPerception perception)
        {
            return actions[random.Next(actions.Length)];
        }
    }
}

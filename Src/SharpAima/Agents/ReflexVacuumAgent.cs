﻿namespace SharpAima.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ReflexVacuumAgent : Agent<VacuumLocation, VacuumPerception, VacuumAction>
    {
        public override VacuumAction GetAction(VacuumPerception perception)
        {
            if (perception.Status == VacuumStatus.Dirty)
                return VacuumAction.Suck;

            if (perception.Location == VacuumLocation.A)
                return VacuumAction.Right;

            return VacuumAction.Left;
        }
    }
}

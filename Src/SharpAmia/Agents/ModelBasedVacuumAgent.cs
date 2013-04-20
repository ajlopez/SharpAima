﻿namespace SharpAmia.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ModelBasedVacuumAgent : VacuumAgent
    {
        public override VacuumAction GetAction(VacuumPerception perception)
        {
            if (perception.Status == VacuumStatus.Dirty)
                return VacuumAction.Suck;

            throw new NotImplementedException();
        }
    }
}

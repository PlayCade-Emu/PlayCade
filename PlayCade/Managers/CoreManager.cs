using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using PlayCade.Common.Interfaces;
using PlayCade.Core.Chip8;

namespace PlayCade.Managers
{
    public class CoreManager
    {
     
        public List<ICore> AvailableCores()
        {
            List<ICore> availableCores = new List<ICore>();
            
            availableCores.Add(new Chip8Core());
            
            return availableCores;
        }
    }
}
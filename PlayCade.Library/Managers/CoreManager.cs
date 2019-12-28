using System.Collections.Generic;
using PlayCade.Common.Interfaces;
using PlayCade.Core.Chip8;

namespace PlayCade.Library.Managers
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
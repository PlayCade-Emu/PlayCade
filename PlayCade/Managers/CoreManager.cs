using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PlayCade.Common.Interfaces;

namespace PlayCade.Managers
{
    public class CoreManager
    {
     
        public void AvailableCores()
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                Console.WriteLine($"Assembly {assembly.GetName().Name}");

                var types = assembly.GetTypes()
                    .Where(y => typeof(ICore).IsAssignableFrom(y));

                foreach (var type in types)
                {
                    Console.WriteLine($"Type: {type.Name}");
                }
            }
        }
    }
}
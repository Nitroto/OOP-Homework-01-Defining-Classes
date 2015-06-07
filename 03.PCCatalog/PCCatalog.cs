using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class PCCatalog
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
        List<Computer> pcCatalog = new List<Computer>();
        Computer firstConfiguration = new Computer("Sbirshtok", new List<Component>
        {
            new Component("Motherboard",12.5M),
            new Component("RAM",20M,"2 GB"),
            new Component("HDD", 58.26M,"512 GB"),
            new Component("Processor", 135.89M,"INET CORE 7I-4790 3.6 GHZ 8MB"),
            new Component("GPU", 80.99M,"Video???")
        });
        pcCatalog.Add(firstConfiguration);

        Computer secondConfiguretion = new Computer("The Machine", new List<Component>
        {
            new Component("Motherboard",285M,"INTEL H97 CHIPSET"),
            new Component("RAM",125.59M,"8 GB"),
            new Component("HDD", 189.36M,"2 TB"),
            new Component("Processor", 523.24M,"INTEL CORE I7-4790 3.6 GHZ 8MB"),
            new Component("GPU", 342.12M,"NVIDIA GEFORCE GTX970 4GB DDR5")
        });
        pcCatalog.Add(secondConfiguretion);

        Computer thirdConfiguretion = new Computer("Office", new List<Component>
        {
            new Component("RAM",75.25M,"4 GB"),
            new Component("HDD", 89.99M,"500 GB"),
            new Component("Processor", 200M,"INTEL CELERON G1840 2.8 GHZ 2M"),
            new Component("GPU", 152.16M,"NVIDIA GEFORCE GT 705 1 GB"),
            new Component("Keyboard", 15.25M),
        });
        pcCatalog.Add(thirdConfiguretion);
        
        var arrangeByPrice = pcCatalog.OrderBy(component => component.Price).ThenBy(computer => computer.Price);
        foreach (var computer in arrangeByPrice)
        {
            Console.WriteLine(computer);
        }
    }
}

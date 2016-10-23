﻿using System.Collections.Generic;
using System.Reflection;

namespace SciChart.Wpf.UI.Reactive.Bootstrap
{
    public interface IAssemblyDiscovery
    {
        IEnumerable<Assembly> GetAssemblies();
    }
}
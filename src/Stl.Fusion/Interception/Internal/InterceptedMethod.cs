using System;
using System.Reflection;

namespace Stl.Fusion.Interception.Internal
{
    public class InterceptedMethod
    {
        public MethodInfo MethodInfo { get; set; } = null!;
        public InterceptedMethodAttribute Attribute { get; set; } = null!;
        public Type OutputType { get; set; } = null!;
        public bool ReturnsValueTask { get; set; }
        public ArgumentHandler InvocationTargetHandler { get; set; } = null!;
        public ArgumentHandler[] ArgumentHandlers { get; set; } = null!;
        public int CancellationTokenArgumentIndex { get; set; } = -1;
        public ComputedOptions Options { get; set; } = ComputedOptions.Default;
    }
}

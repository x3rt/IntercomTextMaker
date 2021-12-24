using System;
using Exiled.API.Enums;
using Exiled.API.Features;

namespace IntercomTextMaker
{
    internal class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "IntercomTextMaker";
        public override string Author { get; } = "x3rt";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(3, 0, 0);
        public override PluginPriority Priority => PluginPriority.Last;
        
        public static Config SharedConfig { get; set; }

        public override void OnEnabled()
        {
            SharedConfig = Config;
            base.OnEnabled();
        }
        
        public override void OnDisabled()
        {
            
            base.OnDisabled();
        }
    }
}
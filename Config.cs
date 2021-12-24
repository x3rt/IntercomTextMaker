using System.ComponentModel;
using Exiled.API.Interfaces;

namespace IntercomTextMaker
{
    public sealed class Config : IConfig
    {
        [Description("If plugin is enabled")]
        public bool IsEnabled { get; set; } = true;

    }
}
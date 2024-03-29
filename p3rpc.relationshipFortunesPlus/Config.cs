using p3rpc.relationshipFortunesPlus.Template.Configuration;
using System.ComponentModel;

namespace p3rpc.relationshipFortunesPlus.Configuration;
public class Config : Configurable<Config>
{
    [DisplayName("Quick Fortunes")]
    [Description("If enabled you will have the option to draw quick relationship fortunes.\nIf not you will just have the improved social link selection menu.")]
    [DefaultValue(true)]
    public bool QuickFortunes { get; set; } = true;
}

/// <summary>
/// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
/// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
/// </summary>
public class ConfiguratorMixin : ConfiguratorMixinBase
{
    // 
}
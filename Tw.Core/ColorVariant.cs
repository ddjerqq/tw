namespace Tw.Core;

public enum ColorVariant
{
    Primary,
    Secondary,
    Success,
    Danger,
    Warning,
    Info,
}

public static class ColorVariantExtensions
{
    public static string GetClass(this ColorVariant color)
    {
        return color switch
        {
            ColorVariant.Primary => "bg-primary-300",
            ColorVariant.Secondary => "bg-secondary-300",
            ColorVariant.Success => "bg-success-300",
            ColorVariant.Danger => "bg-danger-300",
            ColorVariant.Warning => "bg-warning-300",
            ColorVariant.Info => "bg-info-300",
            _ => throw new ArgumentOutOfRangeException(nameof(color), color, null),
        };
    }
}

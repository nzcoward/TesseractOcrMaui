using System.Diagnostics;

namespace TesseractOcrMaui.Utilities;

[StackTraceHidden]
internal static class Guard
{
    /// <exception cref="PlatformNotSupportedException">If not targetting maui (TargetFramework is only [net9.0].</exception>
    public static void ThrowIfNonMaui()
    {
#if NET9_0_ONLY
        throw new PlatformNotSupportedException("This functionality is not accessable on TargetFramework [.net9.0]. " +
            "Functionality needs to access 'Microsoft.Maui.essentials which' is not included.");
#endif
    }
}

using System.Diagnostics;

namespace Vorlesung_09;

internal static class Helpers
{
    internal static void Log(string sender, string message) => Debug.WriteLine($"{sender}: {message}");

    internal static void SubscribeToLifecycleEvents(Window window)
    {
        var sender = $"Window: {window.Title}";

        window.Created += (_, _) => Log(sender, nameof(Window.Created));
        window.Activated += (_, _) => Log(sender, nameof(Window.Activated));
        window.Deactivated += (_, _) => Log(sender, nameof(Window.Deactivated));
        window.Stopped += (_, _) => Log(sender, nameof(Window.Stopped));
        window.Resumed += (_, _) => Log(sender, nameof(Window.Resumed));
        window.Destroying += (_, _) => Log(sender, nameof(Window.Destroying));
    }
}
using System;
namespace LaunchBoxRemote.Plugin;

public sealed class WebServer : IDisposable
{
    public void Start()
    {
        Logger.Info("Web server starting...");
    }

    public void Stop()
    {
        Logger.Info("Web server stopping...");
    }

    public void Dispose()
    {
        Stop();
    }
}

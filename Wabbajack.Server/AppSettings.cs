﻿using Microsoft.Extensions.Configuration;
using Wabbajack.Paths;

namespace Wabbajack.BuildServer;

public class AppSettings
{
    public AppSettings(IConfiguration config)
    {
        config.Bind("WabbajackSettings", this);
    }
    public bool TestMode { get; set; }
    public bool RunBackendNexusRoutines { get; set; } = true;
    public string AuthorAPIKeyFile { get; set; }
    
    public string TarKeyFile { get; set; }
    public string WabbajackBuildServerUri { get; set; } = "https://build.wabbajack.org/";
    public string MetricsKeyHeader { get; set; } = "x-metrics-key";
    public string TempFolder { get; set; }
    
    public string ProxyFolder { get; set; }
    public AbsolutePath ProxyPath => (AbsolutePath) ProxyFolder;
    public AbsolutePath TempPath => (AbsolutePath) TempFolder;
    public string SpamWebHook { get; set; } = "";
    public string HamWebHook { get; set; } = "";

    public string DiscordKey { get; set; }
    
    public string AuthoredFilesFolder { get; set; }
    
    public string PatchesFilesFolder { get; set; }
    public string MirrorFilesFolder { get; set; }
    public string NexusCacheFolder { get; set; }
    public string MetricsFolder { get; set; } = "";
    public string TarLogPath { get; set; }
    public string GitHubKey { get; set; } = "";
    
    public CouchDBSetting CesiDB { get; set; }
    public CouchDBSetting MetricsDB { get; set; }
}

public class CouchDBSetting
{
    public Uri Endpoint { get; set; }
    public string Database { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}
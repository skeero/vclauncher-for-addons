using System.Runtime.InteropServices;
using System;

public class Networking
{
    [DllImport("dnsapi.dll", EntryPoint = "DnsFlushResolverCache")] private static extern UInt32 DnsFlushResolverCache();
    
    /// <summary>
    /// Flush DNS resolver cache on the system.
    /// </summary>
    public static void FlushDnsCache()
    {
        DnsFlushResolverCache();
    }
}

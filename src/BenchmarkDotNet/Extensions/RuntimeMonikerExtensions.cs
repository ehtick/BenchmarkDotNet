﻿using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using System;

namespace BenchmarkDotNet.Extensions
{
    internal static class RuntimeMonikerExtensions
    {
        internal static Runtime GetRuntime(this RuntimeMoniker runtimeMoniker)
        {
            switch (runtimeMoniker)
            {
                case RuntimeMoniker.Net461:
                    return ClrRuntime.Net461;
                case RuntimeMoniker.Net462:
                    return ClrRuntime.Net462;
                case RuntimeMoniker.Net47:
                    return ClrRuntime.Net47;
                case RuntimeMoniker.Net471:
                    return ClrRuntime.Net471;
                case RuntimeMoniker.Net472:
                    return ClrRuntime.Net472;
                case RuntimeMoniker.Net48:
                    return ClrRuntime.Net48;
                case RuntimeMoniker.Net481:
                    return ClrRuntime.Net481;
                case RuntimeMoniker.NetCoreApp20:
                    return CoreRuntime.Core20;
                case RuntimeMoniker.NetCoreApp21:
                    return CoreRuntime.Core21;
                case RuntimeMoniker.NetCoreApp22:
                    return CoreRuntime.Core22;
                case RuntimeMoniker.NetCoreApp30:
                    return CoreRuntime.Core30;
                case RuntimeMoniker.NetCoreApp31:
                    return CoreRuntime.Core31;
                case RuntimeMoniker.Net50:
#pragma warning disable CS0618 // Type or member is obsolete
                case RuntimeMoniker.NetCoreApp50:
#pragma warning restore CS0618 // Type or member is obsolete
                    return CoreRuntime.Core50;
                case RuntimeMoniker.Net60:
                    return CoreRuntime.Core60;
                case RuntimeMoniker.Net70:
                    return CoreRuntime.Core70;
                case RuntimeMoniker.Net80:
                    return CoreRuntime.Core80;
                case RuntimeMoniker.Net90:
                    return CoreRuntime.Core90;
                case RuntimeMoniker.Net10_0:
                    return CoreRuntime.Core10_0;
                case RuntimeMoniker.Mono:
                    return MonoRuntime.Default;
                case RuntimeMoniker.NativeAot60:
                    return NativeAotRuntime.Net60;
                case RuntimeMoniker.NativeAot70:
                    return NativeAotRuntime.Net70;
                case RuntimeMoniker.NativeAot80:
                    return NativeAotRuntime.Net80;
                case RuntimeMoniker.NativeAot90:
                    return NativeAotRuntime.Net90;
                case RuntimeMoniker.NativeAot10_0:
                    return NativeAotRuntime.Net10_0;
                case RuntimeMoniker.Mono60:
                    return MonoRuntime.Mono60;
                case RuntimeMoniker.Mono70:
                    return MonoRuntime.Mono70;
                case RuntimeMoniker.Mono80:
                    return MonoRuntime.Mono80;
                case RuntimeMoniker.Mono90:
                    return MonoRuntime.Mono90;
                case RuntimeMoniker.Mono10_0:
                    return MonoRuntime.Mono10_0;
                default:
                    throw new ArgumentOutOfRangeException(nameof(runtimeMoniker), runtimeMoniker, "Runtime Moniker not supported");
            }
        }
    }
}

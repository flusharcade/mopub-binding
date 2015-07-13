using System;
using ObjCRuntime;

[assembly: LinkWith ("mopub.a", LinkTarget.Simulator64, SmartLink = true, ForceLoad = true)]

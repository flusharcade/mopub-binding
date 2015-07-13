using System;
using ObjCRuntime;

[assembly: LinkWith ("libmopub.a", LinkTarget.ArmV7 | LinkTarget.Simulator64 | LinkTarget.Arm64, SmartLink = true, ForceLoad = true)]

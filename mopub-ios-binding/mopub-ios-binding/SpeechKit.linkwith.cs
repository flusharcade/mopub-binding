using System;
using ObjCRuntime;

[assembly: LinkWith ("SpeechKit.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]

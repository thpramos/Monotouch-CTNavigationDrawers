using System;
using ObjCRuntime;

[assembly: LinkWith ("libCTNavigationDrawers.a", LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]

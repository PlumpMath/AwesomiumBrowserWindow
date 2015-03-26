// Guids.cs
// MUST match guids.h
using System;

namespace NoCo.AwesomiumBrowserWindow
{
    static class GuidList
    {
        public const string guidAwesomiumBrowserWindowPkgString = "51fa3ff7-6c88-43f0-9083-9cb4fb3749c1";
        public const string guidAwesomiumBrowserWindowCmdSetString = "ea222fab-d5ce-4774-aa8c-0be87ada2214";
        public const string guidToolWindowPersistanceString = "477eb621-e046-49f9-b5a1-39378e538bed";

        public static readonly Guid guidAwesomiumBrowserWindowCmdSet = new Guid(guidAwesomiumBrowserWindowCmdSetString);
    };
}
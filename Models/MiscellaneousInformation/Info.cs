using System;
using System.Collections.Generic;
using System.Text;

namespace Rocker.Chat.RestApiClient.Models.MiscellaneousInformation
{
    public class Build
    {
        public string nodeVersion { get; set; }
        public string arch { get; set; }
        public string platform { get; set; }
        public int cpus { get; set; }
    }

    public class Commit
    {
        public string hash { get; set; }
        public string date { get; set; }
        public string author { get; set; }
        public string subject { get; set; }
        public string tag { get; set; }
        public string branch { get; set; }
    }

    public class Info
    {
        public string version { get; set; }
        public Build build { get; set; }
        public Commit commit { get; set; }
    }

    public class InfoRootObject
    {
        public bool success { get; set; }
        public Info info { get; set; }
    }
}

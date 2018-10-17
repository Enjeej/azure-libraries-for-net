// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Process Information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ProcessInfoInner : ProxyOnlyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the ProcessInfoInner class.
        /// </summary>
        public ProcessInfoInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProcessInfoInner class.
        /// </summary>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="identifier">ARM Identifier for deployment.</param>
        /// <param name="deploymentName">Deployment name.</param>
        /// <param name="href">HRef URI.</param>
        /// <param name="minidump">Minidump URI.</param>
        /// <param name="isProfileRunning">Is profile running?</param>
        /// <param name="isIisProfileRunning">Is the IIS Profile
        /// running?</param>
        /// <param name="iisProfileTimeoutInSeconds">IIS Profile timeout
        /// (seconds).</param>
        /// <param name="parent">Parent process.</param>
        /// <param name="children">Child process list.</param>
        /// <param name="threads">Thread list.</param>
        /// <param name="openFileHandles">List of open files.</param>
        /// <param name="modules">List of modules.</param>
        /// <param name="fileName">File name of this process.</param>
        /// <param name="commandLine">Command line.</param>
        /// <param name="userName">User name.</param>
        /// <param name="handleCount">Handle count.</param>
        /// <param name="moduleCount">Module count.</param>
        /// <param name="threadCount">Thread count.</param>
        /// <param name="startTime">Start time.</param>
        /// <param name="totalCpuTime">Total CPU time.</param>
        /// <param name="userCpuTime">User CPU time.</param>
        /// <param name="privilegedCpuTime">Privileged CPU time.</param>
        /// <param name="workingSet">Working set.</param>
        /// <param name="peakWorkingSet">Peak working set.</param>
        /// <param name="privateMemory">Private memory size.</param>
        /// <param name="virtualMemory">Virtual memory size.</param>
        /// <param name="peakVirtualMemory">Peak virtual memory usage.</param>
        /// <param name="pagedSystemMemory">Paged system memory.</param>
        /// <param name="nonPagedSystemMemory">Non-paged system memory.</param>
        /// <param name="pagedMemory">Paged memory.</param>
        /// <param name="peakPagedMemory">Peak paged memory.</param>
        /// <param name="timeStamp">Time stamp.</param>
        /// <param name="environmentVariables">List of environment
        /// variables.</param>
        /// <param name="isScmSite">Is this the SCM site?</param>
        /// <param name="isWebjob">Is this a Web Job?</param>
        /// <param name="description">Description of process.</param>
        public ProcessInfoInner(string id = default(string), string name = default(string), string type = default(string), string kind = default(string), int? identifier = default(int?), string deploymentName = default(string), string href = default(string), string minidump = default(string), bool? isProfileRunning = default(bool?), bool? isIisProfileRunning = default(bool?), double? iisProfileTimeoutInSeconds = default(double?), string parent = default(string), IList<string> children = default(IList<string>), IList<ProcessThreadInfoInner> threads = default(IList<ProcessThreadInfoInner>), IList<string> openFileHandles = default(IList<string>), IList<ProcessModuleInfoInner> modules = default(IList<ProcessModuleInfoInner>), string fileName = default(string), string commandLine = default(string), string userName = default(string), int? handleCount = default(int?), int? moduleCount = default(int?), int? threadCount = default(int?), System.DateTime? startTime = default(System.DateTime?), string totalCpuTime = default(string), string userCpuTime = default(string), string privilegedCpuTime = default(string), long? workingSet = default(long?), long? peakWorkingSet = default(long?), long? privateMemory = default(long?), long? virtualMemory = default(long?), long? peakVirtualMemory = default(long?), long? pagedSystemMemory = default(long?), long? nonPagedSystemMemory = default(long?), long? pagedMemory = default(long?), long? peakPagedMemory = default(long?), System.DateTime? timeStamp = default(System.DateTime?), IDictionary<string, string> environmentVariables = default(IDictionary<string, string>), bool? isScmSite = default(bool?), bool? isWebjob = default(bool?), string description = default(string))
            : base(id, name, type, kind)
        {
            Identifier = identifier;
            DeploymentName = deploymentName;
            Href = href;
            Minidump = minidump;
            IsProfileRunning = isProfileRunning;
            IsIisProfileRunning = isIisProfileRunning;
            IisProfileTimeoutInSeconds = iisProfileTimeoutInSeconds;
            Parent = parent;
            Children = children;
            Threads = threads;
            OpenFileHandles = openFileHandles;
            Modules = modules;
            FileName = fileName;
            CommandLine = commandLine;
            UserName = userName;
            HandleCount = handleCount;
            ModuleCount = moduleCount;
            ThreadCount = threadCount;
            StartTime = startTime;
            TotalCpuTime = totalCpuTime;
            UserCpuTime = userCpuTime;
            PrivilegedCpuTime = privilegedCpuTime;
            WorkingSet = workingSet;
            PeakWorkingSet = peakWorkingSet;
            PrivateMemory = privateMemory;
            VirtualMemory = virtualMemory;
            PeakVirtualMemory = peakVirtualMemory;
            PagedSystemMemory = pagedSystemMemory;
            NonPagedSystemMemory = nonPagedSystemMemory;
            PagedMemory = pagedMemory;
            PeakPagedMemory = peakPagedMemory;
            TimeStamp = timeStamp;
            EnvironmentVariables = environmentVariables;
            IsScmSite = isScmSite;
            IsWebjob = isWebjob;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets ARM Identifier for deployment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.identifier")]
        public int? Identifier { get; private set; }

        /// <summary>
        /// Gets or sets deployment name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deployment_name")]
        public string DeploymentName { get; set; }

        /// <summary>
        /// Gets or sets hRef URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets minidump URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minidump")]
        public string Minidump { get; set; }

        /// <summary>
        /// Gets or sets is profile running?
        /// </summary>
        [JsonProperty(PropertyName = "properties.is_profile_running")]
        public bool? IsProfileRunning { get; set; }

        /// <summary>
        /// Gets or sets is the IIS Profile running?
        /// </summary>
        [JsonProperty(PropertyName = "properties.is_iis_profile_running")]
        public bool? IsIisProfileRunning { get; set; }

        /// <summary>
        /// Gets or sets IIS Profile timeout (seconds).
        /// </summary>
        [JsonProperty(PropertyName = "properties.iis_profile_timeout_in_seconds")]
        public double? IisProfileTimeoutInSeconds { get; set; }

        /// <summary>
        /// Gets or sets parent process.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parent")]
        public string Parent { get; set; }

        /// <summary>
        /// Gets or sets child process list.
        /// </summary>
        [JsonProperty(PropertyName = "properties.children")]
        public IList<string> Children { get; set; }

        /// <summary>
        /// Gets or sets thread list.
        /// </summary>
        [JsonProperty(PropertyName = "properties.threads")]
        public IList<ProcessThreadInfoInner> Threads { get; set; }

        /// <summary>
        /// Gets or sets list of open files.
        /// </summary>
        [JsonProperty(PropertyName = "properties.open_file_handles")]
        public IList<string> OpenFileHandles { get; set; }

        /// <summary>
        /// Gets or sets list of modules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.modules")]
        public IList<ProcessModuleInfoInner> Modules { get; set; }

        /// <summary>
        /// Gets or sets file name of this process.
        /// </summary>
        [JsonProperty(PropertyName = "properties.file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets command line.
        /// </summary>
        [JsonProperty(PropertyName = "properties.command_line")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets user name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets handle count.
        /// </summary>
        [JsonProperty(PropertyName = "properties.handle_count")]
        public int? HandleCount { get; set; }

        /// <summary>
        /// Gets or sets module count.
        /// </summary>
        [JsonProperty(PropertyName = "properties.module_count")]
        public int? ModuleCount { get; set; }

        /// <summary>
        /// Gets or sets thread count.
        /// </summary>
        [JsonProperty(PropertyName = "properties.thread_count")]
        public int? ThreadCount { get; set; }

        /// <summary>
        /// Gets or sets start time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.start_time")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets total CPU time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.total_cpu_time")]
        public string TotalCpuTime { get; set; }

        /// <summary>
        /// Gets or sets user CPU time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.user_cpu_time")]
        public string UserCpuTime { get; set; }

        /// <summary>
        /// Gets or sets privileged CPU time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privileged_cpu_time")]
        public string PrivilegedCpuTime { get; set; }

        /// <summary>
        /// Gets or sets working set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.working_set")]
        public long? WorkingSet { get; set; }

        /// <summary>
        /// Gets or sets peak working set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peak_working_set")]
        public long? PeakWorkingSet { get; set; }

        /// <summary>
        /// Gets or sets private memory size.
        /// </summary>
        [JsonProperty(PropertyName = "properties.private_memory")]
        public long? PrivateMemory { get; set; }

        /// <summary>
        /// Gets or sets virtual memory size.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtual_memory")]
        public long? VirtualMemory { get; set; }

        /// <summary>
        /// Gets or sets peak virtual memory usage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peak_virtual_memory")]
        public long? PeakVirtualMemory { get; set; }

        /// <summary>
        /// Gets or sets paged system memory.
        /// </summary>
        [JsonProperty(PropertyName = "properties.paged_system_memory")]
        public long? PagedSystemMemory { get; set; }

        /// <summary>
        /// Gets or sets non-paged system memory.
        /// </summary>
        [JsonProperty(PropertyName = "properties.non_paged_system_memory")]
        public long? NonPagedSystemMemory { get; set; }

        /// <summary>
        /// Gets or sets paged memory.
        /// </summary>
        [JsonProperty(PropertyName = "properties.paged_memory")]
        public long? PagedMemory { get; set; }

        /// <summary>
        /// Gets or sets peak paged memory.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peak_paged_memory")]
        public long? PeakPagedMemory { get; set; }

        /// <summary>
        /// Gets or sets time stamp.
        /// </summary>
        [JsonProperty(PropertyName = "properties.time_stamp")]
        public System.DateTime? TimeStamp { get; set; }

        /// <summary>
        /// Gets or sets list of environment variables.
        /// </summary>
        [JsonProperty(PropertyName = "properties.environment_variables")]
        public IDictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// Gets or sets is this the SCM site?
        /// </summary>
        [JsonProperty(PropertyName = "properties.is_scm_site")]
        public bool? IsScmSite { get; set; }

        /// <summary>
        /// Gets or sets is this a Web Job?
        /// </summary>
        [JsonProperty(PropertyName = "properties.is_webjob")]
        public bool? IsWebjob { get; set; }

        /// <summary>
        /// Gets or sets description of process.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

    }
}

// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for VirtualMachinePriorityTypes.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<VirtualMachinePriorityTypes>))]
    public class VirtualMachinePriorityTypes : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<VirtualMachinePriorityTypes>
    {
        public static readonly VirtualMachinePriorityTypes Regular = Parse("Regular");
        public static readonly VirtualMachinePriorityTypes Low = Parse("Low");
    }
}

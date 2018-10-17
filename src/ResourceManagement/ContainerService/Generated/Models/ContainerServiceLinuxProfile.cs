// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Profile for Linux VMs in the container service cluster.
    /// </summary>
    public partial class ContainerServiceLinuxProfile
    {
        /// <summary>
        /// Initializes a new instance of the ContainerServiceLinuxProfile
        /// class.
        /// </summary>
        public ContainerServiceLinuxProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerServiceLinuxProfile
        /// class.
        /// </summary>
        /// <param name="adminUsername">The administrator username to use for
        /// Linux VMs.</param>
        /// <param name="ssh">SSH configuration for Linux-based VMs running on
        /// Azure.</param>
        public ContainerServiceLinuxProfile(string adminUsername, ContainerServiceSshConfiguration ssh)
        {
            AdminUsername = adminUsername;
            Ssh = ssh;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the administrator username to use for Linux VMs.
        /// </summary>
        [JsonProperty(PropertyName = "adminUsername")]
        public string AdminUsername { get; set; }

        /// <summary>
        /// Gets or sets SSH configuration for Linux-based VMs running on
        /// Azure.
        /// </summary>
        [JsonProperty(PropertyName = "ssh")]
        public ContainerServiceSshConfiguration Ssh { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AdminUsername == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AdminUsername");
            }
            if (Ssh == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Ssh");
            }
            if (AdminUsername != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(AdminUsername, "^[A-Za-z][-A-Za-z0-9_]*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "AdminUsername", "^[A-Za-z][-A-Za-z0-9_]*$");
                }
            }
            if (Ssh != null)
            {
                Ssh.Validate();
            }
        }
    }
}

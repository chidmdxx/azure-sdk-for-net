// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The base definition of a secret type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("RBAC")]
    public partial class LinkedIntegrationRuntimeRbac : LinkedIntegrationRuntimeProperties
    {
        /// <summary>
        /// Initializes a new instance of the LinkedIntegrationRuntimeRbac
        /// class.
        /// </summary>
        public LinkedIntegrationRuntimeRbac()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LinkedIntegrationRuntimeRbac
        /// class.
        /// </summary>
        /// <param name="resourceId">The resource ID of the integration runtime
        /// to be shared.</param>
        public LinkedIntegrationRuntimeRbac(string resourceId)
        {
            ResourceId = resourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource ID of the integration runtime to be
        /// shared.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceId");
            }
        }
    }
}

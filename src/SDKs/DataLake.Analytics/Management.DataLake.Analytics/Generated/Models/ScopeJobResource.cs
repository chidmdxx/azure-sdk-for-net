// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Scope job resources. (Only for use internally with Scope job type.)
    /// </summary>
    public partial class ScopeJobResource
    {
        /// <summary>
        /// Initializes a new instance of the ScopeJobResource class.
        /// </summary>
        public ScopeJobResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScopeJobResource class.
        /// </summary>
        /// <param name="name">the name of the resource.</param>
        /// <param name="path">the path to the resource.</param>
        public ScopeJobResource(string name = default(string), string path = default(string))
        {
            Name = name;
            Path = path;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the path to the resource.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

    }
}

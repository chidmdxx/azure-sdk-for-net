// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This class represents job details based on specific job type.
    /// </summary>
    public partial class AsrJobDetails : JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the AsrJobDetails class.
        /// </summary>
        public AsrJobDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AsrJobDetails class.
        /// </summary>
        /// <param name="affectedObjectDetails">The affected object properties
        /// like source server, source cloud, target server, target cloud etc.
        /// based on the workflow object details.</param>
        public AsrJobDetails(IDictionary<string, string> affectedObjectDetails = default(IDictionary<string, string>))
            : base(affectedObjectDetails)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
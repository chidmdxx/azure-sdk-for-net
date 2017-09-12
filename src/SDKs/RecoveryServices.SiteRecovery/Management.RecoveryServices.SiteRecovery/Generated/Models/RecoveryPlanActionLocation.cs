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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RecoveryPlanActionLocation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecoveryPlanActionLocation
    {
        [EnumMember(Value = "Primary")]
        Primary,
        [EnumMember(Value = "Recovery")]
        Recovery
    }
    internal static class RecoveryPlanActionLocationEnumExtension
    {
        internal static string ToSerializedValue(this RecoveryPlanActionLocation? value)  =>
            value == null ? null : ((RecoveryPlanActionLocation)value).ToSerializedValue();

        internal static string ToSerializedValue(this RecoveryPlanActionLocation value)
        {
            switch( value )
            {
                case RecoveryPlanActionLocation.Primary:
                    return "Primary";
                case RecoveryPlanActionLocation.Recovery:
                    return "Recovery";
            }
            return null;
        }

        internal static RecoveryPlanActionLocation? ParseRecoveryPlanActionLocation(this string value)
        {
            switch( value )
            {
                case "Primary":
                    return RecoveryPlanActionLocation.Primary;
                case "Recovery":
                    return RecoveryPlanActionLocation.Recovery;
            }
            return null;
        }
    }
}
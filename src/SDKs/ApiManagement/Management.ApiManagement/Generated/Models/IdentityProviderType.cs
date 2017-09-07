// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IdentityProviderType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdentityProviderType
    {
        [EnumMember(Value = "facebook")]
        Facebook,
        [EnumMember(Value = "google")]
        Google,
        [EnumMember(Value = "microsoft")]
        Microsoft,
        [EnumMember(Value = "twitter")]
        Twitter,
        [EnumMember(Value = "aad")]
        Aad,
        [EnumMember(Value = "aadB2C")]
        AadB2C
    }
    internal static class IdentityProviderTypeEnumExtension
    {
        internal static string ToSerializedValue(this IdentityProviderType? value)  =>
            value == null ? null : ((IdentityProviderType)value).ToSerializedValue();

        internal static string ToSerializedValue(this IdentityProviderType value)
        {
            switch( value )
            {
                case IdentityProviderType.Facebook:
                    return "facebook";
                case IdentityProviderType.Google:
                    return "google";
                case IdentityProviderType.Microsoft:
                    return "microsoft";
                case IdentityProviderType.Twitter:
                    return "twitter";
                case IdentityProviderType.Aad:
                    return "aad";
                case IdentityProviderType.AadB2C:
                    return "aadB2C";
            }
            return null;
        }

        internal static IdentityProviderType? ParseIdentityProviderType(this string value)
        {
            switch( value )
            {
                case "facebook":
                    return IdentityProviderType.Facebook;
                case "google":
                    return IdentityProviderType.Google;
                case "microsoft":
                    return IdentityProviderType.Microsoft;
                case "twitter":
                    return IdentityProviderType.Twitter;
                case "aad":
                    return IdentityProviderType.Aad;
                case "aadB2C":
                    return IdentityProviderType.AadB2C;
            }
            return null;
        }
    }
}
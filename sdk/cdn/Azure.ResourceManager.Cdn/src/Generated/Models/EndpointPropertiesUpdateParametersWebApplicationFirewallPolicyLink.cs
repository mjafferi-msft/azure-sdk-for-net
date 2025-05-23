// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Defines the Web Application Firewall policy for the endpoint (if applicable)
    /// Serialized Name: EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink
    /// </summary>
    internal partial class EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink"/>. </summary>
        public EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink"/>. </summary>
        /// <param name="id">
        /// Resource ID.
        /// Serialized Name: EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink.id
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink(ResourceIdentifier id, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Resource ID.
        /// Serialized Name: EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink.id
        /// </summary>
        public ResourceIdentifier Id { get; set; }
    }
}

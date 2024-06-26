// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ScVmm.Models;

namespace Azure.ResourceManager.ScVmm
{
    /// <summary>
    /// A class representing the ScVmmGuestAgent data model.
    /// Defines the GuestAgent.
    /// </summary>
    public partial class ScVmmGuestAgentData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ScVmmGuestAgentData"/>. </summary>
        public ScVmmGuestAgentData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScVmmGuestAgentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="uuid"> Gets a unique identifier for this resource. </param>
        /// <param name="credentials"> Username / Password Credentials to provision guest agent. </param>
        /// <param name="httpProxyConfig"> HTTP Proxy configuration for the VM. </param>
        /// <param name="provisioningAction"> Gets or sets the guest agent provisioning action. </param>
        /// <param name="status"> Gets the guest agent status. </param>
        /// <param name="customResourceName"> Gets the name of the corresponding resource in Kubernetes. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScVmmGuestAgentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string uuid, ScVmmGuestCredential credentials, ScVmmHttpProxyConfiguration httpProxyConfig, ScVmmProvisioningAction? provisioningAction, string status, string customResourceName, ScVmmProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Uuid = uuid;
            Credentials = credentials;
            HttpProxyConfig = httpProxyConfig;
            ProvisioningAction = provisioningAction;
            Status = status;
            CustomResourceName = customResourceName;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets a unique identifier for this resource. </summary>
        public string Uuid { get; }
        /// <summary> Username / Password Credentials to provision guest agent. </summary>
        public ScVmmGuestCredential Credentials { get; set; }
        /// <summary> HTTP Proxy configuration for the VM. </summary>
        internal ScVmmHttpProxyConfiguration HttpProxyConfig { get; set; }
        /// <summary> Gets or sets httpsProxy url. </summary>
        public string HttpsProxy
        {
            get => HttpProxyConfig is null ? default : HttpProxyConfig.HttpsProxy;
            set
            {
                if (HttpProxyConfig is null)
                    HttpProxyConfig = new ScVmmHttpProxyConfiguration();
                HttpProxyConfig.HttpsProxy = value;
            }
        }

        /// <summary> Gets or sets the guest agent provisioning action. </summary>
        public ScVmmProvisioningAction? ProvisioningAction { get; set; }
        /// <summary> Gets the guest agent status. </summary>
        public string Status { get; }
        /// <summary> Gets the name of the corresponding resource in Kubernetes. </summary>
        public string CustomResourceName { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public ScVmmProvisioningState? ProvisioningState { get; }
    }
}

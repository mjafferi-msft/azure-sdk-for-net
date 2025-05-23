// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing the NetAppAccount data model.
    /// NetApp account resource
    /// </summary>
    public partial class NetAppAccountData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="NetAppAccountData"/>. </summary>
        /// <param name="location"> The location. </param>
        public NetAppAccountData(AzureLocation location) : base(location)
        {
            ActiveDirectories = new ChangeTrackingList<NetAppAccountActiveDirectory>();
        }

        /// <summary> Initializes a new instance of <see cref="NetAppAccountData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="identity"> The identity used for the resource. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        /// <param name="activeDirectories"> Active Directories. </param>
        /// <param name="encryption"> Encryption settings. </param>
        /// <param name="disableShowmount"> Shows the status of disableShowmount for all volumes under the subscription, null equals false. </param>
        /// <param name="nfsV4IdDomain"> Domain for NFSv4 user ID mapping. This property will be set for all NetApp accounts in the subscription and region and only affect non ldap NFSv4 volumes. </param>
        /// <param name="multiAdStatus"> MultiAD Status for the account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, ManagedServiceIdentity identity, string provisioningState, IList<NetAppAccountActiveDirectory> activeDirectories, NetAppAccountEncryption encryption, bool? disableShowmount, string nfsV4IdDomain, MultiAdStatus? multiAdStatus, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            Identity = identity;
            ProvisioningState = provisioningState;
            ActiveDirectories = activeDirectories;
            Encryption = encryption;
            DisableShowmount = disableShowmount;
            NfsV4IdDomain = nfsV4IdDomain;
            MultiAdStatus = multiAdStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppAccountData"/> for deserialization. </summary>
        internal NetAppAccountData()
        {
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The identity used for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
        /// <summary> Active Directories. </summary>
        public IList<NetAppAccountActiveDirectory> ActiveDirectories { get; }
        /// <summary> Encryption settings. </summary>
        public NetAppAccountEncryption Encryption { get; set; }
        /// <summary> Shows the status of disableShowmount for all volumes under the subscription, null equals false. </summary>
        public bool? DisableShowmount { get; }
        /// <summary> Domain for NFSv4 user ID mapping. This property will be set for all NetApp accounts in the subscription and region and only affect non ldap NFSv4 volumes. </summary>
        public string NfsV4IdDomain { get; set; }
        /// <summary> MultiAD Status for the account. </summary>
        public MultiAdStatus? MultiAdStatus { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StandbyPool.Models
{
    /// <summary> Specifies the elasticity profile of the standby container group pools. </summary>
    public partial class StandbyContainerGroupPoolElasticityPatchProfile
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

        /// <summary> Initializes a new instance of <see cref="StandbyContainerGroupPoolElasticityPatchProfile"/>. </summary>
        public StandbyContainerGroupPoolElasticityPatchProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StandbyContainerGroupPoolElasticityPatchProfile"/>. </summary>
        /// <param name="maxReadyCapacity"> Specifies maximum number of standby container groups in the standby pool. </param>
        /// <param name="refillPolicy"> Specifies refill policy of the pool. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StandbyContainerGroupPoolElasticityPatchProfile(long? maxReadyCapacity, StandbyPoolRefillPolicy? refillPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MaxReadyCapacity = maxReadyCapacity;
            RefillPolicy = refillPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies maximum number of standby container groups in the standby pool. </summary>
        public long? MaxReadyCapacity { get; set; }
        /// <summary> Specifies refill policy of the pool. </summary>
        public StandbyPoolRefillPolicy? RefillPolicy { get; set; }
    }
}

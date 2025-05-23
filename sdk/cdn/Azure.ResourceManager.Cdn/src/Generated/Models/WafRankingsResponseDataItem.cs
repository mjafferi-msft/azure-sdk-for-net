// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// The WafRankingsResponseDataItem.
    /// Serialized Name: WafRankingsResponseDataItem
    /// </summary>
    public partial class WafRankingsResponseDataItem
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

        /// <summary> Initializes a new instance of <see cref="WafRankingsResponseDataItem"/>. </summary>
        internal WafRankingsResponseDataItem()
        {
            GroupValues = new ChangeTrackingList<string>();
            Metrics = new ChangeTrackingList<ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems>();
        }

        /// <summary> Initializes a new instance of <see cref="WafRankingsResponseDataItem"/>. </summary>
        /// <param name="groupValues"> Serialized Name: WafRankingsResponseDataItem.groupValues. </param>
        /// <param name="metrics"> Serialized Name: WafRankingsResponseDataItem.metrics. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WafRankingsResponseDataItem(IReadOnlyList<string> groupValues, IReadOnlyList<ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems> metrics, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GroupValues = groupValues;
            Metrics = metrics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Serialized Name: WafRankingsResponseDataItem.groupValues. </summary>
        public IReadOnlyList<string> GroupValues { get; }
        /// <summary> Serialized Name: WafRankingsResponseDataItem.metrics. </summary>
        public IReadOnlyList<ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems> Metrics { get; }
    }
}

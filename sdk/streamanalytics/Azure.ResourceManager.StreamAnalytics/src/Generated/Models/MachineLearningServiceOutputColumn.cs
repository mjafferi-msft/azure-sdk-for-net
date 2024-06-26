// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes an output column for the Azure Machine Learning web service endpoint. </summary>
    public partial class MachineLearningServiceOutputColumn
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningServiceOutputColumn"/>. </summary>
        public MachineLearningServiceOutputColumn()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningServiceOutputColumn"/>. </summary>
        /// <param name="name"> The name of the output column. </param>
        /// <param name="dataType"> The (Azure Machine Learning supported) data type of the output column. </param>
        /// <param name="mapTo"> The zero based index of the function parameter this input maps to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningServiceOutputColumn(string name, string dataType, int? mapTo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            DataType = dataType;
            MapTo = mapTo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the output column. </summary>
        public string Name { get; set; }
        /// <summary> The (Azure Machine Learning supported) data type of the output column. </summary>
        public string DataType { get; set; }
        /// <summary> The zero based index of the function parameter this input maps to. </summary>
        public int? MapTo { get; set; }
    }
}

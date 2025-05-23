// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    public partial class PreRulestackRuleResource : IJsonModel<PreRulestackRuleData>
    {
        private static PreRulestackRuleData s_dataDeserializationInstance;
        private static PreRulestackRuleData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<PreRulestackRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PreRulestackRuleData>)Data).Write(writer, options);

        PreRulestackRuleData IJsonModel<PreRulestackRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PreRulestackRuleData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<PreRulestackRuleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<PreRulestackRuleData>(Data, options, AzureResourceManagerPaloAltoNetworksNgfwContext.Default);

        PreRulestackRuleData IPersistableModel<PreRulestackRuleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PreRulestackRuleData>(data, options, AzureResourceManagerPaloAltoNetworksNgfwContext.Default);

        string IPersistableModel<PreRulestackRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PreRulestackRuleData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

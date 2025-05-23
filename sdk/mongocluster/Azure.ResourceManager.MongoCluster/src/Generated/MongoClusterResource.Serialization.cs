// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MongoCluster
{
    public partial class MongoClusterResource : IJsonModel<MongoClusterData>
    {
        private static MongoClusterData s_dataDeserializationInstance;
        private static MongoClusterData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<MongoClusterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MongoClusterData>)Data).Write(writer, options);

        MongoClusterData IJsonModel<MongoClusterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MongoClusterData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<MongoClusterData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MongoClusterData>(Data, options, AzureResourceManagerMongoClusterContext.Default);

        MongoClusterData IPersistableModel<MongoClusterData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MongoClusterData>(data, options, AzureResourceManagerMongoClusterContext.Default);

        string IPersistableModel<MongoClusterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MongoClusterData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

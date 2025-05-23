// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class ElasticUserEmailId : IUtf8JsonSerializable, IJsonModel<ElasticUserEmailId>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticUserEmailId>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ElasticUserEmailId>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticUserEmailId>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticUserEmailId)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(EmailId))
            {
                writer.WritePropertyName("emailId"u8);
                writer.WriteStringValue(EmailId);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ElasticUserEmailId IJsonModel<ElasticUserEmailId>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticUserEmailId>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticUserEmailId)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticUserEmailId(document.RootElement, options);
        }

        internal static ElasticUserEmailId DeserializeElasticUserEmailId(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string emailId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("emailId"u8))
                {
                    emailId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ElasticUserEmailId(emailId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ElasticUserEmailId>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticUserEmailId>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerElasticContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ElasticUserEmailId)} does not support writing '{options.Format}' format.");
            }
        }

        ElasticUserEmailId IPersistableModel<ElasticUserEmailId>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticUserEmailId>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeElasticUserEmailId(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ElasticUserEmailId)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticUserEmailId>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

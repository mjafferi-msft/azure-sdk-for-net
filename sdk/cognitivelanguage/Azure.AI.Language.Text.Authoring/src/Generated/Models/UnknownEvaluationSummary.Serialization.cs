// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring.Models
{
    internal partial class UnknownEvaluationSummary : IUtf8JsonSerializable, IJsonModel<EvaluationSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EvaluationSummary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EvaluationSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EvaluationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EvaluationSummary)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        EvaluationSummary IJsonModel<EvaluationSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EvaluationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EvaluationSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEvaluationSummary(document.RootElement, options);
        }

        internal static UnknownEvaluationSummary DeserializeUnknownEvaluationSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProjectKind projectKind = "Unknown";
            EvaluationDetails evaluationOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("projectKind"u8))
                {
                    projectKind = new ProjectKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("evaluationOptions"u8))
                {
                    evaluationOptions = EvaluationDetails.DeserializeEvaluationDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownEvaluationSummary(projectKind, evaluationOptions, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EvaluationSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EvaluationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EvaluationSummary)} does not support writing '{options.Format}' format.");
            }
        }

        EvaluationSummary IPersistableModel<EvaluationSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EvaluationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEvaluationSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EvaluationSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EvaluationSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new UnknownEvaluationSummary FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnknownEvaluationSummary(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<EvaluationSummary>(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}

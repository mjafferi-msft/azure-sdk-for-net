// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class MediaJobFinishedEventData : IUtf8JsonSerializable, IJsonModel<MediaJobFinishedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaJobFinishedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MediaJobFinishedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobFinishedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaJobFinishedEventData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("outputs"u8);
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
        }

        MediaJobFinishedEventData IJsonModel<MediaJobFinishedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobFinishedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaJobFinishedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobFinishedEventData(document.RootElement, options);
        }

        internal static MediaJobFinishedEventData DeserializeMediaJobFinishedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MediaJobOutput> outputs = default;
            MediaJobState previousState = default;
            MediaJobState state = default;
            IReadOnlyDictionary<string, string> correlationData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outputs"u8))
                {
                    List<MediaJobOutput> array = new List<MediaJobOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaJobOutput.DeserializeMediaJobOutput(item, options));
                    }
                    outputs = array;
                    continue;
                }
                if (property.NameEquals("previousState"u8))
                {
                    previousState = new MediaJobState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = new MediaJobState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("correlationData"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    correlationData = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MediaJobFinishedEventData(previousState, state, correlationData, serializedAdditionalRawData, outputs);
        }

        BinaryData IPersistableModel<MediaJobFinishedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobFinishedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaJobFinishedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        MediaJobFinishedEventData IPersistableModel<MediaJobFinishedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobFinishedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaJobFinishedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaJobFinishedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaJobFinishedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new MediaJobFinishedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMediaJobFinishedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageActiveDirectoryProperties : IUtf8JsonSerializable, IJsonModel<StorageActiveDirectoryProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageActiveDirectoryProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageActiveDirectoryProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageActiveDirectoryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageActiveDirectoryProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("domainName"u8);
            writer.WriteStringValue(DomainName);
            if (Optional.IsDefined(NetBiosDomainName))
            {
                writer.WritePropertyName("netBiosDomainName"u8);
                writer.WriteStringValue(NetBiosDomainName);
            }
            if (Optional.IsDefined(ForestName))
            {
                writer.WritePropertyName("forestName"u8);
                writer.WriteStringValue(ForestName);
            }
            writer.WritePropertyName("domainGuid"u8);
            writer.WriteStringValue(DomainGuid);
            if (Optional.IsDefined(DomainSid))
            {
                writer.WritePropertyName("domainSid"u8);
                writer.WriteStringValue(DomainSid);
            }
            if (Optional.IsDefined(AzureStorageSid))
            {
                writer.WritePropertyName("azureStorageSid"u8);
                writer.WriteStringValue(AzureStorageSid);
            }
            if (Optional.IsDefined(SamAccountName))
            {
                writer.WritePropertyName("samAccountName"u8);
                writer.WriteStringValue(SamAccountName);
            }
            if (Optional.IsDefined(AccountType))
            {
                writer.WritePropertyName("accountType"u8);
                writer.WriteStringValue(AccountType.Value.ToString());
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

        StorageActiveDirectoryProperties IJsonModel<StorageActiveDirectoryProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageActiveDirectoryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageActiveDirectoryProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageActiveDirectoryProperties(document.RootElement, options);
        }

        internal static StorageActiveDirectoryProperties DeserializeStorageActiveDirectoryProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainName = default;
            string netBiosDomainName = default;
            string forestName = default;
            Guid domainGuid = default;
            string domainSid = default;
            string azureStorageSid = default;
            string samAccountName = default;
            ActiveDirectoryAccountType? accountType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("netBiosDomainName"u8))
                {
                    netBiosDomainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("forestName"u8))
                {
                    forestName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainGuid"u8))
                {
                    DeserializeNullableGuid(property, ref domainGuid);
                    continue;
                }
                if (property.NameEquals("domainSid"u8))
                {
                    domainSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureStorageSid"u8))
                {
                    azureStorageSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("samAccountName"u8))
                {
                    samAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountType = new ActiveDirectoryAccountType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageActiveDirectoryProperties(
                domainName,
                netBiosDomainName,
                forestName,
                domainGuid,
                domainSid,
                azureStorageSid,
                samAccountName,
                accountType,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DomainName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  domainName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DomainName))
                {
                    builder.Append("  domainName: ");
                    if (DomainName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DomainName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DomainName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NetBiosDomainName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  netBiosDomainName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NetBiosDomainName))
                {
                    builder.Append("  netBiosDomainName: ");
                    if (NetBiosDomainName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{NetBiosDomainName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{NetBiosDomainName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ForestName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  forestName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ForestName))
                {
                    builder.Append("  forestName: ");
                    if (ForestName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ForestName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ForestName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DomainGuid), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  domainGuid: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  domainGuid: ");
                builder.AppendLine($"'{DomainGuid.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DomainSid), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  domainSid: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DomainSid))
                {
                    builder.Append("  domainSid: ");
                    if (DomainSid.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DomainSid}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DomainSid}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureStorageSid), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  azureStorageSid: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AzureStorageSid))
                {
                    builder.Append("  azureStorageSid: ");
                    if (AzureStorageSid.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AzureStorageSid}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AzureStorageSid}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SamAccountName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  samAccountName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SamAccountName))
                {
                    builder.Append("  samAccountName: ");
                    if (SamAccountName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SamAccountName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SamAccountName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccountType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  accountType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccountType))
                {
                    builder.Append("  accountType: ");
                    builder.AppendLine($"'{AccountType.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<StorageActiveDirectoryProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageActiveDirectoryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStorageContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StorageActiveDirectoryProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StorageActiveDirectoryProperties IPersistableModel<StorageActiveDirectoryProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageActiveDirectoryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStorageActiveDirectoryProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageActiveDirectoryProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageActiveDirectoryProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Input of the secret to be validated.
    /// Serialized Name: ValidateSecretInput
    /// </summary>
    public partial class ValidateSecretContent
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

        /// <summary> Initializes a new instance of <see cref="ValidateSecretContent"/>. </summary>
        /// <param name="secretType">
        /// The secret type.
        /// Serialized Name: ValidateSecretInput.secretType
        /// </param>
        /// <param name="secretSource">
        /// Resource reference to the Azure Key Vault secret. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{secretName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​
        /// Serialized Name: ValidateSecretInput.secretSource
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretSource"/> is null. </exception>
        public ValidateSecretContent(SecretType secretType, WritableSubResource secretSource)
        {
            Argument.AssertNotNull(secretSource, nameof(secretSource));

            SecretType = secretType;
            SecretSource = secretSource;
        }

        /// <summary> Initializes a new instance of <see cref="ValidateSecretContent"/>. </summary>
        /// <param name="secretType">
        /// The secret type.
        /// Serialized Name: ValidateSecretInput.secretType
        /// </param>
        /// <param name="secretSource">
        /// Resource reference to the Azure Key Vault secret. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{secretName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​
        /// Serialized Name: ValidateSecretInput.secretSource
        /// </param>
        /// <param name="secretVersion">
        /// Secret version, if customer is using a specific version.
        /// Serialized Name: ValidateSecretInput.secretVersion
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ValidateSecretContent(SecretType secretType, WritableSubResource secretSource, string secretVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SecretType = secretType;
            SecretSource = secretSource;
            SecretVersion = secretVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ValidateSecretContent"/> for deserialization. </summary>
        internal ValidateSecretContent()
        {
        }

        /// <summary>
        /// The secret type.
        /// Serialized Name: ValidateSecretInput.secretType
        /// </summary>
        public SecretType SecretType { get; }
        /// <summary>
        /// Resource reference to the Azure Key Vault secret. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{secretName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​
        /// Serialized Name: ValidateSecretInput.secretSource
        /// </summary>
        internal WritableSubResource SecretSource { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SecretSourceId
        {
            get => SecretSource?.Id;
        }

        /// <summary>
        /// Secret version, if customer is using a specific version.
        /// Serialized Name: ValidateSecretInput.secretVersion
        /// </summary>
        public string SecretVersion { get; set; }
    }
}

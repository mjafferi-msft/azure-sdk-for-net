// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the SecurityCenterPricing data model.
    /// Microsoft Defender for Cloud is provided in two pricing tiers: free and standard. The standard tier offers advanced security capabilities, while the free tier offers basic security features.
    /// </summary>
    public partial class SecurityCenterPricingData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SecurityCenterPricingData"/>. </summary>
        public SecurityCenterPricingData()
        {
            ReplacedBy = new ChangeTrackingList<string>();
            Extensions = new ChangeTrackingList<PlanExtension>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityCenterPricingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="pricingTier"> The pricing tier value. Microsoft Defender for Cloud is provided in two pricing tiers: free and standard. The standard tier offers advanced security capabilities, while the free tier offers basic security features. </param>
        /// <param name="subPlan"> The sub-plan selected for a Standard pricing configuration, when more than one sub-plan is available. Each sub-plan enables a set of security features. When not specified, full plan is applied. </param>
        /// <param name="freeTrialRemainingTime"> The duration left for the subscriptions free trial period - in ISO 8601 format (e.g. P3Y6M4DT12H30M5S). </param>
        /// <param name="enabledOn"> Optional. If `pricingTier` is `Standard` then this property holds the date of the last time the `pricingTier` was set to `Standard`, when available (e.g 2023-03-01T12:42:42.1921106Z). </param>
        /// <param name="isDeprecated"> Optional. True if the plan is deprecated. If there are replacing plans they will appear in `replacedBy` property. </param>
        /// <param name="replacedBy"> Optional. List of plans that replace this plan. This property exists only if this plan is deprecated. </param>
        /// <param name="extensions"> Optional. List of extensions offered under a plan. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityCenterPricingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityCenterPricingTier? pricingTier, string subPlan, TimeSpan? freeTrialRemainingTime, DateTimeOffset? enabledOn, bool? isDeprecated, IReadOnlyList<string> replacedBy, IList<PlanExtension> extensions, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            PricingTier = pricingTier;
            SubPlan = subPlan;
            FreeTrialRemainingTime = freeTrialRemainingTime;
            EnabledOn = enabledOn;
            IsDeprecated = isDeprecated;
            ReplacedBy = replacedBy;
            Extensions = extensions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The pricing tier value. Microsoft Defender for Cloud is provided in two pricing tiers: free and standard. The standard tier offers advanced security capabilities, while the free tier offers basic security features. </summary>
        public SecurityCenterPricingTier? PricingTier { get; set; }
        /// <summary> The sub-plan selected for a Standard pricing configuration, when more than one sub-plan is available. Each sub-plan enables a set of security features. When not specified, full plan is applied. </summary>
        public string SubPlan { get; set; }
        /// <summary> The duration left for the subscriptions free trial period - in ISO 8601 format (e.g. P3Y6M4DT12H30M5S). </summary>
        public TimeSpan? FreeTrialRemainingTime { get; }
        /// <summary> Optional. If `pricingTier` is `Standard` then this property holds the date of the last time the `pricingTier` was set to `Standard`, when available (e.g 2023-03-01T12:42:42.1921106Z). </summary>
        public DateTimeOffset? EnabledOn { get; }
        /// <summary> Optional. True if the plan is deprecated. If there are replacing plans they will appear in `replacedBy` property. </summary>
        public bool? IsDeprecated { get; }
        /// <summary> Optional. List of plans that replace this plan. This property exists only if this plan is deprecated. </summary>
        public IReadOnlyList<string> ReplacedBy { get; }
        /// <summary> Optional. List of extensions offered under a plan. </summary>
        public IList<PlanExtension> Extensions { get; }
    }
}

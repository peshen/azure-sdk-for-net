// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.EventGrid;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about the event hub destination for an event subscription
    /// </summary>
    [Newtonsoft.Json.JsonObject("EventHub")]
    [Rest.Serialization.JsonTransformation]
    public partial class EventHubEventSubscriptionDestination : EventSubscriptionDestination
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EventHubEventSubscriptionDestination class.
        /// </summary>
        public EventHubEventSubscriptionDestination()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// EventHubEventSubscriptionDestination class.
        /// </summary>
        /// <param name="resourceId">The Azure Resource Id that represents the
        /// endpoint of an Event Hub destination of an event
        /// subscription.</param>
        public EventHubEventSubscriptionDestination(string resourceId = default(string))
        {
            ResourceId = resourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Resource Id that represents the endpoint of
        /// an Event Hub destination of an event subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceId")]
        public string ResourceId { get; set; }

    }
}

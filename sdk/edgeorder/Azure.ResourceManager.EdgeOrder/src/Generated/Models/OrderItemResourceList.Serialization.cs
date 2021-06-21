// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    internal partial class OrderItemResourceList
    {
        internal static OrderItemResourceList DeserializeOrderItemResourceList(JsonElement element)
        {
            Optional<IReadOnlyList<OrderItemResource>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<OrderItemResource> array = new List<OrderItemResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OrderItemResource.DeserializeOrderItemResource(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new OrderItemResourceList(Optional.ToList(value), nextLink.Value);
        }
    }
}

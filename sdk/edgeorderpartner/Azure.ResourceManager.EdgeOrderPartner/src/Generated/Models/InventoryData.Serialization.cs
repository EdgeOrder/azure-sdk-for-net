// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrderPartner.Models
{
    public partial class InventoryData
    {
        internal static InventoryData DeserializeInventoryData(JsonElement element)
        {
            Optional<string> status = default;
            Optional<string> location = default;
            Optional<bool> registrationAllowed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registrationAllowed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    registrationAllowed = property.Value.GetBoolean();
                    continue;
                }
            }
            return new InventoryData(status.Value, location.Value, Optional.ToNullable(registrationAllowed));
        }
    }
}

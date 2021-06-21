// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class FilterableProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("supportedValues");
            writer.WriteStartArray();
            foreach (var item in SupportedValues)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static FilterableProperty DeserializeFilterableProperty(JsonElement element)
        {
            SupportedFilterTypes type = default;
            IList<string> supportedValues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new SupportedFilterTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("supportedValues"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedValues = array;
                    continue;
                }
            }
            return new FilterableProperty(type, supportedValues);
        }
    }
}

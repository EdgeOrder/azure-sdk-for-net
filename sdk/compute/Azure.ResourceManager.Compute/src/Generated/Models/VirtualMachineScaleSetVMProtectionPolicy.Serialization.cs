// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetVMProtectionPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ProtectFromScaleIn != null)
            {
                writer.WritePropertyName("protectFromScaleIn");
                writer.WriteBooleanValue(ProtectFromScaleIn.Value);
            }
            if (ProtectFromScaleSetActions != null)
            {
                writer.WritePropertyName("protectFromScaleSetActions");
                writer.WriteBooleanValue(ProtectFromScaleSetActions.Value);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetVMProtectionPolicy DeserializeVirtualMachineScaleSetVMProtectionPolicy(JsonElement element)
        {
            bool? protectFromScaleIn = default;
            bool? protectFromScaleSetActions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectFromScaleIn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectFromScaleIn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("protectFromScaleSetActions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectFromScaleSetActions = property.Value.GetBoolean();
                    continue;
                }
            }
            return new VirtualMachineScaleSetVMProtectionPolicy(protectFromScaleIn, protectFromScaleSetActions);
        }
    }
}
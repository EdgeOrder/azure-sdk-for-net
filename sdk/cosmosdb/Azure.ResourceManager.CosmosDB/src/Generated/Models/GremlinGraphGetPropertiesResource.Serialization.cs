// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class GremlinGraphGetPropertiesResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(IndexingPolicy))
            {
                writer.WritePropertyName("indexingPolicy");
                writer.WriteObjectValue(IndexingPolicy);
            }
            if (Optional.IsDefined(PartitionKey))
            {
                writer.WritePropertyName("partitionKey");
                writer.WriteObjectValue(PartitionKey);
            }
            if (Optional.IsDefined(DefaultTtl))
            {
                writer.WritePropertyName("defaultTtl");
                writer.WriteNumberValue(DefaultTtl.Value);
            }
            if (Optional.IsDefined(UniqueKeyPolicy))
            {
                writer.WritePropertyName("uniqueKeyPolicy");
                writer.WriteObjectValue(UniqueKeyPolicy);
            }
            if (Optional.IsDefined(ConflictResolutionPolicy))
            {
                writer.WritePropertyName("conflictResolutionPolicy");
                writer.WriteObjectValue(ConflictResolutionPolicy);
            }
            writer.WriteEndObject();
        }

        internal static GremlinGraphGetPropertiesResource DeserializeGremlinGraphGetPropertiesResource(JsonElement element)
        {
            Optional<string> Rid = default;
            Optional<object> Ts = default;
            Optional<string> Etag = default;
            string id = default;
            Optional<IndexingPolicy> indexingPolicy = default;
            Optional<ContainerPartitionKey> partitionKey = default;
            Optional<int> defaultTtl = default;
            Optional<UniqueKeyPolicy> uniqueKeyPolicy = default;
            Optional<ConflictResolutionPolicy> conflictResolutionPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"))
                {
                    Rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"))
                {
                    Ts = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("_etag"))
                {
                    Etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("indexingPolicy"))
                {
                    indexingPolicy = IndexingPolicy.DeserializeIndexingPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("partitionKey"))
                {
                    partitionKey = ContainerPartitionKey.DeserializeContainerPartitionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("defaultTtl"))
                {
                    defaultTtl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("uniqueKeyPolicy"))
                {
                    uniqueKeyPolicy = UniqueKeyPolicy.DeserializeUniqueKeyPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("conflictResolutionPolicy"))
                {
                    conflictResolutionPolicy = ConflictResolutionPolicy.DeserializeConflictResolutionPolicy(property.Value);
                    continue;
                }
            }
            return new GremlinGraphGetPropertiesResource(id, indexingPolicy.Value, partitionKey.Value, Optional.ToNullable(defaultTtl), uniqueKeyPolicy.Value, conflictResolutionPolicy.Value, Rid.Value, Ts.Value, Etag.Value);
        }
    }
}
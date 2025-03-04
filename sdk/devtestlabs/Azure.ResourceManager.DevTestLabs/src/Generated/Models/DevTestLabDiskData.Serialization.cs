// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabDiskData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DiskType))
            {
                writer.WritePropertyName("diskType");
                writer.WriteStringValue(DiskType.Value.ToString());
            }
            if (Optional.IsDefined(DiskSizeGiB))
            {
                writer.WritePropertyName("diskSizeGiB");
                writer.WriteNumberValue(DiskSizeGiB.Value);
            }
            if (Optional.IsDefined(LeasedByLabVmId))
            {
                writer.WritePropertyName("leasedByLabVmId");
                writer.WriteStringValue(LeasedByLabVmId);
            }
            if (Optional.IsDefined(DiskBlobName))
            {
                writer.WritePropertyName("diskBlobName");
                writer.WriteStringValue(DiskBlobName);
            }
            if (Optional.IsDefined(DiskUri))
            {
                writer.WritePropertyName("diskUri");
                writer.WriteStringValue(DiskUri.AbsoluteUri);
            }
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId");
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(HostCaching))
            {
                writer.WritePropertyName("hostCaching");
                writer.WriteStringValue(HostCaching);
            }
            if (Optional.IsDefined(ManagedDiskId))
            {
                writer.WritePropertyName("managedDiskId");
                writer.WriteStringValue(ManagedDiskId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DevTestLabDiskData DeserializeDevTestLabDiskData(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DevTestLabStorageType> diskType = default;
            Optional<int> diskSizeGiB = default;
            Optional<string> leasedByLabVmId = default;
            Optional<string> diskBlobName = default;
            Optional<Uri> diskUri = default;
            Optional<string> storageAccountId = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<string> hostCaching = default;
            Optional<string> managedDiskId = default;
            Optional<string> provisioningState = default;
            Optional<string> uniqueIdentifier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("diskType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diskType = new DevTestLabStorageType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("diskSizeGiB"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diskSizeGiB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("leasedByLabVmId"))
                        {
                            leasedByLabVmId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("diskBlobName"))
                        {
                            diskBlobName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("diskUri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                diskUri = null;
                                continue;
                            }
                            diskUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageAccountId"))
                        {
                            storageAccountId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("hostCaching"))
                        {
                            hostCaching = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedDiskId"))
                        {
                            managedDiskId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"))
                        {
                            uniqueIdentifier = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DevTestLabDiskData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(diskType), Optional.ToNullable(diskSizeGiB), leasedByLabVmId.Value, diskBlobName.Value, diskUri.Value, storageAccountId.Value, Optional.ToNullable(createdDate), hostCaching.Value, managedDiskId.Value, provisioningState.Value, uniqueIdentifier.Value);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ExportJobDetails
    {
        internal static ExportJobDetails DeserializeExportJobDetails(JsonElement element)
        {
            Optional<Uri> blobUri = default;
            Optional<string> sasToken = default;
            string instanceType = default;
            Optional<IReadOnlyDictionary<string, string>> affectedObjectDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blobUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        blobUri = null;
                        continue;
                    }
                    blobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sasToken"))
                {
                    sasToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectDetails"))
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
                    affectedObjectDetails = dictionary;
                    continue;
                }
            }
            return new ExportJobDetails(instanceType, Optional.ToDictionary(affectedObjectDetails), blobUri.Value, sasToken.Value);
        }
    }
}

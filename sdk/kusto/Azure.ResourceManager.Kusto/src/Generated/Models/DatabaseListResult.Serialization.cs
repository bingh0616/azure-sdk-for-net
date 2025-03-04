// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    internal partial class DatabaseListResult
    {
        internal static DatabaseListResult DeserializeDatabaseListResult(JsonElement element)
        {
            Optional<IReadOnlyList<KustoDatabaseData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KustoDatabaseData> array = new List<KustoDatabaseData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KustoDatabaseData.DeserializeKustoDatabaseData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DatabaseListResult(Optional.ToList(value));
        }
    }
}

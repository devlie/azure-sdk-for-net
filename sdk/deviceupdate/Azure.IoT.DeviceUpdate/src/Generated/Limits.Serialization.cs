// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.IoT.DeviceUpdate
{
    public partial class Limits
    {
        internal static Limits DeserializeLimits(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Counters counters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("counters"u8))
                {
                    counters = Counters.DeserializeCounters(property.Value);
                    continue;
                }
            }
            return new Limits(counters);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Limits FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLimits(document.RootElement);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate
{
    public partial class LogCollectionOperationDetailedStatus
    {
        internal static LogCollectionOperationDetailedStatus DeserializeLogCollectionOperationDetailedStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> operationId = default;
            Optional<string> createdDateTime = default;
            Optional<string> lastActionDateTime = default;
            Optional<OperationStatus> status = default;
            Optional<IReadOnlyList<LogCollectionOperationDeviceStatus>> deviceStatus = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastActionDateTime"u8))
                {
                    lastActionDateTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new OperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deviceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LogCollectionOperationDeviceStatus> array = new List<LogCollectionOperationDeviceStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogCollectionOperationDeviceStatus.DeserializeLogCollectionOperationDeviceStatus(item));
                    }
                    deviceStatus = array;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new LogCollectionOperationDetailedStatus(operationId.Value, createdDateTime.Value, lastActionDateTime.Value, Optional.ToNullable(status), Optional.ToList(deviceStatus), description.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LogCollectionOperationDetailedStatus FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLogCollectionOperationDetailedStatus(document.RootElement);
        }
    }
}

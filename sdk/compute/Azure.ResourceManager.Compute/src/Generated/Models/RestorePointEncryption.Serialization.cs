// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RestorePointEncryption : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DiskEncryptionSet))
            {
                writer.WritePropertyName("diskEncryptionSet"u8);
                JsonSerializer.Serialize(writer, DiskEncryptionSet);
            }
            if (Optional.IsDefined(EncryptionType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(EncryptionType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static RestorePointEncryption DeserializeRestorePointEncryption(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WritableSubResource> diskEncryptionSet = default;
            Optional<RestorePointEncryptionType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskEncryptionSet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSet = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new RestorePointEncryptionType(property.Value.GetString());
                    continue;
                }
            }
            return new RestorePointEncryption(diskEncryptionSet, Optional.ToNullable(type));
        }
    }
}

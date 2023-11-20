// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate
{
    public partial class UpdateId : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("provider"u8);
            writer.WriteStringValue(Provider);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("version"u8);
            writer.WriteStringValue(Version);
            writer.WriteEndObject();
        }

        internal static UpdateId DeserializeUpdateId(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string provider = default;
            string name = default;
            string version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provider"u8))
                {
                    provider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
            }
            return new UpdateId(provider, name, version);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static UpdateId FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUpdateId(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}

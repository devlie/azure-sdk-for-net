// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate
{
    /// <summary>
    /// Metadata describing the import manifest, a document which describes the files
    /// and other metadata about an update version.
    /// </summary>
    public partial class ImportManifestMetadata
    {
        /// <summary> Initializes a new instance of ImportManifestMetadata. </summary>
        /// <param name="url">
        /// Azure Blob location from which the import manifest can be downloaded by Device
        /// Update for IoT Hub. This is typically a read-only SAS-protected blob URL with
        /// an expiration set to at least 4 hours.
        /// </param>
        /// <param name="sizeInBytes"> File size in number of bytes. </param>
        /// <param name="hashes">
        /// A JSON object containing the hash(es) of the file. At least SHA256 hash is
        /// required. This object can be thought of as a set of key-value pairs where the
        /// key is the hash algorithm, and the value is the hash of the file calculated
        /// using that algorithm.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> or <paramref name="hashes"/> is null. </exception>
        public ImportManifestMetadata(string url, long sizeInBytes, IDictionary<string, string> hashes)
        {
            Argument.AssertNotNull(url, nameof(url));
            Argument.AssertNotNull(hashes, nameof(hashes));

            Url = url;
            SizeInBytes = sizeInBytes;
            Hashes = hashes;
        }

        /// <summary>
        /// Azure Blob location from which the import manifest can be downloaded by Device
        /// Update for IoT Hub. This is typically a read-only SAS-protected blob URL with
        /// an expiration set to at least 4 hours.
        /// </summary>
        public string Url { get; }
        /// <summary> File size in number of bytes. </summary>
        public long SizeInBytes { get; }
        /// <summary>
        /// A JSON object containing the hash(es) of the file. At least SHA256 hash is
        /// required. This object can be thought of as a set of key-value pairs where the
        /// key is the hash algorithm, and the value is the hash of the file calculated
        /// using that algorithm.
        /// </summary>
        public IDictionary<string, string> Hashes { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate
{
    /// <summary> Import update input item metadata. </summary>
    public partial class ImportUpdateInputItem
    {
        /// <summary> Initializes a new instance of ImportUpdateInputItem. </summary>
        /// <param name="importManifest"> Import manifest metadata like source URL, file size/hashes, etc. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="importManifest"/> is null. </exception>
        public ImportUpdateInputItem(ImportManifestMetadata importManifest)
        {
            Argument.AssertNotNull(importManifest, nameof(importManifest));

            ImportManifest = importManifest;
            Files = new ChangeTrackingList<FileImportMetadata>();
        }

        /// <summary> Initializes a new instance of ImportUpdateInputItem. </summary>
        /// <param name="importManifest"> Import manifest metadata like source URL, file size/hashes, etc. </param>
        /// <param name="friendlyName"> Friendly update name. </param>
        /// <param name="files"> One or more update file properties like filename and source URL. </param>
        internal ImportUpdateInputItem(ImportManifestMetadata importManifest, string friendlyName, IList<FileImportMetadata> files)
        {
            ImportManifest = importManifest;
            FriendlyName = friendlyName;
            Files = files;
        }

        /// <summary> Import manifest metadata like source URL, file size/hashes, etc. </summary>
        public ImportManifestMetadata ImportManifest { get; }
        /// <summary> Friendly update name. </summary>
        public string FriendlyName { get; set; }
        /// <summary> One or more update file properties like filename and source URL. </summary>
        public IList<FileImportMetadata> Files { get; }
    }
}

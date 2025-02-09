// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Metadata resource. </summary>
    public partial class SelfHelpSolutionMetadata : ResourceData
    {
        /// <summary> Initializes a new instance of SelfHelpSolutionMetadata. </summary>
        public SelfHelpSolutionMetadata()
        {
            Solutions = new ChangeTrackingList<SolutionMetadataProperties>();
        }

        /// <summary> Initializes a new instance of SelfHelpSolutionMetadata. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="solutions"> List of metadata. </param>
        internal SelfHelpSolutionMetadata(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<SolutionMetadataProperties> solutions) : base(id, name, resourceType, systemData)
        {
            Solutions = solutions;
        }

        /// <summary> List of metadata. </summary>
        public IList<SolutionMetadataProperties> Solutions { get; }
    }
}

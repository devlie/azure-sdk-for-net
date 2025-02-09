// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppComplianceAutomation;

namespace Azure.ResourceManager.AppComplianceAutomation.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableAppComplianceAutomationArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAppComplianceAutomationArmClient"/> class for mocking. </summary>
        protected MockableAppComplianceAutomationArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAppComplianceAutomationArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAppComplianceAutomationArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableAppComplianceAutomationArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="ReportResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ReportResource.CreateResourceIdentifier" /> to create a <see cref="ReportResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ReportResource" /> object. </returns>
        public virtual ReportResource GetReportResource(ResourceIdentifier id)
        {
            ReportResource.ValidateResourceId(id);
            return new ReportResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SnapshotResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SnapshotResource.CreateResourceIdentifier" /> to create a <see cref="SnapshotResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SnapshotResource" /> object. </returns>
        public virtual SnapshotResource GetSnapshotResource(ResourceIdentifier id)
        {
            SnapshotResource.ValidateResourceId(id);
            return new SnapshotResource(Client, id);
        }
    }
}

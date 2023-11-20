// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate
{
    /// <summary> Device diagnostics operation detailed status. </summary>
    public partial class LogCollectionOperationDetailedStatus
    {
        /// <summary> Initializes a new instance of LogCollectionOperationDetailedStatus. </summary>
        internal LogCollectionOperationDetailedStatus()
        {
            DeviceStatus = new ChangeTrackingList<LogCollectionOperationDeviceStatus>();
        }

        /// <summary> Initializes a new instance of LogCollectionOperationDetailedStatus. </summary>
        /// <param name="operationId"> The device diagnostics operation id. </param>
        /// <param name="createdDateTime"> The timestamp when the operation was created. </param>
        /// <param name="lastActionDateTime"> A timestamp for when the current state was entered. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="deviceStatus"> Status of the devices in the operation. </param>
        /// <param name="description"> Device diagnostics operation description. </param>
        internal LogCollectionOperationDetailedStatus(string operationId, string createdDateTime, string lastActionDateTime, OperationStatus? status, IReadOnlyList<LogCollectionOperationDeviceStatus> deviceStatus, string description)
        {
            OperationId = operationId;
            CreatedDateTime = createdDateTime;
            LastActionDateTime = lastActionDateTime;
            Status = status;
            DeviceStatus = deviceStatus;
            Description = description;
        }

        /// <summary> The device diagnostics operation id. </summary>
        public string OperationId { get; }
        /// <summary> The timestamp when the operation was created. </summary>
        public string CreatedDateTime { get; }
        /// <summary> A timestamp for when the current state was entered. </summary>
        public string LastActionDateTime { get; }
        /// <summary> Operation status. </summary>
        public OperationStatus? Status { get; }
        /// <summary> Status of the devices in the operation. </summary>
        public IReadOnlyList<LogCollectionOperationDeviceStatus> DeviceStatus { get; }
        /// <summary> Device diagnostics operation description. </summary>
        public string Description { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;

namespace Azure.IoT.DeviceUpdate
{
    /// <summary> Operation metadata. </summary>
    public partial class DeviceOperation
    {
        /// <summary> Initializes a new instance of DeviceOperation. </summary>
        /// <param name="status"> Operation status. </param>
        /// <param name="lastActionDateTime"> Date and time in UTC when the operation status was last updated. </param>
        /// <param name="createdDateTime"> Date and time in UTC when the operation was created. </param>
        internal DeviceOperation(OperationStatus status, DateTimeOffset lastActionDateTime, DateTimeOffset createdDateTime)
        {
            Status = status;
            LastActionDateTime = lastActionDateTime;
            CreatedDateTime = createdDateTime;
        }

        /// <summary> Initializes a new instance of DeviceOperation. </summary>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="error"> Operation error encountered, if any. </param>
        /// <param name="traceId"> Operation correlation identity that can used by Microsoft Support for troubleshooting. </param>
        /// <param name="lastActionDateTime"> Date and time in UTC when the operation status was last updated. </param>
        /// <param name="createdDateTime"> Date and time in UTC when the operation was created. </param>
        /// <param name="etag"> Operation ETag. </param>
        internal DeviceOperation(string operationId, OperationStatus status, ResponseError error, string traceId, DateTimeOffset lastActionDateTime, DateTimeOffset createdDateTime, string etag)
        {
            OperationId = operationId;
            Status = status;
            Error = error;
            TraceId = traceId;
            LastActionDateTime = lastActionDateTime;
            CreatedDateTime = createdDateTime;
            Etag = etag;
        }

        /// <summary> Operation Id. </summary>
        public string OperationId { get; }
        /// <summary> Operation status. </summary>
        public OperationStatus Status { get; }
        /// <summary> Operation error encountered, if any. </summary>
        public ResponseError Error { get; }
        /// <summary> Operation correlation identity that can used by Microsoft Support for troubleshooting. </summary>
        public string TraceId { get; }
        /// <summary> Date and time in UTC when the operation status was last updated. </summary>
        public DateTimeOffset LastActionDateTime { get; }
        /// <summary> Date and time in UTC when the operation was created. </summary>
        public DateTimeOffset CreatedDateTime { get; }
        /// <summary> Operation ETag. </summary>
        public string Etag { get; }
    }
}

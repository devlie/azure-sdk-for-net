// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate
{
    // Data plane generated client.
    /// <summary> The DeviceUpdate service client. </summary>
    public partial class DeviceUpdateClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="etag"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual Response GetOperationStatus(string operationId, ETag? etag, RequestContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="etag"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual Task<Response> GetOperationStatusAsync(string operationId, ETag? etag, RequestContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="waitUntil"></param>
        /// <param name="content"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual Operation StartImportUpdate(WaitUntil waitUntil, RequestContent content, RequestContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="waitUntil"></param>
        /// <param name="content"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual Task<Operation> StartImportUpdateAsync(WaitUntil waitUntil, RequestContent content, RequestContext context)
        {
            throw new NotImplementedException();
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using Azure.IoT.DeviceUpdate;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="DeviceUpdateClient"/>, <see cref="DeviceManagementClient"/>, <see cref="InstanceManagementClient"/> to client builder. </summary>
    public static partial class IoTDeviceUpdateClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="DeviceUpdateClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The Device Update for IoT Hub account endpoint (hostname only, no protocol). </param>
        /// <param name="instanceId"> The Device Update for IoT Hub account instance identifier. </param>
        public static IAzureClientBuilder<DeviceUpdateClient, AzureIoTDeviceUpdateClientOptions> AddDeviceUpdateClient<TBuilder>(this TBuilder builder, Uri endpoint, string instanceId)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<DeviceUpdateClient, AzureIoTDeviceUpdateClientOptions>((options, cred) => new DeviceUpdateClient(endpoint, instanceId, cred, options));
        }

        /// <summary> Registers a <see cref="DeviceManagementClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The Device Update for IoT Hub account endpoint (hostname only, no protocol). </param>
        /// <param name="instanceId"> The Device Update for IoT Hub account instance identifier. </param>
        public static IAzureClientBuilder<DeviceManagementClient, AzureIoTDeviceUpdateClientOptions> AddDeviceManagementClient<TBuilder>(this TBuilder builder, Uri endpoint, string instanceId)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<DeviceManagementClient, AzureIoTDeviceUpdateClientOptions>((options, cred) => new DeviceManagementClient(endpoint, instanceId, cred, options));
        }

        /// <summary> Registers a <see cref="InstanceManagementClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The Device Update for IoT Hub account endpoint (hostname only, no protocol). </param>
        /// <param name="instanceId"> The Device Update for IoT Hub account instance identifier. </param>
        public static IAzureClientBuilder<InstanceManagementClient, AzureIoTDeviceUpdateClientOptions> AddInstanceManagementClient<TBuilder>(this TBuilder builder, Uri endpoint, string instanceId)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<InstanceManagementClient, AzureIoTDeviceUpdateClientOptions>((options, cred) => new InstanceManagementClient(endpoint, instanceId, cred, options));
        }

        /// <summary> Registers a <see cref="DeviceUpdateClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<DeviceUpdateClient, AzureIoTDeviceUpdateClientOptions> AddDeviceUpdateClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<DeviceUpdateClient, AzureIoTDeviceUpdateClientOptions>(configuration);
        }
        /// <summary> Registers a <see cref="DeviceManagementClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<DeviceManagementClient, AzureIoTDeviceUpdateClientOptions> AddDeviceManagementClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<DeviceManagementClient, AzureIoTDeviceUpdateClientOptions>(configuration);
        }
        /// <summary> Registers a <see cref="InstanceManagementClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<InstanceManagementClient, AzureIoTDeviceUpdateClientOptions> AddInstanceManagementClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<InstanceManagementClient, AzureIoTDeviceUpdateClientOptions>(configuration);
        }
    }
}

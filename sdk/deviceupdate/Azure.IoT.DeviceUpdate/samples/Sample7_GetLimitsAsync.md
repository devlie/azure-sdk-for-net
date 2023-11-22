# Get updates

This sample demonstrates using `InstanceManagementClient` class in this library to retrieve service usage statistics and associated limits. To get started, you'll need Device Update for IoT Hub AccountId (hostname) and InstanceId which you can access in Azure Portal. See the [README](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/deviceupdate/Azure.IoT.DeviceUpdate/README.md) for links and instructions.

## Create an InstanceManagementClient

First, you need to instantiate a `InstanceManagementClient`. You use an endpoint URL, instance identity and a [`TokenCredential`](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/identity/Azure.Identity/README.md#credentials).

For the sample below, use proper `account-id` and `instance-id`. You can find the right value in Azure Portal.

```C# Snippet:AzDeviceUpdateSample7_CreateInstanceManagementClient
Uri endpoint = new Uri("https://<account-id>.api.adu.microsoft.com");
string instanceId = "<instance-id>";
TokenCredential credentials = new DefaultAzureCredential();
InstanceManagementClient client = new InstanceManagementClient(endpoint, instanceId, credentials);
```

## Get service usage statistics and associated limits

First, let's try to retrieve update metadata.

```C# Snippet:AzDeviceUpdateSample7_GetLimitsAsync
Response<Limits> response = client.GetLimitsAsync(cancellationToken);
Console.WriteLine("Limits:");
Console.WriteLine($"  DeviceCount - Usage: {response.Value.Counters.DeviceCount.Usage}, Quota: {response.Value.Counters.DeviceCount.Quota}";
Console.WriteLine($"  DeploymentCount - Usage: {response.Value.Counters.DeploymentCount.Usage}, Quota: {response.Value.Counters.DeploymentCount.Quota}";
```

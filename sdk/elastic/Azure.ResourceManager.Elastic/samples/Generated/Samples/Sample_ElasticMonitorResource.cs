// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Elastic.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Elastic.Samples
{
    public partial class Sample_ElasticMonitorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_MonitorsGet()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/Monitors_Get.json
            // this example is just showing the usage of "Monitors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            ElasticMonitorResource result = await elasticMonitor.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_MonitorsDelete()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/Monitors_Delete.json
            // this example is just showing the usage of "Monitors_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            await elasticMonitor.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_MonitorsUpdate()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/Monitors_Update.json
            // this example is just showing the usage of "Monitors_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            ElasticMonitorPatch patch = new ElasticMonitorPatch();
            ElasticMonitorResource result = await elasticMonitor.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetMonitoredResources_MonitoredResourcesList()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/MonitoredResources_List.json
            // this example is just showing the usage of "MonitoredResources_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation and iterate over the result
            await foreach (MonitoredResourceInfo item in elasticMonitor.GetMonitoredResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetDeploymentInfo_DeploymentInfoList()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/DeploymentInfo_List.json
            // this example is just showing the usage of "DeploymentInfo_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            ElasticDeploymentInfoResult result = await elasticMonitor.GetDeploymentInfoAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdateExternalUser_ExternalUserCreateOrUpdate()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/ExternalUserInfo.json
            // this example is just showing the usage of "ExternalUser_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            ElasticExternalUserCreationResult result = await elasticMonitor.CreateOrUpdateExternalUserAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetBillingInfo_BillingInfoGet()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/BillingInfo_Get.json
            // this example is just showing the usage of "BillingInfo_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            ElasticBillingInfoResult result = await elasticMonitor.GetBillingInfoAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetConnectedPartnerResources_ConnectedPartnerResourcesList()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/ConnectedPartnerResources_List.json
            // this example is just showing the usage of "ConnectedPartnerResources_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation and iterate over the result
            await foreach (ConnectedPartnerResourceInfo item in elasticMonitor.GetConnectedPartnerResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetVmHosts_VMHostList()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/VMHost_List.json
            // this example is just showing the usage of "VMHost_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation and iterate over the result
            await foreach (ElasticVmResourceInfo item in elasticMonitor.GetVmHostsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetVmIngestionDetails_VMIngestionDetails()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/VMIngestion_Details.json
            // this example is just showing the usage of "VMIngestion_Details" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            VmIngestionDetailsResult result = await elasticMonitor.GetVmIngestionDetailsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateVmCollection_VMCollectionUpdate()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/VMCollection_Update.json
            // this example is just showing the usage of "VMCollection_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            await elasticMonitor.UpdateVmCollectionAsync();

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetUpgradableVersionDetails_UpgradableVersionsDetails()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/UpgradableVersions_Details.json
            // this example is just showing the usage of "UpgradableVersions_Details" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            UpgradableVersionListResult result = await elasticMonitor.GetUpgradableVersionDetailsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpgradeMonitor_MonitorUpgrade()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/Monitor_Upgrade.json
            // this example is just showing the usage of "Monitor_Upgrade" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            await elasticMonitor.UpgradeMonitorAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAllTrafficFilter_AllTrafficFiltersList()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/AllTrafficFilters_list.json
            // this example is just showing the usage of "AllTrafficFilters_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            ElasticTrafficFilterListResult result = await elasticMonitor.GetAllTrafficFilterAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAssociatedTrafficFilters_ListAssociatedTrafficFiltersList()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/AssociatedFiltersForDeployment_list.json
            // this example is just showing the usage of "listAssociatedTrafficFilters_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            ElasticTrafficFilterListResult result = await elasticMonitor.GetAssociatedTrafficFiltersAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateAndAssociateIPFilter_CreateAndAssociateIPFilterCreate()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/IPTrafficFilter_Create.json
            // this example is just showing the usage of "createAndAssociateIPFilter_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            string ips = "192.168.131.0, 192.168.132.6/22";
            await elasticMonitor.CreateAndAssociateIPFilterAsync(WaitUntil.Completed, ips: ips);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateAndAssociatePrivateLinkFilter_CreateAndAssociatePLFilterCreate()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/PrivateLinkTrafficFilters_Create.json
            // this example is just showing the usage of "createAndAssociatePLFilter_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            string privateEndpointGuid = "fdb54d3b-e85e-4d08-8958-0d2f7g523df9";
            string privateEndpointName = "myPrivateEndpoint";
            await elasticMonitor.CreateAndAssociatePrivateLinkFilterAsync(WaitUntil.Completed, privateEndpointGuid: privateEndpointGuid, privateEndpointName: privateEndpointName);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task AssociateTrafficFilter_AssociateTrafficFilterAssociate()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/AssociateTrafficFilter_Update.json
            // this example is just showing the usage of "AssociateTrafficFilter_Associate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            string rulesetId = "31d91b5afb6f4c2eaaf104c97b1991dd";
            await elasticMonitor.AssociateTrafficFilterAsync(WaitUntil.Completed, rulesetId: rulesetId);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task DetachAndDeleteTrafficFilter_DetachAndDeleteTrafficFilterDelete()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/DetachAndDeleteTrafficFilter_Delete.json
            // this example is just showing the usage of "DetachAndDeleteTrafficFilter_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            string rulesetId = "31d91b5afb6f4c2eaaf104c97b1991dd";
            await elasticMonitor.DetachAndDeleteTrafficFilterAsync(rulesetId: rulesetId);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task DetachTrafficFilter_DetachTrafficFilterUpdate()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/DetachTrafficFilters_Update.json
            // this example is just showing the usage of "DetachTrafficFilter_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            string rulesetId = "31d91b5afb6f4c2eaaf104c97b1991dd";
            await elasticMonitor.DetachTrafficFilterAsync(WaitUntil.Completed, rulesetId: rulesetId);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task DeleteTrafficFilter_TrafficFiltersDelete()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/stable/2024-03-01/examples/TrafficFilters_Delete.json
            // this example is just showing the usage of "TrafficFilters_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticMonitorResource created on azure
            // for more information of creating ElasticMonitorResource, please refer to the document of ElasticMonitorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            ResourceIdentifier elasticMonitorResourceId = ElasticMonitorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName);
            ElasticMonitorResource elasticMonitor = client.GetElasticMonitorResource(elasticMonitorResourceId);

            // invoke the operation
            string rulesetId = "31d91b5afb6f4c2eaaf104c97b1991dd";
            await elasticMonitor.DeleteTrafficFilterAsync(rulesetId: rulesetId);

            Console.WriteLine("Succeeded");
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#region Snippet:Readme_Namespaces
using System;
using System.Linq;
using Azure.ResourceManager;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Containers;
using Azure.ResourceManager.HDInsight.Containers.Models;
#endregion Snippet:Readme_Namespaces
using NUnit.Framework;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Tests.Samples
{
    public class Readme
    {
        [Test]
        [Ignore("Only verifying that the sample builds")]
        public void ClientAuth()
        {
            #region Snippet:Readme_AuthClient
            ArmClient armClient = new ArmClient(new DefaultAzureCredential());
            SubscriptionResource subscription = armClient.GetDefaultSubscription();
            #endregion Snippet:Readme_AuthClient
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public void CreateClusterPool()
        {
            var credential = new DefaultAzureCredential();
            var armClient = new ArmClient(credential);
            #region Snippet:Readme_CreateClusterPool
            // define the prerequisites information: subscription, resource group and location where you want to create the resource
            string subscriptionResourceId = "/subscriptions/{subscription id}"; // your subscription resource id like /subscriptions/{subscription id}
            string resourceGroupName = "{your resource group name}"; // your resource group name
            AzureLocation location = AzureLocation.EastUS; // your location

            SubscriptionResource subscription = armClient.GetSubscriptionResource(new ResourceIdentifier(resourceId: subscriptionResourceId));
            ResourceGroupResource resourceGroupResource = subscription.GetResourceGroup(resourceGroupName);
            HDInsightClusterPoolCollection clusterPoolCollection = resourceGroupResource.GetHDInsightClusterPools();

            // create the cluster pool
            string clusterPoolName = "{your cluster pool name}";
            string clusterPoolVmSize = "Standard_E4s_v3"; // the vmsize

            // get the available cluster pool version
            var availableClusterPoolVersion = subscription.GetAvailableClusterPoolVersionsByLocation(location).FirstOrDefault();

            // initialize the ClusterPoolData instance
            HDInsightClusterPoolData clusterPoolData = new HDInsightClusterPoolData(location)
            {
                Properties = new HDInsightClusterPoolProperties(new ClusterPoolComputeProfile(clusterPoolVmSize))
                {
                    ClusterPoolVersion = availableClusterPoolVersion?.Properties.ClusterPoolVersion
                }
            };

            var clusterPoolResult = clusterPoolCollection.CreateOrUpdate(Azure.WaitUntil.Completed, clusterPoolName, clusterPoolData);
            #endregion Snippet:Readme_CreateClusterPool
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public void CreateSimpleTrinoCluster()
        {
            // Authenticate the client
            var credential = new AzurePowerShellCredential();
            var armClient = new ArmClient(credential);
            #region Snippet:Readme_CreateSimpleTrinoCluster
            // define the prerequisites information: subscription, resource group and location where you want to create the resource
            string subscriptionResourceId = "/subscriptions/{subscription id}"; // your subscription resource id like /subscriptions/{subscription id}
            string resourceGroupName = "{your resource group}"; // your resource group name
            AzureLocation location = AzureLocation.EastUS; // your location

            SubscriptionResource subscription = armClient.GetSubscriptionResource(new ResourceIdentifier(resourceId: subscriptionResourceId));
            ResourceGroupResource resourceGroupResource = subscription.GetResourceGroup(resourceGroupName);
            HDInsightClusterPoolCollection clusterPoolCollection = resourceGroupResource.GetHDInsightClusterPools();

            // create the cluster
            string clusterPoolName = "{your cluster pool name}";
            string clusterName = "{your cluster name}";
            string clusterType = "Trino"; // your cluster type

            // get the available cluster version
            var availableClusterVersion = subscription.GetAvailableClusterVersionsByLocation(location).Where(version => version.Properties.ClusterType.Equals(clusterType, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            // set the identity profile
            string msiResourceId = "{your user msi resource id}";
            string msiClientId = "{your user msi client id}";
            string msiObjectId = "{your user msi object id}";
            var identityProfile = new HDInsightIdentityProfile(msiResourceId: new ResourceIdentifier(msiResourceId), msiClientId: msiClientId, msiObjectId: msiObjectId);

            // set the authorization profile
            var userId = "{your aad user id}";
            var authorizationProfile = new AuthorizationProfile();
            authorizationProfile.UserIds.Add(userId);

            // set the cluster node profile
            string vmSize = "Standard_D8s_v3"; // your vms ize
            int workerCount = 5;
            ClusterComputeProfile nodeProfile = new ClusterComputeProfile(new List<ClusterComputeNodeProfile> { new ClusterComputeNodeProfile(nodeProfileType: "worker", vmSize: vmSize, count: workerCount) });
            ClusterProfile clusterProfile = new ClusterProfile(availableClusterVersion.Properties.ClusterVersion, availableClusterVersion.Properties.OssVersion, authorizationProfile)
            {
                IdentityList = new List<HDInsightManagedIdentitySpec> { new HDInsightManagedIdentitySpec("cluster",new ResourceIdentifier(msiResourceId), msiClientId, msiObjectId) }
            };

            var clusterData = new HDInsightClusterData(location)
            {
                Properties = new HDInsightClusterProperties(clusterType, nodeProfile, clusterProfile)
            };

            var clusterCollection = clusterPoolCollection.Get(clusterPoolName).Value.GetHDInsightClusters();

            var clusterResult = clusterCollection.CreateOrUpdate(Azure.WaitUntil.Completed, clusterName, clusterData);
            #endregion Snippet:Readme_CreateSimpleTrinoCluster
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public void CreateSimpleSparkCluster()
        {
            // Authenticate the client
            var credential = new AzurePowerShellCredential();
            var armClient = new ArmClient(credential);
            #region Snippet:Readme_CreateSimpleSparkCluster
            // define the prerequisites information: subscription, resource group and location where you want to create the resource
            string subscriptionResourceId = "/subscriptions/{subscription id}"; // your subscription resource id like /subscriptions/{subscription id}
            string resourceGroupName = "{your resource group}"; // your resource group name
            AzureLocation location = AzureLocation.EastUS; // your location

            SubscriptionResource subscription = armClient.GetSubscriptionResource(new ResourceIdentifier(resourceId: subscriptionResourceId));
            ResourceGroupResource resourceGroupResource = subscription.GetResourceGroup(resourceGroupName);
            HDInsightClusterPoolCollection clusterPoolCollection = resourceGroupResource.GetHDInsightClusterPools();

            // create the cluster
            string clusterPoolName = "{your cluster pool name}";
            string clusterName = "{your cluster name}";
            string clusterType = "Spark"; // your cluster type here is Spark

            // get the available cluster version
            var availableClusterVersion = subscription.GetAvailableClusterVersionsByLocation(location).Where(version => version.Properties.ClusterType.Equals(clusterType, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            // set the identity profile
            string msiResourceId = "{your user msi resource id}";
            string msiClientId = "{your user msi client id}";
            string msiObjectId = "{your user msi object id}";
            var identityProfile = new HDInsightIdentityProfile(msiResourceId: new ResourceIdentifier(msiResourceId), msiClientId: msiClientId, msiObjectId: msiObjectId);

            // set the authorization profile
            var userId = "{your aad user id}";
            var authorizationProfile = new AuthorizationProfile();
            authorizationProfile.UserIds.Add(userId);

            // set the cluster node profile
            string vmSize = "Standard_D8s_v3"; // your vms ize
            int workerCount = 5;
            ClusterComputeProfile nodeProfile = new ClusterComputeProfile(new List<ClusterComputeNodeProfile> { new ClusterComputeNodeProfile(nodeProfileType: "worker", vmSize: vmSize, count: workerCount) });
            ClusterProfile clusterProfile = new ClusterProfile(availableClusterVersion.Properties.ClusterVersion, availableClusterVersion.Properties.OssVersion, authorizationProfile)
            {
                IdentityList = new List<HDInsightManagedIdentitySpec> { new HDInsightManagedIdentitySpec("cluster",new ResourceIdentifier(msiResourceId), msiClientId, msiObjectId) }
            };

            var clusterData = new HDInsightClusterData(location)
            {
                Properties = new HDInsightClusterProperties(clusterType, nodeProfile, clusterProfile)
            };

            // set saprk profile
            clusterProfile.SparkProfile = new SparkProfile()
            {
                DefaultStorageUriString = "abfs://spark@hilostorage.dfs.core.windows.net",
            };

            var clusterCollection = clusterPoolCollection.Get(clusterPoolName).Value.GetHDInsightClusters();

            var clusterResult = clusterCollection.CreateOrUpdate(Azure.WaitUntil.Completed, clusterName, clusterData);
            #endregion Snippet:Readme_CreateSimpleSparkCluster
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public void CreateSimpleFlinkCluster()
        {
            // Authenticate the client
            var credential = new AzurePowerShellCredential();
            var armClient = new ArmClient(credential);
            #region Snippet:Readme_CreateSimpleFlinkCluster
            // define the prerequisites information: subscription, resource group and location where you want to create the resource
            string subscriptionResourceId = "/subscriptions/{subscription id}"; // your subscription resource id like /subscriptions/{subscription id}
            string resourceGroupName = "{your resource group}"; // your resource group name
            AzureLocation location = AzureLocation.EastUS; // your location

            SubscriptionResource subscription = armClient.GetSubscriptionResource(new ResourceIdentifier(resourceId: subscriptionResourceId));
            ResourceGroupResource resourceGroupResource = subscription.GetResourceGroup(resourceGroupName);
            HDInsightClusterPoolCollection clusterPoolCollection = resourceGroupResource.GetHDInsightClusterPools();

            // create the cluster
            string clusterPoolName = "{your cluster pool name}";
            string clusterName = "{your cluster name}";
            string clusterType = "Flink"; // cluster type

            // get the available cluster version
            var availableClusterVersion = subscription.GetAvailableClusterVersionsByLocation(location).Where(version => version.Properties.ClusterType.Equals(clusterType, StringComparison.OrdinalIgnoreCase)).LastOrDefault();

            // set the identity profile
            string msiResourceId = "{your user msi resource id}";
            string msiClientId = "{your user msi client id}";
            string msiObjectId = "{your user msi object id}";
            var identityProfile = new HDInsightIdentityProfile(msiResourceId: new ResourceIdentifier(msiResourceId), msiClientId: msiClientId, msiObjectId: msiObjectId);

            // set the authorization profile
            var userId = "{your aad user id}";
            var authorizationProfile = new AuthorizationProfile();
            authorizationProfile.UserIds.Add(userId);

            // set the cluster node profile
            string vmSize = "Standard_D8s_v3"; // your vm size
            int workerCount = 5;
            ClusterComputeProfile nodeProfile = new ClusterComputeProfile(new List<ClusterComputeNodeProfile> { new ClusterComputeNodeProfile(nodeProfileType: "worker", vmSize: vmSize, count: workerCount) });
            ClusterProfile clusterProfile = new ClusterProfile(availableClusterVersion.Properties.ClusterVersion, availableClusterVersion.Properties.OssVersion, authorizationProfile)
            {
                IdentityList = new List<HDInsightManagedIdentitySpec> { new HDInsightManagedIdentitySpec("cluster",new ResourceIdentifier(msiResourceId), msiClientId, msiObjectId) }
            };

            var clusterData = new HDInsightClusterData(location)
            {
                Properties = new HDInsightClusterProperties(clusterType, nodeProfile, clusterProfile)
            };

            // set flink profile
            string storageUri = "abfs://{your storage account container name}@{yoru storage account}.dfs.core.windows.net"; // your adlsgen2 storage uri
            FlinkStorageProfile flinkStorageProfile = new FlinkStorageProfile(storageUri);

            ComputeResourceRequirement jobManager = new ComputeResourceRequirement((float)1.0, 2048);
            ComputeResourceRequirement taskManager = new ComputeResourceRequirement((float)1.0, 2048);

            clusterData.Properties.ClusterProfile.FlinkProfile = new FlinkProfile(flinkStorageProfile, jobManager, taskManager);

            var clusterCollection = clusterPoolCollection.Get(clusterPoolName).Value.GetHDInsightClusters();

            var clusterResult = clusterCollection.CreateOrUpdate(Azure.WaitUntil.Completed, clusterName, clusterData);
            #endregion Snippet:Readme_CreateSimpleFlinkCluster
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public void CreateTrinoClusterHms()
        {
            // Authenticate the client
            var credential = new AzurePowerShellCredential();
            var armClient = new ArmClient(credential);
            #region Snippet:Readme_CreateTrinoClusterHms
            // define the prerequisites information: subscription, resource group and location where you want to create the resource
            string subscriptionResourceId = "/subscriptions/{subscription id}"; // your subscription resource id like /subscriptions/{subscription id}
            string resourceGroupName = "{your resource group}"; // your resource group name
            AzureLocation location = AzureLocation.EastUS; // your location

            SubscriptionResource subscription = armClient.GetSubscriptionResource(new ResourceIdentifier(resourceId: subscriptionResourceId));
            ResourceGroupResource resourceGroupResource = subscription.GetResourceGroup(resourceGroupName);
            HDInsightClusterPoolCollection clusterPoolCollection = resourceGroupResource.GetHDInsightClusterPools();

            // create the cluster
            string clusterPoolName = "{your cluster pool name}";
            string clusterName = "{your cluster name}";
            string clusterType = "Trino"; // your cluster type

            // get the available cluster version
            var availableClusterVersion = subscription.GetAvailableClusterVersionsByLocation(location).Where(version => version.Properties.ClusterType.Equals(clusterType, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            // set the identity profile
            string msiResourceId = "{your user msi resource id}";
            string msiClientId = "{your user msi client id}";
            string msiObjectId = "{your user msi object id}";
            var identityProfile = new HDInsightIdentityProfile(msiResourceId: new ResourceIdentifier(msiResourceId), msiClientId: msiClientId, msiObjectId: msiObjectId);

            // set the authorization profile
            var userId = "{your aad user id}";
            var authorizationProfile = new AuthorizationProfile();
            authorizationProfile.UserIds.Add(userId);

            // set the cluster node profile
            string vmSize = "Standard_D8s_v3"; // your vms ize
            int workerCount = 5;
            ClusterComputeProfile nodeProfile = new ClusterComputeProfile(new List<ClusterComputeNodeProfile> { new ClusterComputeNodeProfile(nodeProfileType: "worker", vmSize: vmSize, count: workerCount) });
            ClusterProfile clusterProfile = new ClusterProfile(availableClusterVersion.Properties.ClusterVersion, availableClusterVersion.Properties.OssVersion, authorizationProfile)
            {
                IdentityList = new List<HDInsightManagedIdentitySpec> { new HDInsightManagedIdentitySpec("cluster",new ResourceIdentifier(msiResourceId), msiClientId, msiObjectId) }
            };

            var clusterData = new HDInsightClusterData(location)
            {
                Properties = new HDInsightClusterProperties(clusterType, nodeProfile, clusterProfile)
            };

            // set secret profile
            string kvResourceId = "{your key vault resource id}";
            string secretName = "{your secret reference name}";
            string keyVaultObjectName = "{your key vault secret name}";

            var secretReference = new ClusterSecretReference(referenceName: secretName, KeyVaultObjectType.Secret, keyVaultObjectName: keyVaultObjectName);
            clusterData.Properties.ClusterProfile.SecretsProfile = new ClusterSecretsProfile(new ResourceIdentifier(kvResourceId));
            clusterData.Properties.ClusterProfile.SecretsProfile.Secrets.Add(secretReference);

            // set trino profile
            string metastoreDbConnectionUriString = "jdbc:sqlserver://{your sql server name}.database.windows.net;database={your database name};encrypt=true;trustServerCertificate=true;loginTimeout=30;";
            string metastoreDbUserName = "{your db user name}";
            string metastoreDbPasswordSecret = secretName;
            string metastoreWarehouseDir = "abfs://{your adlsgen2 storage account container}@{your adlsgen2 storage account}.dfs.core.windows.net/{sub folder path}";

            // set trino profile
            clusterProfile.TrinoProfile = new TrinoProfile();

            // initialize the ClusterServiceConfigsProfile for HMS
            ClusterServiceConfigsProfile clusterServiceConfigsProfile = new ClusterServiceConfigsProfile(serviceName: "trino", new ClusterServiceConfig[] {
                new ClusterServiceConfig(component: "common", new ClusterConfigFile[] { new ClusterConfigFile("config.properties")
                    {
                        Values = {
                                ["hive.metastore.hdi.metastoreDbConnectionAuthenticationMode"] = "SqlAuth",
                                ["hive.metastore.hdi.metastoreDbConnectionPasswordSecret"] = metastoreDbPasswordSecret,
                                ["hive.metastore.hdi.metastoreDbConnectionURL"] = metastoreDbConnectionUriString,
                                ["hive.metastore.hdi.metastoreDbConnectionUserName"] = metastoreDbUserName,
                                ["hive.metastore.hdi.metastoreWarehouseDir"] = metastoreWarehouseDir
                        }
                    }
                })
            });
            clusterProfile.ServiceConfigsProfiles.Add(clusterServiceConfigsProfile);

            ClusterSecretsProfile clusterSecretsProfile = new ClusterSecretsProfile(new ResourceIdentifier(kvResourceId));
            clusterSecretsProfile.Secrets.Add(new ClusterSecretReference(secretName, KeyVaultObjectType.Secret, keyVaultObjectName));
            clusterProfile.SecretsProfile = clusterSecretsProfile;

            var clusterCollection = clusterPoolCollection.Get(clusterPoolName).Value.GetHDInsightClusters();

            var clusterResult = clusterCollection.CreateOrUpdate(Azure.WaitUntil.Completed, clusterName, clusterData);
            #endregion Snippet:Readme_CreateTrinoClusterHms
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public void CreateSparkClusterHms()
        {
            // Authenticate the client
            var credential = new AzurePowerShellCredential();
            var armClient = new ArmClient(credential);
            #region Snippet:Readme_CreateSparkClusterHms
            // define the prerequisites information: subscription, resource group and location where you want to create the resource
            string subscriptionResourceId = "/subscriptions/{subscription id}"; // your subscription resource id like /subscriptions/{subscription id}
            string resourceGroupName = "{your resource group}"; // your resource group name
            AzureLocation location = AzureLocation.EastUS; // your location

            SubscriptionResource subscription = armClient.GetSubscriptionResource(new ResourceIdentifier(resourceId: subscriptionResourceId));
            ResourceGroupResource resourceGroupResource = subscription.GetResourceGroup(resourceGroupName);
            HDInsightClusterPoolCollection clusterPoolCollection = resourceGroupResource.GetHDInsightClusterPools();

            // create the cluster
            string clusterPoolName = "{your cluster pool name}";
            string clusterName = "{your cluster name}";
            string clusterType = "Spark"; // your cluster type here is Spark

            // get the available cluster version
            var availableClusterVersion = subscription.GetAvailableClusterVersionsByLocation(location).Where(version => version.Properties.ClusterType.Equals(clusterType, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            // set the identity profile
            string msiResourceId = "{your user msi resource id}";
            string msiClientId = "{your user msi client id}";
            string msiObjectId = "{your user msi object id}";
            var identityProfile = new HDInsightIdentityProfile(msiResourceId: new ResourceIdentifier(msiResourceId), msiClientId: msiClientId, msiObjectId: msiObjectId);

            // set the authorization profile
            var userId = "{your aad user id}";
            var authorizationProfile = new AuthorizationProfile();
            authorizationProfile.UserIds.Add(userId);

            // set the cluster node profile
            string vmSize = "Standard_D8s_v3"; // your vms ize
            int workerCount = 5;
            ClusterComputeProfile nodeProfile = new ClusterComputeProfile(new List<ClusterComputeNodeProfile> { new ClusterComputeNodeProfile(nodeProfileType: "worker", vmSize: vmSize, count: workerCount) });
            ClusterProfile clusterProfile = new ClusterProfile(availableClusterVersion.Properties.ClusterVersion, availableClusterVersion.Properties.OssVersion, authorizationProfile)
            {
                IdentityList = new List<HDInsightManagedIdentitySpec> { new HDInsightManagedIdentitySpec("cluster",new ResourceIdentifier(msiResourceId), msiClientId, msiObjectId) }
            };

            var clusterData = new HDInsightClusterData(location)
            {
                Properties = new HDInsightClusterProperties(clusterType, nodeProfile, clusterProfile)
            };

            // set secret profile
            string kvResourceId = "{your key vault resource id}";
            string secretName = "{your secret reference name}";
            string keyVaultObjectName = "{your key vault secret name}";

            var secretReference = new ClusterSecretReference(referenceName: secretName, KeyVaultObjectType.Secret, keyVaultObjectName: keyVaultObjectName);
            clusterData.Properties.ClusterProfile.SecretsProfile = new ClusterSecretsProfile(new ResourceIdentifier(kvResourceId));
            clusterData.Properties.ClusterProfile.SecretsProfile.Secrets.Add(secretReference);

            // set spark profile
            string defaultStorageUriString = "abfs://{your adlsgen2 storage account container}@{your adlsgen2 storage account}.dfs.core.windows.net/";
            string dbServerHost = "{your sql server name}.database.windows.net";
            string dbUserName = "{your db user name}";
            string dbName = "{yoru db name}";
            string dbPasswordSecretName = secretName;

            SparkMetastoreSpec sparkMetastoreSpec = new SparkMetastoreSpec(dbServerHost: dbServerHost, dbName: dbName);
            sparkMetastoreSpec.DBUserName = dbUserName;
            sparkMetastoreSpec.DBPasswordSecretName = dbPasswordSecretName;
            sparkMetastoreSpec.KeyVaultId = kvResourceId;

            SparkProfile sparkProfile = new SparkProfile();
            sparkProfile.DefaultStorageUriString = defaultStorageUriString;
            sparkProfile.MetastoreSpec = sparkMetastoreSpec;

            clusterData.Properties.ClusterProfile.SparkProfile = sparkProfile;

            var clusterCollection = clusterPoolCollection.Get(clusterPoolName).Value.GetHDInsightClusters();

            var clusterResult = clusterCollection.CreateOrUpdate(Azure.WaitUntil.Completed, clusterName, clusterData);
            #endregion Snippet:Readme_CreateSparkClusterHms
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public void CreateFlinkClusterHms()
        {
            // Authenticate the client
            var credential = new AzurePowerShellCredential();
            var armClient = new ArmClient(credential);
            #region Snippet:Readme_CreateFlinkClusterHms
            // define the prerequisites information: subscription, resource group and location where you want to create the resource
            string subscriptionResourceId = "/subscriptions/{subscription id}"; // your subscription resource id like /subscriptions/{subscription id}
            string resourceGroupName = "{your resource group}"; // your resource group name
            AzureLocation location = AzureLocation.EastUS; // your location

            SubscriptionResource subscription = armClient.GetSubscriptionResource(new ResourceIdentifier(resourceId: subscriptionResourceId));
            ResourceGroupResource resourceGroupResource = subscription.GetResourceGroup(resourceGroupName);
            HDInsightClusterPoolCollection clusterPoolCollection = resourceGroupResource.GetHDInsightClusterPools();

            // create the cluster
            string clusterPoolName = "{your cluster pool name}";
            string clusterName = "{your cluster name}";
            string clusterType = "Flink"; // cluster type

            // get the available cluster version
            var availableClusterVersion = subscription.GetAvailableClusterVersionsByLocation(location).Where(version => version.Properties.ClusterType.Equals(clusterType, StringComparison.OrdinalIgnoreCase)).LastOrDefault();

            // set the identity profile
            string msiResourceId = "{your user msi resource id}";
            string msiClientId = "{your user msi client id}";
            string msiObjectId = "{your user msi object id}";
            var identityProfile = new HDInsightIdentityProfile(msiResourceId: new ResourceIdentifier(msiResourceId), msiClientId: msiClientId, msiObjectId: msiObjectId);

            // set the authorization profile
            var userId = "{your aad user id}";
            var authorizationProfile = new AuthorizationProfile();
            authorizationProfile.UserIds.Add(userId);

            // set the cluster node profile
            string vmSize = "Standard_D8s_v3"; // your vm size
            int workerCount = 5;
            ClusterComputeProfile nodeProfile = new ClusterComputeProfile(new List<ClusterComputeNodeProfile> { new ClusterComputeNodeProfile(nodeProfileType: "worker", vmSize: vmSize, count: workerCount) });
            ClusterProfile clusterProfile = new ClusterProfile(availableClusterVersion.Properties.ClusterVersion, availableClusterVersion.Properties.OssVersion, authorizationProfile)
            {
                IdentityList = new List<HDInsightManagedIdentitySpec> { new HDInsightManagedIdentitySpec("cluster",new ResourceIdentifier(msiResourceId), msiClientId, msiObjectId) }
            };

            var clusterData = new HDInsightClusterData(location)
            {
                Properties = new HDInsightClusterProperties(clusterType, nodeProfile, clusterProfile)
            };

            // set secret profile
            string kvResourceId = "{your key vault resource id}";
            string secretName = "{your secret reference name}";
            string keyVaultObjectName = "{your key vault secret name}";

            var secretReference = new ClusterSecretReference(referenceName: secretName, KeyVaultObjectType.Secret, keyVaultObjectName: keyVaultObjectName);
            clusterData.Properties.ClusterProfile.SecretsProfile = new ClusterSecretsProfile(new ResourceIdentifier(kvResourceId));
            clusterData.Properties.ClusterProfile.SecretsProfile.Secrets.Add(secretReference);

            // set flink profile

            string storageUri = "abfs://{your adlsgen2 storage account container}@{your adlsgen2 storage account}.dfs.core.windows.net";
            FlinkStorageProfile flinkStorageProfile = new FlinkStorageProfile(storageUri);

            ComputeResourceRequirement jobManager = new ComputeResourceRequirement((float)1.0, 2048);
            ComputeResourceRequirement taskManager = new ComputeResourceRequirement((float)1.0, 2048);

            // set flink catalog
            string metastoreDbConnectionUriString = "jdbc:sqlserver://{your sql server name}.database.windows.net;database={your database name};encrypt=true;trustServerCertificate=true;loginTimeout=30;";
            string metastoreDbUserName = "{your db user name}";
            string metastoreDbPasswordSecret = secretName;

            FlinkHiveCatalogOption flinkHiveCatalogOption = new FlinkHiveCatalogOption(metastoreDBConnectionUriString: metastoreDbConnectionUriString);
            flinkHiveCatalogOption.MetastoreDBConnectionUserName = metastoreDbUserName;
            flinkHiveCatalogOption.MetastoreDBConnectionPasswordSecret = metastoreDbPasswordSecret;

            clusterData.Properties.ClusterProfile.FlinkProfile = new FlinkProfile(storage: flinkStorageProfile, jobManager: jobManager, taskManager: taskManager);
            clusterData.Properties.ClusterProfile.FlinkProfile.CatalogOptionsHive = flinkHiveCatalogOption;

            var clusterCollection = clusterPoolCollection.Get(clusterPoolName).Value.GetHDInsightClusters();
            var clusterResult = clusterCollection.CreateOrUpdate(Azure.WaitUntil.Completed, clusterName, clusterData);
            #endregion Snippet:Readme_CreateFlinkClusterHms
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public void CreateTrinoClusterAvailabilityZone()
        {
            // Authenticate the client
            var credential = new AzurePowerShellCredential();
            var armClient = new ArmClient(credential);
            #region Snippet:Readme_CreateTrinoClusterAvailabilityZone
            // define the prerequisites information: subscription, resource group and location where you want to create the resource
            string subscriptionResourceId = "/subscriptions/{subscription id}"; // your subscription resource id like /subscriptions/{subscription id}
            string resourceGroupName = "{your resource group}"; // your resource group name
            AzureLocation location = AzureLocation.EastUS; // your location

            SubscriptionResource subscription = armClient.GetSubscriptionResource(new ResourceIdentifier(resourceId: subscriptionResourceId));
            ResourceGroupResource resourceGroupResource = subscription.GetResourceGroup(resourceGroupName);
            HDInsightClusterPoolCollection clusterPoolCollection = resourceGroupResource.GetHDInsightClusterPools();

            // create the cluster
            string clusterPoolName = "{your cluster pool name}";
            string clusterName = "{your cluster name}";
            string clusterType = "Trino"; // your cluster type

            // get the available cluster version
            var availableClusterVersion = subscription.GetAvailableClusterVersionsByLocation(location).Where(version => version.Properties.ClusterType.Equals(clusterType, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            // set the identity profile
            string msiResourceId = "{your user msi resource id}";
            string msiClientId = "{your user msi client id}";
            string msiObjectId = "{your user msi object id}";
            var identityProfile = new HDInsightIdentityProfile(msiResourceId: new ResourceIdentifier(msiResourceId), msiClientId: msiClientId, msiObjectId: msiObjectId);

            // set the authorization profile
            var userId = "{your aad user id}";
            var authorizationProfile = new AuthorizationProfile();
            authorizationProfile.UserIds.Add(userId);

            // set the cluster node profile
            string vmSize = "Standard_D8s_v3"; // your vms ize
            int workerCount = 5;
            ClusterComputeProfile nodeProfile = new ClusterComputeProfile(new List<ClusterComputeNodeProfile> { new ClusterComputeNodeProfile(nodeProfileType: "worker", vmSize: vmSize, count: workerCount) });
            // set availability zones
            nodeProfile.AvailabilityZones.Add("1");
            nodeProfile.AvailabilityZones.Add("2");

            ClusterProfile clusterProfile = new ClusterProfile(availableClusterVersion.Properties.ClusterVersion, availableClusterVersion.Properties.OssVersion, authorizationProfile)
            {
                IdentityList = new List<HDInsightManagedIdentitySpec> { new HDInsightManagedIdentitySpec("cluster",new ResourceIdentifier(msiResourceId), msiClientId, msiObjectId) }
            };

            var clusterData = new HDInsightClusterData(location)
            {
                Properties = new HDInsightClusterProperties(clusterType, nodeProfile, clusterProfile)
            };

            var clusterCollection = clusterPoolCollection.Get(clusterPoolName).Value.GetHDInsightClusters();

            var clusterResult = clusterCollection.CreateOrUpdate(Azure.WaitUntil.Completed, clusterName, clusterData);
            #endregion Snippet:Readme_CreateTrinoClusterAvailabilityZone
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm provider specific input to update appliance for replication protected item. </summary>
    public partial class InMageRcmUpdateApplianceForReplicationProtectedItemInput : UpdateApplianceForReplicationProtectedItemProviderSpecificInput
    {
        /// <summary> Initializes a new instance of InMageRcmUpdateApplianceForReplicationProtectedItemInput. </summary>
        public InMageRcmUpdateApplianceForReplicationProtectedItemInput()
        {
            InstanceType = "InMageRcm";
        }

        /// <summary> The run as account Id. </summary>
        public string RunAsAccountId { get; set; }
    }
}

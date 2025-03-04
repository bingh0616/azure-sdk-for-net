// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ExpressRouteLink data model. </summary>
    public partial class ExpressRouteLinkData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of ExpressRouteLinkData. </summary>
        public ExpressRouteLinkData()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteLinkData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="routerName"> Name of Azure router associated with physical port. </param>
        /// <param name="interfaceName"> Name of Azure router interface. </param>
        /// <param name="patchPanelId"> Mapping between physical port to patch panel port. </param>
        /// <param name="rackId"> Mapping of physical patch panel to rack. </param>
        /// <param name="connectorType"> Physical fiber port type. </param>
        /// <param name="adminState"> Administrative state of the physical port. </param>
        /// <param name="provisioningState"> The provisioning state of the express route link resource. </param>
        /// <param name="macSecConfig"> MacSec configuration. </param>
        internal ExpressRouteLinkData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, string routerName, string interfaceName, string patchPanelId, string rackId, ExpressRouteLinkConnectorType? connectorType, ExpressRouteLinkAdminState? adminState, NetworkProvisioningState? provisioningState, ExpressRouteLinkMacSecConfig macSecConfig) : base(id, name, resourceType)
        {
            ETag = etag;
            RouterName = routerName;
            InterfaceName = interfaceName;
            PatchPanelId = patchPanelId;
            RackId = rackId;
            ConnectorType = connectorType;
            AdminState = adminState;
            ProvisioningState = provisioningState;
            MacSecConfig = macSecConfig;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Name of Azure router associated with physical port. </summary>
        public string RouterName { get; }
        /// <summary> Name of Azure router interface. </summary>
        public string InterfaceName { get; }
        /// <summary> Mapping between physical port to patch panel port. </summary>
        public string PatchPanelId { get; }
        /// <summary> Mapping of physical patch panel to rack. </summary>
        public string RackId { get; }
        /// <summary> Physical fiber port type. </summary>
        public ExpressRouteLinkConnectorType? ConnectorType { get; }
        /// <summary> Administrative state of the physical port. </summary>
        public ExpressRouteLinkAdminState? AdminState { get; set; }
        /// <summary> The provisioning state of the express route link resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> MacSec configuration. </summary>
        public ExpressRouteLinkMacSecConfig MacSecConfig { get; set; }
    }
}

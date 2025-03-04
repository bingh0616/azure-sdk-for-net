// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Represents product details. </summary>
    public partial class ProductDetails
    {
        /// <summary> Initializes a new instance of ProductDetails. </summary>
        /// <param name="hierarchyInformation"> Hierarchy of the product which uniquely identifies the product. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hierarchyInformation"/> is null. </exception>
        public ProductDetails(HierarchyInformation hierarchyInformation)
        {
            if (hierarchyInformation == null)
            {
                throw new ArgumentNullException(nameof(hierarchyInformation));
            }

            HierarchyInformation = hierarchyInformation;
            DeviceDetails = new ChangeTrackingList<EdgeOrderProductDeviceDetails>();
        }

        /// <summary> Initializes a new instance of ProductDetails. </summary>
        /// <param name="displayInfo"> Display details of the product. </param>
        /// <param name="hierarchyInformation"> Hierarchy of the product which uniquely identifies the product. </param>
        /// <param name="count"> Quantity of the product. </param>
        /// <param name="productDoubleEncryptionStatus"> Double encryption status of the configuration. Read-only field. </param>
        /// <param name="deviceDetails"> list of device details. </param>
        internal ProductDetails(ProductDisplayInfo displayInfo, HierarchyInformation hierarchyInformation, int? count, DoubleEncryptionStatus? productDoubleEncryptionStatus, IReadOnlyList<EdgeOrderProductDeviceDetails> deviceDetails)
        {
            DisplayInfo = displayInfo;
            HierarchyInformation = hierarchyInformation;
            Count = count;
            ProductDoubleEncryptionStatus = productDoubleEncryptionStatus;
            DeviceDetails = deviceDetails;
        }

        /// <summary> Display details of the product. </summary>
        public ProductDisplayInfo DisplayInfo { get; set; }
        /// <summary> Hierarchy of the product which uniquely identifies the product. </summary>
        public HierarchyInformation HierarchyInformation { get; set; }
        /// <summary> Quantity of the product. </summary>
        public int? Count { get; }
        /// <summary> Double encryption status of the configuration. Read-only field. </summary>
        public DoubleEncryptionStatus? ProductDoubleEncryptionStatus { get; }
        /// <summary> list of device details. </summary>
        public IReadOnlyList<EdgeOrderProductDeviceDetails> DeviceDetails { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataLakeAnalytics;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary> Azure Storage account list information. </summary>
    internal partial class StorageAccountInformationListResult
    {
        /// <summary> Initializes a new instance of StorageAccountInformationListResult. </summary>
        internal StorageAccountInformationListResult()
        {
            Value = new ChangeTrackingList<StorageAccountInformationData>();
        }

        /// <summary> Initializes a new instance of StorageAccountInformationListResult. </summary>
        /// <param name="value"> The results of the list operation. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal StorageAccountInformationListResult(IReadOnlyList<StorageAccountInformationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The results of the list operation. </summary>
        public IReadOnlyList<StorageAccountInformationData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataLakeStore;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> Data Lake Store firewall rule list information. </summary>
    internal partial class FirewallRuleListResult
    {
        /// <summary> Initializes a new instance of FirewallRuleListResult. </summary>
        internal FirewallRuleListResult()
        {
            Value = new ChangeTrackingList<FirewallRuleData>();
        }

        /// <summary> Initializes a new instance of FirewallRuleListResult. </summary>
        /// <param name="value"> The results of the list operation. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal FirewallRuleListResult(IReadOnlyList<FirewallRuleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The results of the list operation. </summary>
        public IReadOnlyList<FirewallRuleData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}

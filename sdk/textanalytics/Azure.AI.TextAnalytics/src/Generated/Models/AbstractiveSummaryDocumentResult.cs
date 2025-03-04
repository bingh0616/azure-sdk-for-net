// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> An object representing the summarization result of a single document. </summary>
    internal partial class AbstractiveSummaryDocumentResult : DocumentResult
    {
        /// <summary> Initializes a new instance of AbstractiveSummaryDocumentResult. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="summaries"> A list of abstractive summaries. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/> or <paramref name="summaries"/> is null. </exception>
        public AbstractiveSummaryDocumentResult(string id, IEnumerable<DocumentWarning> warnings, IEnumerable<AbstractiveSummary> summaries) : base(id, warnings)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (warnings == null)
            {
                throw new ArgumentNullException(nameof(warnings));
            }
            if (summaries == null)
            {
                throw new ArgumentNullException(nameof(summaries));
            }

            Summaries = summaries.ToList();
        }

        /// <summary> Initializes a new instance of AbstractiveSummaryDocumentResult. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="summaries"> A list of abstractive summaries. </param>
        internal AbstractiveSummaryDocumentResult(string id, IList<DocumentWarning> warnings, TextDocumentStatistics? statistics, IList<AbstractiveSummary> summaries) : base(id, warnings, statistics)
        {
            Summaries = summaries;
        }

        /// <summary> A list of abstractive summaries. </summary>
        public IList<AbstractiveSummary> Summaries { get; }
    }
}

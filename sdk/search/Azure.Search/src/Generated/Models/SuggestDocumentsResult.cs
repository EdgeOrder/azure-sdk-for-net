// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Models
{
    /// <summary> Response containing suggestion query results from an index. </summary>
    public partial class SuggestDocumentsResult
    {
        /// <summary> The sequence of results returned by the query. </summary>
        public ICollection<SuggestResult> Results { get; internal set; }
        /// <summary> A value indicating the percentage of the index that was included in the query, or null if minimumCoverage was not set in the request. </summary>
        public double? Coverage { get; internal set; }
    }
}

// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The details about the associated storage account.
    /// </summary>
    public partial class StorageAccount
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        public StorageAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        /// <param name="id">The ID of the storage account resource. Video
        /// Analyzer relies on tables, queues, and blobs. The primary storage
        /// account must be a Standard Storage account (either
        /// Microsoft.ClassicStorage or Microsoft.Storage).</param>
        /// <param name="identity">A managed identity that Video Analyzer will
        /// use to access the storage account.</param>
        /// <param name="status">The current status of the storage account
        /// mapping.</param>
        public StorageAccount(string id = default(string), ResourceIdentity identity = default(ResourceIdentity), string status = default(string))
        {
            Id = id;
            Identity = identity;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the storage account resource. Video Analyzer
        /// relies on tables, queues, and blobs. The primary storage account
        /// must be a Standard Storage account (either Microsoft.ClassicStorage
        /// or Microsoft.Storage).
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a managed identity that Video Analyzer will use to
        /// access the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ResourceIdentity Identity { get; set; }

        /// <summary>
        /// Gets the current status of the storage account mapping.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}

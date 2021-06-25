// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Product families metadata details. </summary>
    public partial class ProductFamiliesMetadataDetails
    {
        /// <summary> Initializes a new instance of ProductFamiliesMetadataDetails. </summary>
        internal ProductFamiliesMetadataDetails()
        {
            ImageInformation = new ChangeTrackingList<ImageInformation>();
            FilterableProperties = new ChangeTrackingList<FilterableProperty>();
            ProductLines = new ChangeTrackingList<ProductLine>();
        }

        /// <summary> Initializes a new instance of ProductFamiliesMetadataDetails. </summary>
        /// <param name="displayName"> Display Name for the product system. </param>
        /// <param name="description"> Description related to the product system. </param>
        /// <param name="imageInformation"> Image information for the product system. </param>
        /// <param name="costInformation"> Cost information for the product system. </param>
        /// <param name="availabilityInformation"> Availability information of the product system. </param>
        /// <param name="hierarchyInformation"> Hierarchy information of a product. </param>
        /// <param name="filterableProperties"> list of filters supported for a product. </param>
        /// <param name="productLines"> List of product lines supported in the product family. </param>
        internal ProductFamiliesMetadataDetails(string displayName, Description description, IReadOnlyList<ImageInformation> imageInformation, CostInformation costInformation, AvailabilityInformation availabilityInformation, HierarchyInformation hierarchyInformation, IReadOnlyList<FilterableProperty> filterableProperties, IReadOnlyList<ProductLine> productLines)
        {
            DisplayName = displayName;
            Description = description;
            ImageInformation = imageInformation;
            CostInformation = costInformation;
            AvailabilityInformation = availabilityInformation;
            HierarchyInformation = hierarchyInformation;
            FilterableProperties = filterableProperties;
            ProductLines = productLines;
        }

        /// <summary> Display Name for the product system. </summary>
        public string DisplayName { get; }
        /// <summary> Description related to the product system. </summary>
        public Description Description { get; }
        /// <summary> Image information for the product system. </summary>
        public IReadOnlyList<ImageInformation> ImageInformation { get; }
        /// <summary> Cost information for the product system. </summary>
        public CostInformation CostInformation { get; }
        /// <summary> Availability information of the product system. </summary>
        public AvailabilityInformation AvailabilityInformation { get; }
        /// <summary> Hierarchy information of a product. </summary>
        public HierarchyInformation HierarchyInformation { get; }
        /// <summary> list of filters supported for a product. </summary>
        public IReadOnlyList<FilterableProperty> FilterableProperties { get; }
        /// <summary> List of product lines supported in the product family. </summary>
        public IReadOnlyList<ProductLine> ProductLines { get; }
    }
}

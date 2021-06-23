// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Description related properties of a product system. </summary>
    public partial class Description
    {
        /// <summary> Initializes a new instance of Description. </summary>
        internal Description()
        {
            Keywords = new ChangeTrackingList<string>();
            Attributes = new ChangeTrackingList<string>();
            Links = new ChangeTrackingList<Link>();
        }

        /// <summary> Initializes a new instance of Description. </summary>
        /// <param name="descriptionType"> Type of description. </param>
        /// <param name="shortDescription"> Short description of the product system. </param>
        /// <param name="longDescription"> Long description of the product system. </param>
        /// <param name="keywords"> Keywords for the product system. </param>
        /// <param name="attributes"> Attributes for the product system. </param>
        /// <param name="links"> Links for the product system. </param>
        internal Description(DescriptionType? descriptionType, string shortDescription, string longDescription, IReadOnlyList<string> keywords, IReadOnlyList<string> attributes, IReadOnlyList<Link> links)
        {
            DescriptionType = descriptionType;
            ShortDescription = shortDescription;
            LongDescription = longDescription;
            Keywords = keywords;
            Attributes = attributes;
            Links = links;
        }

        /// <summary> Type of description. </summary>
        public DescriptionType? DescriptionType { get; }
        /// <summary> Short description of the product system. </summary>
        public string ShortDescription { get; }
        /// <summary> Long description of the product system. </summary>
        public string LongDescription { get; }
        /// <summary> Keywords for the product system. </summary>
        public IReadOnlyList<string> Keywords { get; }
        /// <summary> Attributes for the product system. </summary>
        public IReadOnlyList<string> Attributes { get; }
        /// <summary> Links for the product system. </summary>
        public IReadOnlyList<Link> Links { get; }
    }
}

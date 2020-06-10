// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> The ShareInfoElement. </summary>
    public partial class ShareInfoElement
    {
        /// <summary> Initializes a new instance of ShareInfoElement. </summary>
        public ShareInfoElement()
        {
        }

        /// <summary> Initializes a new instance of ShareInfoElement. </summary>
        /// <param name="vmUri"> A relative URI containing the ID of the VM that has the disk attached. </param>
        internal ShareInfoElement(string vmUri)
        {
            VmUri = vmUri;
        }

        /// <summary> A relative URI containing the ID of the VM that has the disk attached. </summary>
        public string VmUri { get; }
    }
}
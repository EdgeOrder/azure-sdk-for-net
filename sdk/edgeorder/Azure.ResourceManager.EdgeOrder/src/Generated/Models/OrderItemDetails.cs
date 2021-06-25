// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Order item details. </summary>
    public partial class OrderItemDetails
    {
        /// <summary> Initializes a new instance of OrderItemDetails. </summary>
        /// <param name="productDetails"> Unique identifier for configuration. </param>
        /// <param name="orderItemType"> Order item type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="productDetails"/> is null. </exception>
        public OrderItemDetails(ProductDetails productDetails, OrderItemType orderItemType)
        {
            if (productDetails == null)
            {
                throw new ArgumentNullException(nameof(productDetails));
            }

            ProductDetails = productDetails;
            OrderItemType = orderItemType;
            OrderItemStageHistory = new ChangeTrackingList<StageDetails>();
            NotificationEmailList = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of OrderItemDetails. </summary>
        /// <param name="productDetails"> Unique identifier for configuration. </param>
        /// <param name="orderItemType"> Order item type. </param>
        /// <param name="currentStage"> Current Order item Status. </param>
        /// <param name="orderItemStageHistory"> Order item status history. </param>
        /// <param name="preferences"> Customer notification Preferences. </param>
        /// <param name="forwardShippingDetails"> Forward Package Shipping details. </param>
        /// <param name="reverseShippingDetails"> Reverse Package Shipping details. </param>
        /// <param name="notificationEmailList"> Additional notification email list. </param>
        /// <param name="cancellationReason"> Cancellation reason. </param>
        /// <param name="cancellationStatus"> Describes whether the orderItem is cancellable or not. </param>
        /// <param name="deletionStatus"> Describes whether the order item is deletable or not. </param>
        /// <param name="returnReason"> Return reason. </param>
        /// <param name="returnStatus"> Describes whether the orderItem is returnable or not. </param>
        /// <param name="managementRpDetails"> parent RP details. </param>
        /// <param name="error"> Top level error for the job. </param>
        internal OrderItemDetails(ProductDetails productDetails, OrderItemType orderItemType, StageDetails currentStage, IReadOnlyList<StageDetails> orderItemStageHistory, Preferences preferences, ShippingDetails forwardShippingDetails, ShippingDetails reverseShippingDetails, IList<string> notificationEmailList, string cancellationReason, OrderItemCancellationEnum? cancellationStatus, ActionStatusEnum? deletionStatus, string returnReason, OrderItemReturnEnum? returnStatus, object managementRpDetails, ErrorDetail error)
        {
            ProductDetails = productDetails;
            OrderItemType = orderItemType;
            CurrentStage = currentStage;
            OrderItemStageHistory = orderItemStageHistory;
            Preferences = preferences;
            ForwardShippingDetails = forwardShippingDetails;
            ReverseShippingDetails = reverseShippingDetails;
            NotificationEmailList = notificationEmailList;
            CancellationReason = cancellationReason;
            CancellationStatus = cancellationStatus;
            DeletionStatus = deletionStatus;
            ReturnReason = returnReason;
            ReturnStatus = returnStatus;
            ManagementRpDetails = managementRpDetails;
            Error = error;
        }

        /// <summary> Unique identifier for configuration. </summary>
        public ProductDetails ProductDetails { get; set; }
        /// <summary> Order item type. </summary>
        public OrderItemType OrderItemType { get; set; }
        /// <summary> Current Order item Status. </summary>
        public StageDetails CurrentStage { get; }
        /// <summary> Order item status history. </summary>
        public IReadOnlyList<StageDetails> OrderItemStageHistory { get; }
        /// <summary> Customer notification Preferences. </summary>
        public Preferences Preferences { get; set; }
        /// <summary> Forward Package Shipping details. </summary>
        public ShippingDetails ForwardShippingDetails { get; }
        /// <summary> Reverse Package Shipping details. </summary>
        public ShippingDetails ReverseShippingDetails { get; }
        /// <summary> Additional notification email list. </summary>
        public IList<string> NotificationEmailList { get; }
        /// <summary> Cancellation reason. </summary>
        public string CancellationReason { get; }
        /// <summary> Describes whether the orderItem is cancellable or not. </summary>
        public OrderItemCancellationEnum? CancellationStatus { get; }
        /// <summary> Describes whether the order item is deletable or not. </summary>
        public ActionStatusEnum? DeletionStatus { get; }
        /// <summary> Return reason. </summary>
        public string ReturnReason { get; }
        /// <summary> Describes whether the orderItem is returnable or not. </summary>
        public OrderItemReturnEnum? ReturnStatus { get; }
        /// <summary> parent RP details. </summary>
        public object ManagementRpDetails { get; }
        /// <summary> Top level error for the job. </summary>
        public ErrorDetail Error { get; }
    }
}

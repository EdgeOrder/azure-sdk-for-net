// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Describes whether the orderItem is returnable or not. </summary>
    public readonly partial struct OrderItemReturnEnum : IEquatable<OrderItemReturnEnum>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="OrderItemReturnEnum"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OrderItemReturnEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReturnableValue = "Returnable";
        private const string ReturnableWithFeeValue = "ReturnableWithFee";
        private const string NotReturnableValue = "NotReturnable";

        /// <summary> Order item can be returned without fee. </summary>
        public static OrderItemReturnEnum Returnable { get; } = new OrderItemReturnEnum(ReturnableValue);
        /// <summary> Order item can be returned with fee. </summary>
        public static OrderItemReturnEnum ReturnableWithFee { get; } = new OrderItemReturnEnum(ReturnableWithFeeValue);
        /// <summary> Order item not returnable. </summary>
        public static OrderItemReturnEnum NotReturnable { get; } = new OrderItemReturnEnum(NotReturnableValue);
        /// <summary> Determines if two <see cref="OrderItemReturnEnum"/> values are the same. </summary>
        public static bool operator ==(OrderItemReturnEnum left, OrderItemReturnEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OrderItemReturnEnum"/> values are not the same. </summary>
        public static bool operator !=(OrderItemReturnEnum left, OrderItemReturnEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OrderItemReturnEnum"/>. </summary>
        public static implicit operator OrderItemReturnEnum(string value) => new OrderItemReturnEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OrderItemReturnEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OrderItemReturnEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

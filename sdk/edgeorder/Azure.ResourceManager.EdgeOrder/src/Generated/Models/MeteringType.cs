// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Represents Metering type (eg one-time or recurrent). </summary>
    public readonly partial struct MeteringType : IEquatable<MeteringType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="MeteringType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MeteringType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OneTimeValue = "OneTime";
        private const string RecurringValue = "Recurring";
        private const string AdhocValue = "Adhoc";

        /// <summary> One time billing. </summary>
        public static MeteringType OneTime { get; } = new MeteringType(OneTimeValue);
        /// <summary> Recurring billing. </summary>
        public static MeteringType Recurring { get; } = new MeteringType(RecurringValue);
        /// <summary> Adhoc billing. </summary>
        public static MeteringType Adhoc { get; } = new MeteringType(AdhocValue);
        /// <summary> Determines if two <see cref="MeteringType"/> values are the same. </summary>
        public static bool operator ==(MeteringType left, MeteringType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MeteringType"/> values are not the same. </summary>
        public static bool operator !=(MeteringType left, MeteringType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MeteringType"/>. </summary>
        public static implicit operator MeteringType(string value) => new MeteringType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MeteringType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MeteringType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Unit for the dimensions of weight. </summary>
    public readonly partial struct WeightMeasurementUnit : IEquatable<WeightMeasurementUnit>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="WeightMeasurementUnit"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WeightMeasurementUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LBSValue = "LBS";
        private const string KGSValue = "KGS";

        /// <summary> Pounds. </summary>
        public static WeightMeasurementUnit LBS { get; } = new WeightMeasurementUnit(LBSValue);
        /// <summary> Kilograms. </summary>
        public static WeightMeasurementUnit KGS { get; } = new WeightMeasurementUnit(KGSValue);
        /// <summary> Determines if two <see cref="WeightMeasurementUnit"/> values are the same. </summary>
        public static bool operator ==(WeightMeasurementUnit left, WeightMeasurementUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WeightMeasurementUnit"/> values are not the same. </summary>
        public static bool operator !=(WeightMeasurementUnit left, WeightMeasurementUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WeightMeasurementUnit"/>. </summary>
        public static implicit operator WeightMeasurementUnit(string value) => new WeightMeasurementUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WeightMeasurementUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WeightMeasurementUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

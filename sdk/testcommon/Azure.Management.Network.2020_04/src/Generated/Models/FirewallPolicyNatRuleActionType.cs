// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> The action type of a rule. </summary>
    public readonly partial struct FirewallPolicyNatRuleActionType : IEquatable<FirewallPolicyNatRuleActionType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="FirewallPolicyNatRuleActionType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FirewallPolicyNatRuleActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DnatValue = "DNAT";

        /// <summary> DNAT. </summary>
        public static FirewallPolicyNatRuleActionType Dnat { get; } = new FirewallPolicyNatRuleActionType(DnatValue);
        /// <summary> Determines if two <see cref="FirewallPolicyNatRuleActionType"/> values are the same. </summary>
        public static bool operator ==(FirewallPolicyNatRuleActionType left, FirewallPolicyNatRuleActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FirewallPolicyNatRuleActionType"/> values are not the same. </summary>
        public static bool operator !=(FirewallPolicyNatRuleActionType left, FirewallPolicyNatRuleActionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FirewallPolicyNatRuleActionType"/>. </summary>
        public static implicit operator FirewallPolicyNatRuleActionType(string value) => new FirewallPolicyNatRuleActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FirewallPolicyNatRuleActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FirewallPolicyNatRuleActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
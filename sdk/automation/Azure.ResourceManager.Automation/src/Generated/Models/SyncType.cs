// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The sync type. </summary>
    public readonly partial struct SyncType : IEquatable<SyncType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SyncType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SyncType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PartialSyncValue = "PartialSync";
        private const string FullSyncValue = "FullSync";

        /// <summary> PartialSync. </summary>
        public static SyncType PartialSync { get; } = new SyncType(PartialSyncValue);
        /// <summary> FullSync. </summary>
        public static SyncType FullSync { get; } = new SyncType(FullSyncValue);
        /// <summary> Determines if two <see cref="SyncType"/> values are the same. </summary>
        public static bool operator ==(SyncType left, SyncType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SyncType"/> values are not the same. </summary>
        public static bool operator !=(SyncType left, SyncType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SyncType"/>. </summary>
        public static implicit operator SyncType(string value) => new SyncType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SyncType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SyncType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

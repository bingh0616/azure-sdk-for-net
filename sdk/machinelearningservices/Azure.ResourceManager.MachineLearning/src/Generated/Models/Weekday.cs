// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum of weekdays. </summary>
    public readonly partial struct Weekday : IEquatable<Weekday>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Weekday"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Weekday(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MondayValue = "Monday";
        private const string TuesdayValue = "Tuesday";
        private const string WednesdayValue = "Wednesday";
        private const string ThursdayValue = "Thursday";
        private const string FridayValue = "Friday";
        private const string SaturdayValue = "Saturday";
        private const string SundayValue = "Sunday";

        /// <summary> Monday weekday. </summary>
        public static Weekday Monday { get; } = new Weekday(MondayValue);
        /// <summary> Tuesday weekday. </summary>
        public static Weekday Tuesday { get; } = new Weekday(TuesdayValue);
        /// <summary> Wednesday weekday. </summary>
        public static Weekday Wednesday { get; } = new Weekday(WednesdayValue);
        /// <summary> Thursday weekday. </summary>
        public static Weekday Thursday { get; } = new Weekday(ThursdayValue);
        /// <summary> Friday weekday. </summary>
        public static Weekday Friday { get; } = new Weekday(FridayValue);
        /// <summary> Saturday weekday. </summary>
        public static Weekday Saturday { get; } = new Weekday(SaturdayValue);
        /// <summary> Sunday weekday. </summary>
        public static Weekday Sunday { get; } = new Weekday(SundayValue);
        /// <summary> Determines if two <see cref="Weekday"/> values are the same. </summary>
        public static bool operator ==(Weekday left, Weekday right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Weekday"/> values are not the same. </summary>
        public static bool operator !=(Weekday left, Weekday right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Weekday"/>. </summary>
        public static implicit operator Weekday(string value) => new Weekday(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Weekday other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Weekday other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

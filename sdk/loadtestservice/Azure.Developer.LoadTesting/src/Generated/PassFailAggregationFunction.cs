// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.LoadTesting
{
    /// <summary> Aggregation functions for pass/fail criteria. </summary>
    public readonly partial struct PassFailAggregationFunction : IEquatable<PassFailAggregationFunction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PassFailAggregationFunction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PassFailAggregationFunction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CountValue = "count";
        private const string PercentageValue = "percentage";
        private const string AverageValue = "avg";
        private const string Percentile50Value = "p50";
        private const string Percentile75Value = "p75";
        private const string Percentile90Value = "p90";
        private const string Percentile95Value = "p95";
        private const string Percentile96Value = "p96";
        private const string Percentile97Value = "p97";
        private const string Percentile98Value = "p98";
        private const string Percentile99Value = "p99";
        private const string Percentile999Value = "p99.9";
        private const string Percentile9999Value = "p99.99";
        private const string MinimumValue = "min";
        private const string MaximumValue = "max";

        /// <summary> Criteria applies for count value. </summary>
        public static PassFailAggregationFunction Count { get; } = new PassFailAggregationFunction(CountValue);
        /// <summary> Criteria applies for given percentage value. </summary>
        public static PassFailAggregationFunction Percentage { get; } = new PassFailAggregationFunction(PercentageValue);
        /// <summary> Criteria applies for avg value. </summary>
        public static PassFailAggregationFunction Average { get; } = new PassFailAggregationFunction(AverageValue);
        /// <summary> Criteria applies for 50th percentile value. </summary>
        public static PassFailAggregationFunction Percentile50 { get; } = new PassFailAggregationFunction(Percentile50Value);
        /// <summary> Criteria applies for 75th percentile value. </summary>
        public static PassFailAggregationFunction Percentile75 { get; } = new PassFailAggregationFunction(Percentile75Value);
        /// <summary> Criteria applies for 90th percentile value. </summary>
        public static PassFailAggregationFunction Percentile90 { get; } = new PassFailAggregationFunction(Percentile90Value);
        /// <summary> Criteria applies for 95th percentile value. </summary>
        public static PassFailAggregationFunction Percentile95 { get; } = new PassFailAggregationFunction(Percentile95Value);
        /// <summary> Criteria applies for 96th percentile value. </summary>
        public static PassFailAggregationFunction Percentile96 { get; } = new PassFailAggregationFunction(Percentile96Value);
        /// <summary> Criteria applies for 97th percentile value. </summary>
        public static PassFailAggregationFunction Percentile97 { get; } = new PassFailAggregationFunction(Percentile97Value);
        /// <summary> Criteria applies for 98th percentile value. </summary>
        public static PassFailAggregationFunction Percentile98 { get; } = new PassFailAggregationFunction(Percentile98Value);
        /// <summary> Criteria applies for 99th percentile value. </summary>
        public static PassFailAggregationFunction Percentile99 { get; } = new PassFailAggregationFunction(Percentile99Value);
        /// <summary> Criteria applies for 99.9th percentile value. </summary>
        public static PassFailAggregationFunction Percentile999 { get; } = new PassFailAggregationFunction(Percentile999Value);
        /// <summary> Criteria applies for 99.99th percentile value. </summary>
        public static PassFailAggregationFunction Percentile9999 { get; } = new PassFailAggregationFunction(Percentile9999Value);
        /// <summary> Criteria applies for minimum value. </summary>
        public static PassFailAggregationFunction Minimum { get; } = new PassFailAggregationFunction(MinimumValue);
        /// <summary> Criteria applies for maximum value. </summary>
        public static PassFailAggregationFunction Maximum { get; } = new PassFailAggregationFunction(MaximumValue);
        /// <summary> Determines if two <see cref="PassFailAggregationFunction"/> values are the same. </summary>
        public static bool operator ==(PassFailAggregationFunction left, PassFailAggregationFunction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PassFailAggregationFunction"/> values are not the same. </summary>
        public static bool operator !=(PassFailAggregationFunction left, PassFailAggregationFunction right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PassFailAggregationFunction"/>. </summary>
        public static implicit operator PassFailAggregationFunction(string value) => new PassFailAggregationFunction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PassFailAggregationFunction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PassFailAggregationFunction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

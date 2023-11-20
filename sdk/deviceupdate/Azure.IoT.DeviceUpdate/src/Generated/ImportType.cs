// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.IoT.DeviceUpdate
{
    /// <summary> Import type. </summary>
    public readonly partial struct ImportType : IEquatable<ImportType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImportType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImportType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DevicesValue = "Devices";
        private const string ModulesValue = "Modules";
        private const string AllValue = "All";

        /// <summary> Import only devices but not modules. </summary>
        public static ImportType Devices { get; } = new ImportType(DevicesValue);
        /// <summary> Import only modules but not devices. </summary>
        public static ImportType Modules { get; } = new ImportType(ModulesValue);
        /// <summary> Import both devices and modules. </summary>
        public static ImportType All { get; } = new ImportType(AllValue);
        /// <summary> Determines if two <see cref="ImportType"/> values are the same. </summary>
        public static bool operator ==(ImportType left, ImportType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImportType"/> values are not the same. </summary>
        public static bool operator !=(ImportType left, ImportType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ImportType"/>. </summary>
        public static implicit operator ImportType(string value) => new ImportType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImportType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImportType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

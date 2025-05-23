// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Property.AdditionalProperties
{
    public partial class IsStringAdditionalProperties : IJsonModel<IsStringAdditionalProperties>
    {
        internal IsStringAdditionalProperties() => throw null;

        void IJsonModel<IsStringAdditionalProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        IsStringAdditionalProperties IJsonModel<IsStringAdditionalProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual IsStringAdditionalProperties JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<IsStringAdditionalProperties>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        IsStringAdditionalProperties IPersistableModel<IsStringAdditionalProperties>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual IsStringAdditionalProperties PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<IsStringAdditionalProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="isStringAdditionalProperties"> The <see cref="IsStringAdditionalProperties"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(IsStringAdditionalProperties isStringAdditionalProperties) => throw null;

        public static explicit operator IsStringAdditionalProperties(Response result) => throw null;
    }
}

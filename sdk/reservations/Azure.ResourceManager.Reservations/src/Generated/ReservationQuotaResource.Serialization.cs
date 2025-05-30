// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Reservations
{
    public partial class ReservationQuotaResource : IJsonModel<ReservationQuotaData>
    {
        void IJsonModel<ReservationQuotaData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ReservationQuotaData>)Data).Write(writer, options);

        ReservationQuotaData IJsonModel<ReservationQuotaData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ReservationQuotaData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ReservationQuotaData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ReservationQuotaData>(Data, options, AzureResourceManagerReservationsContext.Default);

        ReservationQuotaData IPersistableModel<ReservationQuotaData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ReservationQuotaData>(data, options, AzureResourceManagerReservationsContext.Default);

        string IPersistableModel<ReservationQuotaData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ReservationQuotaData>)Data).GetFormatFromOptions(options);
    }
}

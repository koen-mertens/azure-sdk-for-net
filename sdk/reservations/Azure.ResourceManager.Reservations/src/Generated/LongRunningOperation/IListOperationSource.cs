// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Reservations
{
    internal class IListOperationSource : IOperationSource<IList<ReservationDetailData>>
    {
        IList<ReservationDetailData> IOperationSource<IList<ReservationDetailData>>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            List<ReservationDetailData> array = new List<ReservationDetailData>();
            foreach (var item in document.RootElement.EnumerateArray())
            {
                array.Add(ReservationDetailData.DeserializeReservationDetailData(item));
            }
            return array;
        }

        async ValueTask<IList<ReservationDetailData>> IOperationSource<IList<ReservationDetailData>>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            List<ReservationDetailData> array = new List<ReservationDetailData>();
            foreach (var item in document.RootElement.EnumerateArray())
            {
                array.Add(ReservationDetailData.DeserializeReservationDetailData(item));
            }
            return array;
        }
    }
}

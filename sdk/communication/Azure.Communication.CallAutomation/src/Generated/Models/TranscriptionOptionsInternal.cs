// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Configuration of live transcription. </summary>
    internal partial class TranscriptionOptionsInternal
    {
        /// <summary> Initializes a new instance of <see cref="TranscriptionOptionsInternal"/>. </summary>
        /// <param name="transportUrl"> Transport URL for live transcription. </param>
        /// <param name="transportType"> The type of transport to be used for live transcription, eg. Websocket. </param>
        /// <param name="locale"> Defines the locale for the data e.g en-CA, en-AU. </param>
        /// <param name="startTranscription"> Determines if the transcription should be started immediately after call is answered or not. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="transportUrl"/> or <paramref name="locale"/> is null. </exception>
        public TranscriptionOptionsInternal(string transportUrl, TranscriptionTransport transportType, string locale, bool startTranscription)
        {
            Argument.AssertNotNull(transportUrl, nameof(transportUrl));
            Argument.AssertNotNull(locale, nameof(locale));

            TransportUrl = transportUrl;
            TransportType = transportType;
            Locale = locale;
            StartTranscription = startTranscription;
        }

        /// <summary> Initializes a new instance of <see cref="TranscriptionOptionsInternal"/>. </summary>
        /// <param name="transportUrl"> Transport URL for live transcription. </param>
        /// <param name="transportType"> The type of transport to be used for live transcription, eg. Websocket. </param>
        /// <param name="locale"> Defines the locale for the data e.g en-CA, en-AU. </param>
        /// <param name="speechModelEndpointId"> Endpoint where the custom model was deployed. </param>
        /// <param name="startTranscription"> Determines if the transcription should be started immediately after call is answered or not. </param>
        /// <param name="enableIntermediateResults"> Enables intermediate results for the transcribed speech. </param>
        internal TranscriptionOptionsInternal(string transportUrl, TranscriptionTransport transportType, string locale, string speechModelEndpointId, bool startTranscription, bool? enableIntermediateResults)
        {
            TransportUrl = transportUrl;
            TransportType = transportType;
            Locale = locale;
            SpeechModelEndpointId = speechModelEndpointId;
            StartTranscription = startTranscription;
            EnableIntermediateResults = enableIntermediateResults;
        }

        /// <summary> Transport URL for live transcription. </summary>
        public string TransportUrl { get; }
        /// <summary> The type of transport to be used for live transcription, eg. Websocket. </summary>
        public TranscriptionTransport TransportType { get; }
        /// <summary> Defines the locale for the data e.g en-CA, en-AU. </summary>
        public string Locale { get; }
        /// <summary> Endpoint where the custom model was deployed. </summary>
        public string SpeechModelEndpointId { get; set; }
        /// <summary> Determines if the transcription should be started immediately after call is answered or not. </summary>
        public bool StartTranscription { get; }
        /// <summary> Enables intermediate results for the transcribed speech. </summary>
        public bool? EnableIntermediateResults { get; set; }
    }
}

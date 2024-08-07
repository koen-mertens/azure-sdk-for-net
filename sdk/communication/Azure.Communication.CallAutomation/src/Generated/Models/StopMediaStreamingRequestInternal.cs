// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The StopMediaStreamingRequest. </summary>
    internal partial class StopMediaStreamingRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="StopMediaStreamingRequestInternal"/>. </summary>
        public StopMediaStreamingRequestInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StopMediaStreamingRequestInternal"/>. </summary>
        /// <param name="operationCallbackUri">
        /// Set a callback URI that overrides the default callback URI set by CreateCall/AnswerCall for this operation.
        /// This setup is per-action. If this is not set, the default callback URI set by CreateCall/AnswerCall will be used.
        /// </param>
        internal StopMediaStreamingRequestInternal(string operationCallbackUri)
        {
            OperationCallbackUri = operationCallbackUri;
        }

        /// <summary>
        /// Set a callback URI that overrides the default callback URI set by CreateCall/AnswerCall for this operation.
        /// This setup is per-action. If this is not set, the default callback URI set by CreateCall/AnswerCall will be used.
        /// </summary>
        public string OperationCallbackUri { get; set; }
    }
}

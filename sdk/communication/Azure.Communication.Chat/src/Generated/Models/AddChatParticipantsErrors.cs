// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.Chat
{
    /// <summary> Errors encountered during the addition of the chat participant to the chat thread. </summary>
    public partial class AddChatParticipantsErrors
    {
        /// <summary> Initializes a new instance of AddChatParticipantsErrors. </summary>
        /// <param name="invalidParticipants"> The participants that failed to be added to the chat thread. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="invalidParticipants"/> is null. </exception>
        internal AddChatParticipantsErrors(IEnumerable<ChatError> invalidParticipants)
        {
            if (invalidParticipants == null)
            {
                throw new ArgumentNullException(nameof(invalidParticipants));
            }

            InvalidParticipants = invalidParticipants.ToList();
        }

        /// <summary> Initializes a new instance of AddChatParticipantsErrors. </summary>
        /// <param name="invalidParticipants"> The participants that failed to be added to the chat thread. </param>
        internal AddChatParticipantsErrors(IReadOnlyList<ChatError> invalidParticipants)
        {
            InvalidParticipants = invalidParticipants;
        }

        /// <summary> The participants that failed to be added to the chat thread. </summary>
        public IReadOnlyList<ChatError> InvalidParticipants { get; }
    }
}

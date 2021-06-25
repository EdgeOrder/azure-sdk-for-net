// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.Translation.Document
{
    /// <summary> Document Status Response. </summary>
    public partial class DocumentStatusResult
    {
        /// <summary> Initializes a new instance of DocumentStatusResult. </summary>
        /// <param name="sourceDocumentUri"> Location of the source document. </param>
        /// <param name="createdOn"> Operation created date time. </param>
        /// <param name="lastModified"> Date time in which the operation&apos;s status has been updated. </param>
        /// <param name="status"> List of possible statuses for job or document. </param>
        /// <param name="translatedTo"> To language. </param>
        /// <param name="progress"> Progress of the translation if available. </param>
        /// <param name="documentId"> Document Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceDocumentUri"/>, <paramref name="translatedTo"/>, or <paramref name="documentId"/> is null. </exception>
        internal DocumentStatusResult(Uri sourceDocumentUri, DateTimeOffset createdOn, DateTimeOffset lastModified, TranslationStatus status, string translatedTo, float progress, string documentId)
        {
            if (sourceDocumentUri == null)
            {
                throw new ArgumentNullException(nameof(sourceDocumentUri));
            }
            if (translatedTo == null)
            {
                throw new ArgumentNullException(nameof(translatedTo));
            }
            if (documentId == null)
            {
                throw new ArgumentNullException(nameof(documentId));
            }

            SourceDocumentUri = sourceDocumentUri;
            CreatedOn = createdOn;
            LastModified = lastModified;
            Status = status;
            TranslatedTo = translatedTo;
            Progress = progress;
            DocumentId = documentId;
        }

        /// <summary> Initializes a new instance of DocumentStatusResult. </summary>
        /// <param name="translatedDocumentUri"> Location of the document or folder. </param>
        /// <param name="sourceDocumentUri"> Location of the source document. </param>
        /// <param name="createdOn"> Operation created date time. </param>
        /// <param name="lastModified"> Date time in which the operation&apos;s status has been updated. </param>
        /// <param name="status"> List of possible statuses for job or document. </param>
        /// <param name="translatedTo"> To language. </param>
        /// <param name="error"> This contains an outer error with error code, message, details, target and an inner error with more descriptive details. </param>
        /// <param name="progress"> Progress of the translation if available. </param>
        /// <param name="documentId"> Document Id. </param>
        /// <param name="charactersCharged"> Character charged by the API. </param>
        internal DocumentStatusResult(Uri translatedDocumentUri, Uri sourceDocumentUri, DateTimeOffset createdOn, DateTimeOffset lastModified, TranslationStatus status, string translatedTo, DocumentTranslationError error, float progress, string documentId, long charactersCharged)
        {
            TranslatedDocumentUri = translatedDocumentUri;
            SourceDocumentUri = sourceDocumentUri;
            CreatedOn = createdOn;
            LastModified = lastModified;
            Status = status;
            TranslatedTo = translatedTo;
            Error = error;
            Progress = progress;
            DocumentId = documentId;
            CharactersCharged = charactersCharged;
        }
    }
}

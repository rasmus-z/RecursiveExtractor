﻿using System;

namespace Microsoft.CST.RecursiveExtractor
{
    public class ExtractorOptions
    {
        /// <summary>
        /// Maximum number of bytes before using a FileStream
        /// </summary>
        public int MemoryStreamCutoff { get; set; } = 1024 * 1024;
        /// <summary>
        /// Batch Size for Parallel Processing
        /// </summary>
        public int BatchSize { get; set; } = 10;
        /// <summary>
        ///     Enable timing limit for processing.
        /// </summary>
        public bool EnableTiming { get; set; } = false;

        /// <summary>
        ///     If an archive cannot be extracted return a single file entry for the archive itself.
        /// </summary>
        public bool ExtractSelfOnFail { get; set; } = true;

        /// <summary>
        ///     The maximum number of bytes to extract from the archive and all embedded archives. Set to 0 to
        ///     remove limit. Note that MaxExpansionRatio may also apply. Defaults to 0.
        /// </summary>
        public long MaxExtractedBytes { get; set; } = 0;

        /// <summary>
        ///     By default, stop extracting if the total number of bytes seen is greater than this multiple of
        ///     the original archive size. Used to avoid denial of service (zip bombs and the like).
        /// </summary>
        public double MaxExtractedBytesRatio { get; set; } = 60.0;

        /// <summary>
        ///     If timing is enabled, stop processing after this time span. Used to avoid denial of service
        ///     (zip bombs and the like).
        /// </summary>
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(300);
        public bool Parallel { get; set; }

        public PassFilter Filter = (FileEntryInfo _) => true;
    }
}
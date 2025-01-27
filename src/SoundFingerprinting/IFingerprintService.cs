﻿namespace SoundFingerprinting
{
    using System.Collections.Generic;

    using SoundFingerprinting.Audio;
    using SoundFingerprinting.Configuration;
    using SoundFingerprinting.Data;

    public interface IFingerprintService
    {
        List<HashedFingerprint> CreateFingerprints(AudioSamples samples, FingerprintConfiguration configuration);
        IEnumerable<Fingerprint> CreateFingerprintsFromLogSpectrum(IEnumerable<SpectralImage> spectralImages, FingerprintConfiguration configuration);
    }
}
﻿using System;

namespace LibHac.GcSrv;

/// <summary>
/// Sets the certificate and key used for communicating with the game card ASIC.
/// </summary>
/// <remarks>Based on nnSdk 15.3.0 (FS 15.0.0)</remarks>
public interface IGameCardKeyManager : IDisposable
{
    void PresetInternalKeys(ReadOnlySpan<byte> gameCardKey, ReadOnlySpan<byte> gameCardCertificate);
}
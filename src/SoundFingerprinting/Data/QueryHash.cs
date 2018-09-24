﻿namespace SoundFingerprinting.Data
{
    using System;

    using ProtoBuf;

    [Serializable]
    [ProtoContract]
    public class QueryHash
    {
        public QueryHash(int[] hashes, int sequenceNumber)
        {
            Hashes = hashes;
            SequenceNumber = sequenceNumber;
        }

        [ProtoMember(1)]
        public int[] Hashes { get; }

        [ProtoMember(2)]
        public int SequenceNumber { get; }
    }
}
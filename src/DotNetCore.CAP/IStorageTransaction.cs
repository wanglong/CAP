﻿using System;
using System.Threading.Tasks;
using DotNetCore.CAP.Models;

namespace DotNetCore.CAP
{
    public interface IStorageTransaction : IDisposable
    {
        void UpdateMessage(CapPublishedMessage message);

        void UpdateMessage(CapReceivedMessage message);

        void EnqueueMessage(CapPublishedMessage message);

        void EnqueueMessage(CapReceivedMessage message);

        Task CommitAsync();
    }
}
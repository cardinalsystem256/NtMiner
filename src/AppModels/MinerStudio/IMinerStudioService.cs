﻿using NTMiner.Core.MinerClient;
using NTMiner.Core.MinerServer;
using System;
using System.Collections.Generic;

namespace NTMiner.MinerStudio {
    public interface IMinerStudioService {
        void QueryClientsAsync(QueryClientsRequest query);
        void UpdateClientAsync(string objectId, string propertyName, object value, Action<ResponseBase, Exception> callback);
        void UpdateClientsAsync(string propertyName, Dictionary<string, object> values, Action<ResponseBase, Exception> callback);
        void RemoveClientsAsync(List<string> objectIds, Action<ResponseBase, Exception> callback);
        void GetConsoleOutLinesAsync(IMinerData client, long afterTime);
        void ManualGetConsoleOutLinesAsync(IMinerData client, long afterTime);
        void GetLocalMessagesAsync(IMinerData client, long afterTime);
        void ManualGetLocalMessagesAsync(IMinerData client, long afterTime);

        void EnableRemoteDesktopAsync(IMinerData client);
        void BlockWAUAsync(IMinerData client);
        void SwitchRadeonGpuAsync(IMinerData client, bool on);
        void RestartWindowsAsync(IMinerData client);
        void ShutdownWindowsAsync(IMinerData client);
        void SetAutoBootStartAsync(IMinerData client, SetAutoBootStartRequest request);
        void StartMineAsync(IMinerData client, Guid workId);
        void StopMineAsync(IMinerData client);
        void UpgradeNTMinerAsync(IMinerData client, string ntminerFileName);
        void GetDrivesAsync(IMinerData client);
        void SetVirtualMemoryAsync(IMinerData client, Dictionary<string, int> data);
        void GetLocalIpsAsync(IMinerData client);
        void SetLocalIpsAsync(IMinerData client, List<LocalIpInput> data);
        void GetOperationResultsAsync(IMinerData client, long afterTime);
        void GetSelfWorkLocalJsonAsync(IMinerData client);
        void SaveSelfWorkLocalJsonAsync(IMinerData client, string localJson, string serverJson);
        void GetGpuProfilesJsonAsync(IMinerData client);
        void SaveGpuProfilesJsonAsync(IMinerData client, string json);
    }
}
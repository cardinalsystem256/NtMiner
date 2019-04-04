﻿using System;
using System.Collections.Generic;

namespace NTMiner.Core {
    public class KernelInputData : IKernelInput, IDbEntity<Guid> {
        public KernelInputData() {
            this.Fragments = new List<KernelInputFragment>();
        }

        public Guid GetId() {
            return this.Id;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }
        public Guid DualCoinGroupId { get; set; }
        public string Args { get; set; }
        public bool IsSupportDualMine { get; set; }
        public double DualWeightMin { get; set; }
        public double DualWeightMax { get; set; }
        public bool IsAutoDualWeight { get; set; }
        public string DualWeightArg { get; set; }
        public string DualFullArgs { get; set; }

        public List<KernelInputFragment> Fragments { get; set; }
    }
}

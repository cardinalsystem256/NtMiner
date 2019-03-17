﻿using NTMiner.Notifications;
using NTMiner.Views.Ucs;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace NTMiner.Vms {
    public class ChartsWindowViewModel : ViewModelBase {
        private List<ChartViewModel> _chartVms;
        private int _totalMiningCount;
        private int _totalOnlineCount;

        public ICommand ConfigMinerServerHost { get; private set; }

        public ChartsWindowViewModel() {
            this.ConfigMinerServerHost = new DelegateCommand(() => {
                MinerServerHostConfig.ShowWindow();
            });
        }

        public LangViewModels LangVms {
            get {
                return LangViewModels.Current;
            }
        }

        public int TotalMiningCount {
            get => _totalMiningCount;
            set {
                if (_totalMiningCount != value) {
                    _totalMiningCount = value;
                    OnPropertyChanged(nameof(TotalMiningCount));
                }
            }
        }

        public int TotalOnlineCount {
            get => _totalOnlineCount;
            set {
                if (_totalOnlineCount != value) {
                    _totalOnlineCount = value;
                    OnPropertyChanged(nameof(TotalOnlineCount));
                }
            }
        }

        public List<ChartViewModel> ChartVms {
            get {
                if (_chartVms == null) {
                    _chartVms = new List<ChartViewModel>();
                    foreach (var coinVm in MinerClientsWindowViewModel.Current.MineCoinVms.AllCoins.OrderBy(a => a.SortNumber)) {
                        _chartVms.Add(new ChartViewModel(coinVm));
                    }
                }
                return _chartVms;
            }
        }
    }
}

using System;

namespace interfaces.Interfaces{
    public interface IWalking{
        public bool isHousePest { get; set; }
        public string LegLength { get; set; }
        public bool canRun { get; set; }
    }
}
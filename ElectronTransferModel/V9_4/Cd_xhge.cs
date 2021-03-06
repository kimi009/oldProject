using System;
using ElectronTransferModel.Base;
using ElectronTransferModel.Geo;

namespace ElectronTransferModel.V9_4
{
    [Serializable]
    public class Cd_xhge : DBEntity
    {
        [Precision(10)]
        public System.Double? EDRL { get; set; }
        [KeyField]
        [Precision(5)]
        public System.Int32 G3E_FNO { get; set; }
        [KeyField]
        public System.String NAME { get; set; }
    }
}

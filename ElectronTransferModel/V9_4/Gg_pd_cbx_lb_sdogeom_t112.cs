using System;
using ElectronTransferModel.Base;
using ElectronTransferModel.Geo;

namespace ElectronTransferModel.V9_4
{
    [Serializable]
    public class Gg_pd_cbx_lb_sdogeom_t112 : ElectronBase
    {
        [SelectOnly]
        public System.String CD_SSDW { get; set; }
        [SelectOnly]
        [Precision(5)]
        public System.Int32? G3E_ALIGNMENT { get; set; }
        [SelectOnly]
        [Precision(10)]
        public System.Int64? G3E_CID { get; set; }
        [SelectOnly]
        [Precision(5)]
        public System.Int32? G3E_CNO { get; set; }
        [SelectOnly]
        public System.String G3E_GEOMETRY { get; set; }
        [SelectOnly]
        [Precision(29)]
        public System.Decimal? GDO_GID { get; set; }
        [SelectOnly]
        public System.DateTime? LTT_DATE { get; set; }
        [SelectOnly]
        [Precision(29)]
        public System.Decimal? LTT_ID { get; set; }
        [SelectOnly]
        public System.String LTT_STATUS { get; set; }
        [SelectOnly]
        [Precision(29)]
        public System.Decimal? LTT_TID { get; set; }
    }
}

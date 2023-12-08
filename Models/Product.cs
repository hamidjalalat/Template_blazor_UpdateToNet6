using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models
{
  public class Product : Base.Entity
    {
        public Product()
        {

        }
        
        public string Code { get; set; }
        public string Barcode { get; set; }
        public string Title_Fa { get; set; }
        public string Title_En { get; set; }
        public string HoverText { get; set; }
        public System.Guid ProductTypeList_ID { get; set; }
        public System.Guid Measure_ID { get; set; }
        public string Overview { get; set; }
        public bool IsFavored { get; set; }
        public bool IsNew { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<decimal> CashGift { get; set; }
        public bool FreeSend { get; set; }
        public bool ExpressSend { get; set; }
        public bool SpecialSell { get; set; }
        public bool AmazingOffer { get; set; }
        public bool ShowAlways { get; set; }
        public bool ShowPrice { get; set; }
        public bool ShowDetail { get; set; }
        public bool ShowTimer { get; set; }
        public bool CanOrder { get; set; }
        public Nullable<System.DateTime> ShowStartDateTime { get; set; }
        public Nullable<System.DateTime> ShowExpiratonDateTime { get; set; }
        [DefaultValue("0000/00/00")]
        public string ShowStartDateTimeShamsi { get; set; }
        [DefaultValue("0000/00/00")]
        public string ShowExpiratonDateTimeShamsi { get; set; }
        public Nullable<long> ItemOrder { get; set; }
        public string ShortLink { get; set; }
        public string NormalLink { get; set; }
        public string SeoMetaTitle { get; set; }
        public string SeoMetaDesc { get; set; }
        public string Description { get; set; }
        public string Descriptor { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public Nullable<System.Guid> InsertUser_ID { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public Nullable<System.Guid> LastUpdateUser_ID { get; set; }
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViewModels.Products
{
    public class CreateViewModel
    {
        public CreateViewModel()
        {

        }
        public Guid Id { get; set; }

       
        public string Code { get; set; }
        public string Barcode { get; set; }
        [Required(AllowEmptyStrings = false,
           ErrorMessage = "پر کردن فیلد عنوان فارسی اجباری می باشد")]
        public string Title_Fa { get; set; }
        public string Title_En { get; set; }
        public string HoverText { get; set; }
        public System.Guid ProductType_ID { get; set; }
        public System.Guid Unit_ID { get; set; }
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
        public string ShowStartDateTimeShamsi { get; set; }
        public string ShowExpiratonDateTimeShamsi { get; set; }

        public Nullable<long> ItemOrder { get; set; }
        public string ShortLink { get; set; }
        public string NormalLink { get; set; }
        public string SeoMetaTitle { get; set; }
        public string SeoMetaDesc { get; set; }
        public string Description { get; set; }
        public string Descriptor { get; set; }
        public Guid ChildId { get; set; }
        public Guid ParantId { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public Nullable<System.Guid> InsertUser_ID { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
        public Nullable<System.Guid> LastUpdateUser_ID { get; set; }
        public string Path { get; set; }

    }
}

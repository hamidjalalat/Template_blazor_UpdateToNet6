using GridBlazor.Resources;
//using GridBlazorClientSide.Client.Resources;
using Models;
using GridShared;
using GridShared.Columns;
using GridShared.Utility;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HJTB.Client.Pages.DataGride;

namespace GridBlazorClientSide.Client.ColumnCollections
{
    public class ColumnCollections
    {

        public static Action<IGridColumnCollection<Product>, IList<Func<object, Task>>, object>
        ProductColumnsWithEdit = (c, functions, obj) =>
        {
            c.Add().Encoded(false).Sanitized(false).RenderComponentAs<ProductButtonCellEdit>(obj);

            c.Add(o => o.Id).SetPrimaryKey(true).Titled("شناسه").SetWidth(100).Hidden = true;

            c.Add(o => o.Overview).Titled("توضیحات مختصر");

            c.Add(o => o.SeoMetaTitle).Titled("عنوان سئو");

            c.Add(o => o.HoverText).Titled("متن شناور");

            c.Add(o => o.Description).Titled("شرح").SetWidth(350);

            c.Add(o => o.Title_Fa).Titled("نام محصول");

            c.Add(o => o.Barcode).Titled("بارکد");

            c.Add(o => o.Code).Titled("کد");

            c.Add(o => o.ItemOrder).SetWidth(10).Titled("ترتیب نمایش");
        };
    }
}

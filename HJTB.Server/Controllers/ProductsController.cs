using Dtx;
using GridBlazorClientSide.Client.ColumnCollections;
using GridMvc.Server;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PaydarShop.Server.Controllers
{
    public class ProductsController : BaseApiControllerWithDatabase
    {
        public ProductsController(Data.IUnitOfWork unitOfWork, AutoMapper.IMapper mapper) : base(unitOfWork)
        {
            Mapper = mapper;
        }

        protected AutoMapper.IMapper Mapper { get; }


        [HttpGet("[action]")]
        public ActionResult OrderColumnsWithEdit()
        {
            var repository = UnitOfWork.ProductRepository.GetAll().OrderBy(C=>C.ItemOrder);
            IGridServer<Models.Product> server = new GridServer<Models.Product>(repository, Request.Query,
                true, "productGrid", c => ColumnCollections.ProductColumnsWithEdit(c, null, null))
                    .WithPaging(10)
                    .Sortable()
                    .Filterable()
                    .WithMultipleFilters()
                    .WithGridItemsCount()
                    .Searchable(true, false, false);

            var items = server.ItemsToDisplay;
            return Ok(items);
        }

       


    }
}

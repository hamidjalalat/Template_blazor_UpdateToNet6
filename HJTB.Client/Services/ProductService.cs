using Hjx;
using System;

namespace PaydarShop.Client.Services
{
    public class ProductService : Infrastructure.BaseService
    {
        public ProductService(System.Net.Http.HttpClient client) : base(client)
        {
        }

        protected override string GetApiUrl()
        {
            return "Products";
        }

        public async Task<IList<Models.Product>> GetAsync()
        {

            var result =  await
                GetAsync
                <System.Collections.Generic.IList<Models.Product>>
                ();

            return result;
        }

        public
       async
       System.Threading.Tasks.Task
       <Result<ViewModels.Products.CreateViewModel>>
       GetAsyncById(string id)
        {


            var result =
                await
                GetAsyncById<Result<ViewModels.Products.CreateViewModel>>(id);

            return result;
        }

        public async
            System.Threading.Tasks.Task
            <Models.Product>
            PostAsync(ViewModels.Products.CreateViewModel viewModel)
        {
            var result =
                await
                PostAsync
                <ViewModels.Products.CreateViewModel, Models.Product>
                (viewModel);

            return result;
        }

        public
            async
            System.Threading.Tasks.Task
            <Result>
            DeleteAsync(string Id)
        {
            var result =
                await
                DeleteAsync
                <Result>
                (Id);

            return result;
        }

        public async
         System.Threading.Tasks.Task
         <Result>
         PutAsync(ViewModels.Products.CreateViewModel viewModel)
        {
            var result =
                await
                PutAsync
                <ViewModels.Products.CreateViewModel, Result>
                (viewModel);

            return result;
        }


    }
}

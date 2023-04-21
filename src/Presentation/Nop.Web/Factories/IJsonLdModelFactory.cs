using Nop.Web.Models.Catalog;
using Nop.Web.Models.JsonLD;

namespace Nop.Web.Factories
{
    public partial interface IJsonLdModelFactory
    {
        /// <summary>
        /// Prepare category Breadcrum JsonLD
        /// </summary>
        /// <param name="categoryBreadcrumb">List CategorySimpleModel</param>
        /// <returns>A task that represents the asynchronous operation
        /// The task result JsonLD Breadbrumb list
        /// </returns>
        Task<JsonLdBreadcrumbList> PrepareJsonLdBreadCrumbCategoryAsync(IList<CategorySimpleModel> categoryBreadcrumb);

        /// <summary>
        /// Prepare product breadcrum JsonLD
        /// </summary>
        /// <param name="breadcrumbModel">Product breadcrumb model</param>
        /// <returns>A task that represents the asynchronous operation
        /// The task result JsonLD breadcrumb list
        /// </returns>
        Task<JsonLdBreadcrumbList> PrepareJsonLdBreadCrumbProductAsync(ProductDetailsModel.ProductBreadcrumbModel breadcrumbModel);

        // <summary>
        /// Prepare JsonLD product
        /// </summary>
        /// <param name="model">Product details model</param>
        /// <returns>A task that represents the asynchronous operation
        /// The task result JsonLD product
        /// </returns>
        Task<JsonLdProduct> PrepareJsonLdProductAsync(ProductDetailsModel model);
    }
}

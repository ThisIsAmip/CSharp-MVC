namespace CSharp_MVC.Models
{
    public class CombinedProductaCategoryVm
    {
        public IEnumerable<ProductVm> Products { get; set; }
        public IEnumerable<ProductCategoryVm> Categories { get; set; }
    }
}

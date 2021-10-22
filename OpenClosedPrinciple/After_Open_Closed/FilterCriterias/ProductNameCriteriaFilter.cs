using OpenClosedPrinciple.After_Open_Closed.Interfaces;

namespace OpenClosedPrinciple.After_Open_Closed.FilterCriterias
{
    internal class ProductNameCriteriaFilter : ICriteriaFilter<ProductItem>
    {
        private string _name;

        public ProductNameCriteriaFilter(string name)
        {
            _name = name;
        }

        public bool IsMatchCriteria(ProductItem targetItem)
        {
            return targetItem.Name == _name;
        }
    }
}
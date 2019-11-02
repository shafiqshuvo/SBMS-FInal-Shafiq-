using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystem.Model;
using SmallBusinessManagementSystem.Repository;

namespace SmallBusinessManagementSystem.Manager
{

    public class StockPeriodicalManager
    {
        StockPeriodicalRepository _stockPeriodicalRepository = new StockPeriodicalRepository();

        public List<StockPeriodical> searchStock(StockPeriodical stockPeriodical)
        {
            return _stockPeriodicalRepository.searchStock(stockPeriodical);
            //return _purchaseRepotingRepository.SearchValue(purchaseRepotingModel);
        }


        public bool hasProductExist(StockPeriodical stockPeriodical)
        {
            return _stockPeriodicalRepository.hasProductExist(stockPeriodical);
        }

        public List<CategoryModel> GetCategoryList()
        {
            return _stockPeriodicalRepository.GetCategoryList();
        }

        public List<ProductModel> GetProductList(string category)
        {
            return _stockPeriodicalRepository.GetProductList(category);
        }
    }
}
 
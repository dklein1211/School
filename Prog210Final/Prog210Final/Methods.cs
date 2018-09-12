using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog210Final
{
    public class Methods
    {
        public object RefreshGrids(int selectedData)
        {
            SportsAreUsEntities1 myData = new SportsAreUsEntities1();

            if(selectedData == 1)
            {
                var query =
                    from sportProduct in myData.SportingItems
                    orderby sportProduct.SportingItemID ascending
                    select new
                    {
                        sportProduct.SportingItemID,
                        sportProduct.Name,
                        sportProduct.Description,
                        sportProduct.QuantityOnHand
                    };
                return query.ToList();
            }
            else if (selectedData == 2)
            {
                var query =
                    from healthProduct in myData.HealthItems
                    orderby healthProduct.HealthItemID ascending
                    select new
                    {
                        healthProduct.HealthItemID,
                        healthProduct.Name,
                        healthProduct.Description,
                        healthProduct.QuantityOnHand
                    };
                return query.ToList();
            }
            else
            {
                throw new System.ArgumentException("Data Out of Range");
            }
        }
    }
}

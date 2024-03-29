using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.RazumovMO.Sprint6.Task0.V24.Lib
{
    public class FindMax
    {

        public int FindMaxPrice(int[] products)
        {
            // Проверяем, есть ли хотя бы один товар в массиве
            if (products.Any())
            {
                // Инициализируем переменную для хранения максимальной цены
                int maxPrice = products.First();

                // Проходим по всем товарам в массиве
                foreach (var product in products.Skip(1))
                {
                    // Сравниваем с текущей максимальной ценой
                    if (product >= maxPrice)
                    {
                        maxPrice = product;
                    }
                }

                return maxPrice;
            }

            return 0;
        }
    }
}
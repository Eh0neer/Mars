using System.Collections.Generic;

namespace Mars.Interfaces;

// Интерфейс для сервиса управления блюдами
public interface IDish
{
    List<Dish> ViewAllDishes();
    Dish GetDishById(int dishId);
}
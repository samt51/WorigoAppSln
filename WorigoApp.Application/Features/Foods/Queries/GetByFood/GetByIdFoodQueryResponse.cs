﻿namespace WorigoApp.Application.Features.Foods.Queries.GetByFood
{
    public class GetByIdFoodQueryResponse
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int FoodMenuCategoryId { get; set; }
    }
}

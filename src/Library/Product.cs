//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Product:ICatalogItem
    {
        public Product(string description, double Cost)
        {
            this.Description = description;
            this.Cost = Cost;
        }

        public string Description { get; set; }

        public double Cost { get; set; }
    }
}
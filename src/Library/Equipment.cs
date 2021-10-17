//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Equipment:ICatalogItem
    {
        public Equipment(string description, double cost)
        {
            this.Description = description;
            this.Cost = cost;
        }

        public string Description { get; set; }

        public double Cost { get; set; }
    }
}
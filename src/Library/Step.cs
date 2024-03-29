//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Step
    {
        public Step(ICatalogItem input, double quantity, ICatalogItem equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public ICatalogItem Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public ICatalogItem Equipment { get; set; }

        // Agregado por Expert
        public double GetStepCost()
        {
            return
                (this.Input.Cost * this.Quantity) +
                (this.Equipment.Cost * this.Time);
        }

        // Agregado por SRP
        public string GetTextToPrint()
        {
            return $"{this.Quantity} de '{this.Input.Description}' " +
                $"usando '{this.Equipment.Description}' durante {this.Time}";
        }
    }
}
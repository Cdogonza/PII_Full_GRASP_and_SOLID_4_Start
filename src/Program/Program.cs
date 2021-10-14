//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Catalog.PopulateCatalogs();

            Recipe recipe = new Recipe();
            recipe.FinalProduct = Catalog.GetProduct("Café con leche");
            recipe.AddStep("Café", 100, "Cafetera", 120);
            
            
            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }
    }
}
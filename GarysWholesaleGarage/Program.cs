using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    class Program
    {
          static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
        }
    }
}

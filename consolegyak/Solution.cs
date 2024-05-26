using consolegyak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolegyak
{
   public static class Solution
    {
        public static List<Car> Cars { get; set; } = Car.LoadFromJson("cars.json").OrderBy(x=> x.registration_date).ToList();
        public static List<Owner> Owners { get; set; } = Owner.LoadFromJson("owners.json");

        // ellenorzes beolvasasra
        public static int getCarNumber()
        {
            return Cars.Count;
            
        }

        // ellenorzes beolvasasra
        public static int getOwnerNumber()
        {
            return Owners.Count;

        }

        //ket egymast koveto auto kozott legtobb eltelt ido
        public static string GetDaysBetween()
        {
            Car firstCar = null;
            Car secondCar = null;
            double max = 0;
            for (int i = 0; i < Cars.Count-1; i++)
            {
                double daysBetween = Math.Floor((Cars[i + 1].registration_date - Cars[i].registration_date).TotalDays);
                if (daysBetween>max)
                {
                    max = daysBetween;
                    firstCar = Cars[i];
                    secondCar = Cars[i+1];
                }
            }
            return $"A legtöbb idő a(z) {firstCar.brand} {firstCar.model} és a(z) {secondCar.brand} {secondCar.model} között telt el, {max} nap";
        }
    }
}

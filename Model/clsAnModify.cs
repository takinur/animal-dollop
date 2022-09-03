using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWeightTracker_00183727.Model
{
    class clsAnModify
    {
        private static String AnimalName;
        public string Name {
            get
            {
                return AnimalName;
            }
            set
            {
                AnimalName = value;
            }
        }

        public static int Id { get; set; }
        public static string Age { get; set; }
        public static string Gender { get; set; }
        public static Double weight { get; set; }
        public static Double height { get; set; }
        public static string Spec { get; set; }
        public static string Org { get; set; }
    }
}

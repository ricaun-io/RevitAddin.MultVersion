using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAddin.MultVersion
{
    public class MyClassMultVersion
    {
        public static string GetMeterLabel()
        {
#if REVIT2020
            return LabelUtils.GetLabelFor(UnitType.UT_Length);
#else
            return LabelUtils.GetLabelForUnit(UnitTypeId.Meters);
#endif
        }

        public static string GetVersion()
        {
#if REVIT2020
            return "2020";
#elif REVIT2021
            return "2021";
#elif REVIT2022
            return "2022";
#elif REVIT2023
            return "2023";
#else
            return "";
#endif

        }

    }
}

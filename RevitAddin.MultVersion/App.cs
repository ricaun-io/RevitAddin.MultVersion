#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using RevitAddin.MultVersion.Commands;
using ricaun.Revit.UI;
using System;
using System.Collections.Generic;

#endregion

namespace RevitAddin.MultVersion
{
    [AppLoader]
    public class App : IExternalApplication
    {
        private static RibbonPanel ribbonPanel;
        public Result OnStartup(UIControlledApplication application)
        {
            ribbonPanel = application.CreatePanel("MultVersion");
            ribbonPanel.CreatePushButton<Command>()
                .SetText(MyClassMultVersion.GetVersion())
                .SetToolTip(Properties.Resources.Text)
                .SetLargeImage("/UIFrameworkRes;component/ribbon/images/revit.ico");

            ribbonPanel.CreatePushButton<CommandForm>("Form")
                .SetLargeImage("/UIFrameworkRes;component/ribbon/images/revit.ico");

            ribbonPanel.CreatePushButton<CommandView>("View")
                .SetLargeImage("/UIFrameworkRes;component/ribbon/images/revit.ico");

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            ribbonPanel?.Remove();
            return Result.Succeeded;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RevitWPF.Models
{
    public class OpenWindowCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Title", "Hello World!");

            try
            {
                var app = new App();
                app.Run();
            }
            catch(Exception E)
            {
                
                return Result.Failed;
            }


            return Result.Succeeded;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using RevitView.ModelView;

namespace RevitView.Models.Revit
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class OpenWindowCommand : IExternalCommand
    {
        
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;


            TaskDialog.Show("Title", "Hello World! " + doc.PathName);
            
            MainWindow window = new MainWindow();
            window.Show();

            try
            {
                
            }
            catch(Exception E)
            {
                
                return Result.Failed;
            }


            return Result.Succeeded;
        }
    }
}

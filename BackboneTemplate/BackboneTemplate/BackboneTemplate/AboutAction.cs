using System.Windows.Forms;
using JetBrains.ActionManagement;
using JetBrains.Application.DataContext;

namespace BackboneTemplate
{
    [ActionHandler("BackboneTemplate.About")]
    public class AboutAction : IActionHandler
    {
        public bool Update(IDataContext context, ActionPresentation presentation, DelegateUpdate nextUpdate)
        {
            // return true or false to enable/disable this action
            return true;
        }

        public void Execute(IDataContext context, DelegateExecute nextExecute)
        {
            MessageBox.Show(
              "Backbone Template\nWenbo Li\n\nMake your develop in Backbone quicker",
              "About Backbone Template",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
        }
    }
}
using System.Drawing;
using System.Windows.Forms;

namespace QuakeMapDBEditor;

internal static class FormExtensions
{
    public static void SetDefaultIcon(this Form form)
    {
        form.Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
    }
}

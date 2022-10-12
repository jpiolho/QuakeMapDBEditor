using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuakeMapDBEditor;

internal static class FormExtensions
{
    public static void SetDefaultIcon(this Form form)
    {
        var path = System.Reflection.Assembly.GetExecutingAssembly().Location;

        if (string.IsNullOrEmpty(path))
            path = Path.Combine(Environment.ProcessPath, Process.GetCurrentProcess().MainModule.FileName);

        form.Icon = Icon.ExtractAssociatedIcon(path);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ManuelBelgrano.FormarParejas
{
    public static class Helper
    {
        public static void FitLabel(System.Windows.Forms.Label lbl)
        {
            while (lbl.Width < System.Windows.Forms.TextRenderer.MeasureText(lbl.Text, new Font(lbl.Font.FontFamily, lbl.Font.Size, lbl.Font.Style)).Width)
            {
                lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size - 0.5f, lbl.Font.Style);
            }
        }

        public static dynamic GetResponse(string argument) {
            return "";
        }

    }
}

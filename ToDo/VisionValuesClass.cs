using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Data;

namespace ToDo
{

    public static class VisionValuesClass
    {
        public static void VisionValues(List<int[]> ints, string fontstyle)
        {
            TextColor = new int[] { ints[3][0], ints[3][1], ints[3][2], ints[3][3] };
            BackColor = new int[] { ints[1][0], ints[1][1], ints[1][2], ints[1][3] };
            TodoListColor = new int[] { ints[0][0], ints[0][1], ints[0][2], ints[0][3] };
            FindInputBC = new int[] { ints[2][0], ints[2][1], ints[2][2], ints[2][3] };
            FontStyle = fontstyle;
        }
        public static List<int[]> getvalues()
        {
            return new List<int[]>() { TextColor, BackColor, TodoListColor, FindInputBC };
        }

        static public string getfontstyle()
        {
            return FontStyle;
        }
        static public string? FontStyle = "Segoe UI";
        static public int[] TextColor = { 100, 230, 233, 237 };
        static public int[] BackColor = { 100, 171, 176, 37 };
        static public int[] TodoListColor = { 100, 128, 130, 81 };
        static public int[] FindInputBC = { 100, 102, 140, 13 };

    }
}

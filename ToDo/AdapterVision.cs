using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Data;

namespace ToDo
{
    public class AdapterVision
    {
        //bu class VisionValues ile Db de olan melumatlari bir birine baqlayir
        //good job 
        public AdapterVision( Vision_table sv)
        {
            P( sv);
        }

        public async void P( Vision_table sv)
        {

            List<string>? @string = new List<string>() { sv.TodoListColor, sv.BackColor, sv.FindInputBC, sv.TextColor };
            List<int[]> ints = new List<int[]>();
            foreach (string s in @string)
            {
                int a = 0, r, g, b;
                string c="";
                if (s[0] != '#') c = $"#{s}";
                
                    if (c.Length == 9)
                    {
                        a = Convert.ToInt32(c.Substring(1, 2), 16);
                        r = Convert.ToInt32(c.Substring(3, 2), 16);
                        g = Convert.ToInt32(c.Substring(5, 2), 16);
                        b = Convert.ToInt32(c.Substring(7, 2), 16);
                        ints.Add(new int[] { a, r, g, b });
                    }
                    else if (c.Length == 7)
                    {
                        r = Convert.ToInt32(c.Substring(1, 2), 16);
                        g = Convert.ToInt32(c.Substring(3, 2), 16);
                        b = Convert.ToInt32(c.Substring(5, 2), 16);
                        ints.Add(new int[] { a, r, g, b });
                    }
                

            }
            VisionValuesClass.VisionValues(ints,sv.FontStyle);
        }
    }
}

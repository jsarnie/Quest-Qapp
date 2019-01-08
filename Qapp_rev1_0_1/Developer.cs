using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Qapp_rev1_0_1.Global;
using static System.IO.Directory;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Drawing;

namespace Qapp_rev1_0_1
{
    class Developer {
        public class MyColorTable : ProfessionalColorTable {
            private Color menuItemSelectedColor;
            public MyColorTable(Color color) : base() {
                menuItemSelectedColor = color;
            }
            public override Color MenuItemSelected {
                get { return menuItemSelectedColor; }
            }
        }

    }
}

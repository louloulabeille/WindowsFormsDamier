using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDamier
{
    class ButtonDamier : Button
    {
        // si color = true => clair sinon foncé
        private static bool _color = true;

        public ButtonDamier (Color clair, Color fonce)
            :base()
        {
            this.BackColor = _color ? clair : fonce;
            _color = !_color;
        }

        public static bool Color { get => _color; set => _color = value; }
    }
}

using Bussynes.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bussynes
{
    public class ControlBuilder
    {
        public DataControl BuildControl()
        {
            var dataControl = new DataControl()
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left,
            };
            dataControl.Controls.Find("name1Tb", true)[0].Text = "Имя";
            dataControl.Controls.Find("text1Tb", true)[0].Text = "Текст";
            return dataControl;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bussynes.Controls
{
    public partial class DataControl : UserControl
    {
        public DataControl()
        {
            InitializeComponent();
        }
        public DataControl(int time)
        {
            InitializeComponent();
            BuildControl();
            this.Size = new Size(this.Width, this.Height + (23*5));
        }
        public void BuildControl()
        {
            for(int i = 1; i < 5; i++)
            {
                var textBox = new TextBox()
                {
                    Name = $"name{i + 1}Tb",
                    Text = $"Что-то там {i + 1}",
                    Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left
                };
                tableLayoutPanel1.Controls.Add(textBox,0, i + 1);
                var textBox2 = new TextBox()
                {
                    Name = $"text{i + 1}Tb",
                    Text = $"Что-то там {i + 1}",
                    Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left
                };
                tableLayoutPanel1.Controls.Add(textBox2, 1, i + 1);
            }
            
        }
    }
}

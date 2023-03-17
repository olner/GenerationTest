using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussynes.Controls;
using Bussynes;

namespace GenerationTests
{
    public partial class Form1 : Form
    {
        private DataControl dataControl;
        private ControlBuilder controlBuilder;
        public Form1()
        {
            InitializeComponent();
        }
        private void BuildTreeView()
        {
            treeView1.Nodes.Add("1");
            treeView1.Nodes.Add("2");
        }
        private void BuildDataControl()
        {
            dataControl = controlBuilder.BuildControl();
            tableLayoutPanel2.Controls.Add(dataControl, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuildTreeView();
            controlBuilder = new ControlBuilder();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tableLayoutPanel2.Controls.Clear();
            BuildDataControl();
        }
    }
}

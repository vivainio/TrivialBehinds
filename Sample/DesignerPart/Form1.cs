using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrivialBehind;

namespace DesignerPart
{
    public class CalcUi
    {
        public Button btnPlus;
        public Label label1;
        public Button btnMinus;

    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // this is only thing you need to add to your form, to expose ui controls
            var d = TrivialBehinds.CreateForUi(new CalcUi
            {
                btnMinus = btnMinus,
                btnPlus = btnPlus,
                label1 = label1
            });
            Deactivate += (o, e) => d.Dispose();
            // boilerplate ends
        }
    }
}

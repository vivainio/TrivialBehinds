﻿using System;
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
    public static class BehindCreator

    {
    }
    public partial class DirectForm : Form
    {
        public DirectForm()
        {
            InitializeComponent();
            BehindCreator.CreateComponentBehind(this);

        }
    }
}
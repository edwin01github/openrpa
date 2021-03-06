using Microsoft.VisualBasic.Activities;
using System;
using System.Activities;
using System.Activities.Expressions;
using System.Activities.Presentation.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using OpenRPA.Interfaces;

namespace OpenRPA.Utilities
{
    public partial class AddDataColumnDesigner
    {
        public AddDataColumnDesigner()
        {
            InitializeComponent();
        }
        protected override void OnModelItemChanged(Object newItem)
        {
            base.OnModelItemChanged(newItem);
            GenericArgumentTypeUpdater.Attach(ModelItem);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTargil3
{
    using Entities;
    /// <summary>
    /// Interaction logic for HostingUnitUserControl.xaml
    /// </summary>
    public partial class HostingUnitUserControl : UserControl
    {
        public HostingUnit CurrenthostingUnit { get; set; }

        public HostingUnitUserControl(HostingUnit hostingUnit)
        {
            InitializeComponent();
            CurrenthostingUnit = hostingUnit;
            this.DataContext = CurrenthostingUnit;
        }
    }
}

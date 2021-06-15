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

namespace Weather_App
{
    /// <summary>
    /// Interaktionslogik für uscDay.xaml
    /// </summary>
    public partial class uscDay : UserControl
    {
        public uscDay()
        {
            InitializeComponent();
        }

        public void setImg(ImageSource sImgSource)
        {
            imgWea.Source = sImgSource;
        }
    }
}

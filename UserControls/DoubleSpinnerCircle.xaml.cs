using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WPF.Basics.UserControls
{
    /// <summary>
    /// Interaction logic for DoubleSpinnerCircle.xaml
    /// </summary>
    public partial class DoubleSpinnerCircle : UserControl, INotifyPropertyChanged
    {
        private Brush outerArcColor = Brushes.DarkSlateGray;
        public Brush OuterArcColor
        {
            get { return outerArcColor; }
            set
            {
                OnPropertyChanged(ref outerArcColor, value);
            }
        }

        private Brush innerArcColor = Brushes.DarkSlateGray;
        public Brush InnerArcColor
        {
            get { return innerArcColor; }
            set
            {
                OnPropertyChanged(ref innerArcColor, value);
            }
        }

        private Brush outerRingColor = Brushes.LightSlateGray;
        public Brush OuterRingColor
        {
            get { return outerRingColor; }
            set
            {
                OnPropertyChanged(ref outerRingColor, value);
            }
        }

        private Brush rimColor = Brushes.Black;
        public Brush RimColor
        {
            get { return rimColor; }
            set
            {
                OnPropertyChanged(ref rimColor, value);
            }
        }

        private Brush innerRingColor = Brushes.LightSlateGray;
        public Brush InnerRingColor
        {
            get { return innerRingColor; }
            set
            {
                OnPropertyChanged(ref innerRingColor, value);
            }
        }

        private Brush centerCircleColor = Brushes.Black;
        public Brush CenterCircleColor
        {
            get { return centerCircleColor; }
            set
            {
                OnPropertyChanged(ref centerCircleColor, value);
            }
        }

        public DoubleSpinnerCircle()
        {
            InitializeComponent();
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged<T>([CallerMemberName]string propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void OnPropertyChanged<T>(ref T property, T value, [CallerMemberName]string propertyName = "")
        {
            property = value;
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}

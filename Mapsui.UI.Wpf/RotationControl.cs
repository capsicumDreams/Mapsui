using System;
using System.Windows.Controls;

namespace Mapsui.UI.Wpf
{

    public partial class MapControl : Grid, IMapControl
    {

      public Double Rotation
      {
         get { return Viewport.Rotation; }
         set
         {
            Navigator.RotateTo(value);
            //            Refresh();
            OnPropertyChanged();
         }
		}





    }
}

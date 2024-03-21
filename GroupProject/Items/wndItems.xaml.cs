using System.Windows;

namespace GroupProject.Items
{
    /// <summary>
    /// Interaction logic for wndItems.xaml
    /// </summary>
    public partial class wndItems : Window
    {
        public wndItems()
        {
            InitializeComponent();
        }

        //bool bHasItemsBeenChanged //Set to true when an item has been added/edited/ Deleted.
        // Used by main window to know if it needs to refresh items list

        //bool bHasItemsbeenChanged; //Property Mainwindow will look into this window using this property
    }
}

using SharpShell.SharpContextMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ShellExtensions
{
    /// <summary>
    /// The Count Lines Context Menu Extension
    /// </summary>
    public class DeluxeEditExtension : SharpContextMenu
    {
        const string CommandToRun = "PyDeluxeEdit";

        protected override bool CanShowMenu()
        {
            //  We will always show the menu
            return true;
        }

        protected override ContextMenuStrip CreateMenu()
        {
            //  Create the menu strip
            var menu = new ContextMenuStrip();

            //  Create a 'count lines' item
            var deluxeItem = new ToolStripMenuItem();
            deluxeItem.Text = "DeluxeEdit...";
            deluxeItem.Image = Properties.Resources.deluxe;

            //  When we click, we'll call the 'CountLines' function
            deluxeItem.Click += (sender, args) => startProgram();

            //  Add the item to the context menu
            menu.Items.Add(deluxeItem);

            //  Return the menu
            return menu;
        }
        private void startProgram()
        {
            var selectedPath = SelectedItemPaths.FirstOrDefault();
            if (selectedPath != null)
            {
            }
            //  Go through each fileS
            //  Count the lines
        }

      
     
    }

}

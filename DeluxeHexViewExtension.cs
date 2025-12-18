using SharpShell.Attributes;
using SharpShell.SharpContextMenu;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ShellExtensions
{
    /// <summary>
    /// The Count Lines Context Menu Extension
    /// </summary>
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.AllFiles)]
    public class DeluxeHexViewExtension : SharpContextMenu
    {
        const string ExeToRun = "DeluxeEdit.exe";

        const string suffixToRun = " --hex";
        protected override bool CanShowMenu()
        {
            //  We will always show the menu
            return true;
        }

        protected override ContextMenuStrip CreateMenu()
        {
            //  Create the menu strip
            var menu = new ContextMenuStrip();

            var deluxeItem = new ToolStripMenuItem();
            deluxeItem.Text = "DeluxeHexView...";
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
                var process = new Process();
                process.StartInfo = new ProcessStartInfo(ExeToRun, selectedPath + suffixToRun);
                process.Start();

            }

        }

    }
   }

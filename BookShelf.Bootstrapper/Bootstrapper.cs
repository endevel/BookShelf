using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BookShelf.Views;

namespace BookShelf.Bootstrapper
{
    public class Bootstrapper : IDisposable
    {
        public Window Run()
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();

            return mainWindow;
        }
        
        public void Dispose()
        {
        }
    }
}

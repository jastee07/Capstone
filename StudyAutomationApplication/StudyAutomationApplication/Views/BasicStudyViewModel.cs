using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Caliburn.Micro;

namespace SAA.Views
{
    public class BasicStudyViewModel : Screen
    {
        public BasicStudyViewModel()
        {
        }

        private string basecase;

        public string Basecase
        {
            get
            {
                return basecase;
            }
            set
            {
                basecase = value;
                NotifyOfPropertyChange();
            }
        }

        public void OpenFileExplorer()
        {
            var dialog = new OpenFileDialog();

            dialog.ShowDialog();

            Basecase = dialog.FileName;
        }
    }
}

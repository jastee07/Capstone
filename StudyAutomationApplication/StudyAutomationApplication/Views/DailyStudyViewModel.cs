using Caliburn.Micro;
using Microsoft.Win32;

namespace SAA.Views
{
    public class DailyStudyViewModel : Screen
    {
        public DailyStudyViewModel()
        {
        }

        private string basecase, outageFile, subPath, monPath;
        private string conPath, outputPath, macroPath;

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
        public string OutageFile
        {
            get
            {
                return outageFile;
            }
            set
            {
                outageFile = value;
                NotifyOfPropertyChange();
            }
        }
        public string Sub
        {
            get
            {
                return subPath;
            }
            set
            {
                subPath = value;
                NotifyOfPropertyChange();
            }
        }
        public string Mon
        {
            get
            {
                return monPath;
            }
            set
            {
                monPath = value;
                NotifyOfPropertyChange();
            }
        }
        public string Con
        {
            get
            {
                return conPath;
            }
            set
            {
                conPath = value;
                NotifyOfPropertyChange();
            }
        }
        public string Output
        {
            get
            {
                return outputPath;
            }
            set
            {
                outputPath = value;
                NotifyOfPropertyChange();
            }
        }
        public string Macro
        {
            get
            {
                return macroPath;
            }
            set
            {
                macroPath = value;
                NotifyOfPropertyChange();
            }
        }

        public void SetBasecase()
        {
            var dialog = new OpenFileDialog();

            dialog.ShowDialog();

            Basecase = dialog.FileName;
        }
        public void SetOutageFile()
        {
            var dialog = new OpenFileDialog();

            dialog.ShowDialog();

            OutageFile = dialog.FileName;
        }
        public void SetSub()
        {
            var dialog = new OpenFileDialog();

            dialog.ShowDialog();

            Sub = dialog.FileName;
        }
        public void SetMon()
        {
            var dialog = new OpenFileDialog();

            dialog.ShowDialog();

            Mon = dialog.FileName;
        }
        public void SetCon()
        {
            var dialog = new OpenFileDialog();

            dialog.ShowDialog();

            Con = dialog.FileName;
        }
        public void SetOutput()
        {
            var dialog = new OpenFileDialog();

            dialog.ShowDialog();

            Output = dialog.FileName;
        }
        public void SetMacro()
        {
            var dialog = new OpenFileDialog();

            dialog.ShowDialog();

            Macro = dialog.FileName;
        }
    }
}

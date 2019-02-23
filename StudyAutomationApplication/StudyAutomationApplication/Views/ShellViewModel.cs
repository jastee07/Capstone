using Caliburn.Micro;

namespace SAA.Views
{
    public class ShellViewModel : Conductor<object>.Collection.OneActive
    {
        #region Fields

        // Tab Variables 
        private bool _isHomeActive;
        private bool _isDailyStudyActive;
        private bool _isBasicStudyActive;
        private bool _isUpdateCasesActive;
        private bool _isScaleGenerationActive;
        private bool _isCooperGenerationActive;
        private bool _isTransferStudyActive;

        #endregion Fields

        #region Properties

        // Tab Properties
        public bool IsHomeActive
        {
            get { return _isHomeActive; }
            set
            {
                if (_isHomeActive == value) return;

                _isHomeActive = value;

                // If set to true, display the view for project one 
                if (value)
                    ActivateItem(new HomeViewModel());
            }
        }

        public bool IsDailyStudyActive
        {
            get { return _isDailyStudyActive; }
            set
            {
                if (_isDailyStudyActive == value) return;

                _isDailyStudyActive = value;

                // If set to true, display the view for project one 
                if (value)
                    ActivateItem(new DailyStudyViewModel());
            }
        }

        public bool IsBasicStudyActive
        {
            get { return _isBasicStudyActive; }
            set
            {
                if (_isBasicStudyActive == value) return;

                _isBasicStudyActive = value;

                // If set to true, display the view for project one 
                if (value)
                    ActivateItem(new BasicStudyViewModel());
            }
        }

        public bool IsUpdateCasesActive
        {
            get { return _isUpdateCasesActive; }
            set
            {
                if (_isUpdateCasesActive == value) return;

                _isUpdateCasesActive = value;

                // If set to true, display the view for project one 
                if (value)
                    ActivateItem(new UpdateCasesViewModel());
            }
        }

        public bool IsScaleGenerationActive
        {
            get { return _isScaleGenerationActive; }
            set
            {
                if (_isScaleGenerationActive == value) return;

                _isScaleGenerationActive = value;

                // If set to true, display the view for project one 
                if (value)
                    ActivateItem(new ScaleGenerationViewModel());
            }
        }
        
        public bool IsCooperGenerationActive
        {
            get { return _isCooperGenerationActive; }
            set
            {
                if (_isCooperGenerationActive == value) return;

                _isCooperGenerationActive = value;

                // If set to true, display the view for project one 
                if (value)
                    ActivateItem(new CooperGenerationViewModel());
            }
        }

        public bool IsTransferStudyActive
        {
            get { return _isTransferStudyActive; }
            set
            {
                if (_isTransferStudyActive == value) return;

                _isTransferStudyActive = value;

                // If set to true, display the view for project one 
                if (value)
                    ActivateItem(new TransferStudyViewModel());
            }
        }

        #endregion Properties

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ShellViewModel()
        {
            IsHomeActive = true;
        }
    }
}

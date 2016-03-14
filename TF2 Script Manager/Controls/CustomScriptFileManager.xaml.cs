using System.Windows.Controls;

namespace TF2_Script_Manager.Controls
{
    using System.Collections.Generic;
    using PropertyChanged;

    /// <summary>
    /// Interaction logic for CustomScriptFileManager.xaml
    /// </summary>

    [ImplementPropertyChanged]
    public partial class CustomScriptFileManager {
        public List< string > Commands { get; set; } = new List< string >
                                                       {
                                                            "cl_cmdrate",
                                                            "cl_interp",
                                                            "cl_interp_ratio",
                                                            "cl_lagcompensation",
                                                            "cl_pred_optimize",
                                                            "cl_smooth",
                                                            "cl_smoothtime",
                                                            "cl_updaterate",
                                                            "rate"
                                                       };
        public CustomScriptFileManager()
        {
            InitializeComponent();
        }
    }
}

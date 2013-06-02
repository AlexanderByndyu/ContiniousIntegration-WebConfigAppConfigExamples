namespace WpfApp
{
    using System.Windows;
    using log4net;
    using log4net.Config;

    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            XmlConfigurator.Configure();

            ILog logger = LogManager.GetLogger("logger");

            logger.WarnFormat("Some warn {0}", 109);
        }
    }
}
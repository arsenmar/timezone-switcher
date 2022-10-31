using ProxyTimeApplyer.Services;
using System.Windows.Forms;

namespace ProxyTimeApplyer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            new ServicesResolver().ResolveServices();

            InitializeComponent();
        }


    }
}

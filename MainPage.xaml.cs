using devquestionaire.Services;

namespace devquestionaire
{
    public partial class MainPage : ContentPage
    {
        private readonly IAnalyticsService _analyticsService;
        private readonly ICrashlyticsService _crashlyticsService;
        public MainPage(IAnalyticsService analyticsService, ICrashlyticsService crashlyticsService)
        {
            _analyticsService = analyticsService;
            _crashlyticsService = crashlyticsService;
            InitializeComponent();
        }
        private void AnalyticsLog_Clicked(object sender, EventArgs e)
        {

            _analyticsService.Log("Event_AnaliticsLogClicked");


        }
        int zero = 0;
        private void crashlyticsLog_Clicked(object sender, EventArgs e)
        {
            try
            {
                var divisionByZero = 10 / zero;
            }
            catch
            {
                _crashlyticsService.Log(new Exception("User tried to divide by 0."));
            }

        }

    }

}

namespace MAUIApp2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnFirstImageClicked(object sender, EventArgs e)
        { 
                 imageButton1.Source = "reality1_img.png";
            }
        private void OnSecondImageClicked(object sender, EventArgs e)
        {
                imageButton2.Source = "reality2_img.png";
            }
        }
    }

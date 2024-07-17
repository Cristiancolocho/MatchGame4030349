namespace MatchGame4030349
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            SetUpGame();
        }
        //Validamos el SetUpGame
        private void SetUpGame()
        {
            //Introducimos emogis con una lista
            List<string> animalEmoji = new List<string>()

            {
                "🐶","🐶",
                "🙈","🙈",
                "🦑","🦑",
                "🐘","🐘",
                "🦓","🦓",
                "🦒","🦒",
                "🦆","🦆",
                "🐬","🐬",
            };

            Random random = new Random();

            foreach (Button view in Grid1.Children)
            {
                int index = random.Next(animalEmoji.Count);

                string nextEmoji = animalEmoji[index];

                view.Text = nextEmoji;

                animalEmoji.RemoveAt(index);
            }
        }

        Button ultimoButtonClicked;
        bool encontrandoMatch = false;

        //Hacemos que funncione el codigo en el button
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (encontrandoMatch== false)
            {
                button.IsVisible= false;
                ultimoButtonClicked = button;
                encontrandoMatch = true;
            }
            else if (button.Text==ultimoButtonClicked.Text)
            {
                button.IsVisible = false;
                encontrandoMatch = false;
            }
            else
            {
                ultimoButtonClicked.IsVisible = true;
                encontrandoMatch = false;
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_13(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_14(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_15(object sender, EventArgs e)
        {

        }
    }

}

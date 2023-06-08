using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MemoryGameApp
{
    public partial class MainPage : ContentPage
    {
        List<string> images = new List<string>()
        {
            "eevee.png",
            "gardevoir.png",
            "gengar.png",
            "pikachu.png",
            "totodile.png",
            "toxapex.png",
            "typhlosion.png",
            "umbreon.png",
            "eevee.png",
            "gardevoir.png",
            "gengar.png",
            "pikachu.png",
            "totodile.png",
            "toxapex.png",
            "typhlosion.png",
            "umbreon.png"
        };

        // keep track of how many cards are selected
        int selectedCount = 0;

        // create a temporary image button in code to keep track of the first selection
        ImageButton firstSelection = new ImageButton();
        ImageButton secondSelection = new ImageButton();

        // random, shuffled list
        List<string> shuffledImageList;
        List<ImageButton> imageButtons = new List<ImageButton>();

        public MainPage()
        {
            InitializeComponent();

            imageButtons.Add(ImgBtn1);
            imageButtons.Add(ImgBtn2);
            imageButtons.Add(ImgBtn3);
            imageButtons.Add(ImgBtn4);
            imageButtons.Add(ImgBtn5);
            imageButtons.Add(ImgBtn6);
            imageButtons.Add(ImgBtn7);
            imageButtons.Add(ImgBtn8);
            imageButtons.Add(ImgBtn9);
            imageButtons.Add(ImgBtn10);
            imageButtons.Add(ImgBtn11);
            imageButtons.Add(ImgBtn12);
            imageButtons.Add(ImgBtn13);
            imageButtons.Add(ImgBtn14);
            imageButtons.Add(ImgBtn15);
            imageButtons.Add(ImgBtn16);

            // shuffle the images
            Random randomGenerator = new Random();
            // use our random generator and shuffle the images
            shuffledImageList = images.OrderBy(image => randomGenerator.Next()).ToList();
        }

        private async void ImgBtn1_Clicked(object sender, EventArgs e)
        {
            ImageButton pressedImage = (ImageButton)sender;

            if (pressedImage.Source == null)
            {
                pressedImage.Source = shuffledImageList[int.Parse(pressedImage.ClassId)];
            }

            if (selectedCount == 0)
            {
                firstSelection = pressedImage;
            }
            else if (selectedCount == 1)
            {
                secondSelection = pressedImage;
            }

            selectedCount++;

            // after we select at least 2 cards
            if (selectedCount == 2)
            {
                GridImages.IsEnabled = false;
                await Task.Delay(1000);
                GridImages.IsEnabled = true;

                if ((firstSelection.Source != null && secondSelection.Source != null) && (firstSelection.Source.ToString() == secondSelection.Source.ToString()))
                {
                    firstSelection.BackgroundColor = Color.Green;
                    secondSelection.BackgroundColor = Color.Green;

                    firstSelection.IsEnabled = false;
                    secondSelection.IsEnabled = false;
                }
                else
                {
                    firstSelection.Source = null;
                    secondSelection.Source = null;
                }

                selectedCount = 0;
            }
        }

        private void BtnReset_Clicked(object sender, EventArgs e)
        {
            // reset the user's selection
            firstSelection.Source = null;
            secondSelection.Source = null;

            // reset the number of cards the user grabbed
            selectedCount = 0;

            // randomizing the board
            Random randomGenerator = new Random();
            shuffledImageList = images.OrderBy(image => randomGenerator.Next()).ToList();

            foreach (var button in imageButtons)
            {
                button.Source = null;
                button.BackgroundColor = Color.White;
                button.IsEnabled = true;
            }
        }
    }
}

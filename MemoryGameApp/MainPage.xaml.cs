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

        private void ImgBtn1_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnReset_Clicked(object sender, EventArgs e)
        {

        }
    }
}

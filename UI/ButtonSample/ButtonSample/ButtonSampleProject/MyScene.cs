#region Using Statements
using System;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Common.Math;
using WaveEngine.Components.Cameras;
using WaveEngine.Components.Graphics2D;
using WaveEngine.Components.Graphics3D;
using WaveEngine.Components.UI;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Resources;
using WaveEngine.Framework.Services;
using WaveEngine.Framework.UI;
#endregion

namespace ButtonSampleProject
{
    public class MyScene : Scene
    {
        Button button1, button2, button3, button4, button5, button6, button7, button8, button9;
        TextBlock textblock1, textblock2;
        int clickCounter;
        Image image;

        protected override void CreateScene()
        {
            FixedCamera2D camera2d = new FixedCamera2D("camera");
            camera2d.BackgroundColor = Color.Gray;
            EntityManager.Add(camera2d);
            
            // Group 1
            int offsetTop = 20;
            int spacing = 60;
            button1 = new Button()
            {
                Margin = new Thickness(20, offsetTop, 0, 0),
            };
            EntityManager.Add(button1.Entity);

            // Group 2
            button2 = new Button()
            {
                Margin = new Thickness(20, offsetTop + spacing, 0, 0),
                Text = "N1",
                Width = 50,
                Height = 50,
                Foreground = Color.LightPink,
                BackgroundColor = Color.Purple,
            };
            button2.Click += button_group2_Click;
            EntityManager.Add(button2.Entity);

            button3 = new Button()
            {
                Margin = new Thickness(20 + 60, offsetTop + spacing, 0, 0),
                Text = "N2",
                Width = 50,
                Height = 50,
                Foreground = Color.LightPink,
                BackgroundColor = Color.Purple,
            };
            button3.Click += button_group2_Click;
            EntityManager.Add(button3.Entity);

            button4 = new Button()
            {
                Margin = new Thickness(20 + 60 * 2, offsetTop + spacing, 0, 0),
                Text = "N3",
                Width = 50,
                Height = 50,
                Foreground = Color.LightPink,
                BackgroundColor = Color.Purple,
            };
            button4.Click += button_group2_Click;
            EntityManager.Add(button4.Entity);

            button5 = new Button()
            {
                Margin = new Thickness(20 + 60 * 3, offsetTop + spacing, 0, 0),
                Text = "N4",
                Width = 50,
                Height = 50,
                Foreground = Color.LightPink,
                BackgroundColor = Color.Purple,
            };
            button5.Click += button_group2_Click;
            EntityManager.Add(button5.Entity);

            button6 = new Button()
            {
                Margin = new Thickness(20 + 60 * 4, offsetTop + spacing, 0, 0),
                Text = "N5",
                Width = 50,
                Height = 50,
                Foreground = Color.LightPink,
                BackgroundColor = Color.Purple,
            };
            button6.Click += button_group2_Click;
            EntityManager.Add(button6.Entity);

            textblock1 = new TextBlock()
            {
                Margin = new Thickness(20, offsetTop + spacing * 2, 0, 0),
                Text = "Event click:",
                Foreground = Color.Purple,
            };
            EntityManager.Add(textblock1.Entity);

            // Group 3
            button7 = new Button()
            {
                Margin = new Thickness(20, offsetTop + spacing * 3, 0, 0),
                Text = "<<Button extra large>>",
                Width = 360,
                Height = 40,
                Foreground = Color.Blue,
                BackgroundColor = Color.LightBlue,
            };
            EntityManager.Add(button7.Entity);

            // Group 4
            button8 = new Button()
            {
                Margin = new Thickness(20, offsetTop + spacing * 4, 0, 0),
                Text = "Short",
                Width = 70,
                Height = 120,
                Foreground = Color.White,
                BackgroundColor = Color.Orange,
            };
            EntityManager.Add(button8.Entity);

            // Group 5
            button9 = new Button()
            {
                Margin = new Thickness(20, offsetTop + spacing * 6.5f, 0, 0),
                Text = string.Empty,
                Width = 150,
                Height = 150,
                BackgroundImage = "Content/Emergency.wpk",
                IsBorder = false,
            };
            button9.Click += button9_Click;
            EntityManager.Add(button9.Entity);

            textblock2 = new TextBlock()
            {
                Margin = new Thickness(190, offsetTop + spacing * 6.5f, 0, 0),
                Text = "Click counter: " + clickCounter,
                Foreground = Color.Red,
            };
            EntityManager.Add(textblock2.Entity);

            // Image check
            AddCheckImage("Content/ButtonSample.wpk");
        }

        /// <summary>
        /// Handles the Click event of the button9 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        void button9_Click(object sender, EventArgs e)
        {
            textblock2.Text = "Click counter: " + ++clickCounter;
        }

        /// <summary>
        /// Handles the Click event of the button_group2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        void button_group2_Click(object sender, EventArgs e)
        {
            textblock1.Text = "Event click: " + (sender as Button).Text;
        }

        /// <summary>
        /// Adds the check image.
        /// </summary>
        /// <param name="filename">The filename.</param>
        private void AddCheckImage(string filename)
        {
            image = new Image(filename)
            {
                Margin = new Thickness(400, 0, 0, 0),
                Width = 400,
                Height = 600,
            };
            EntityManager.Add(image.Entity);
        }
    }
}

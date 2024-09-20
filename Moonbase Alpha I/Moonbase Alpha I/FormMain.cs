using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase_Alpha_I
{
    public partial class FormMain : Form
    {
        //Class name and Object name
        ClassArea objectGenPurposeRoom = new ClassArea();
        ClassArea objectControlRoom = new ClassArea();
        ClassArea objectRelaxStation = new ClassArea();
        ClassArea objectTravelRoom = new ClassArea();
        ClassArea objectSimRoom = new ClassArea();

        public FormMain()
        {
            InitializeComponent();

        }


       
        private void FormMain_Load(object sender, EventArgs e)
        {
          



        }

        //Button Navigation from General Purpose Room to Control Room
        private void buttonContRoom_Click_1(object sender, EventArgs e)
        {
            //Changes to new room Control Room
            labelAreaName.Text = objectControlRoom.AreaName;
            //Changes area description
            textBoxAreaDescription.Text = objectControlRoom.AreaDescription;
            this.BackgroundImage = Properties.Resources.a2b9133931cd17177e2883bde9338b7e;
        }

        //Button Navigation from General Purpose Room to Relaxation Station
        private void button2_Click(object sender, EventArgs e)
        {
            //Changes to new room Relaxation Station
            labelAreaName.Text = objectRelaxStation.AreaName;
            //Change area description
            textBoxAreaDescription.Text = objectRelaxStation.AreaDescription;
            //Changing backround image
            this.BackgroundImage = Properties.Resources.SYT_170917_l;
        }

        private void buttonTravel_Click(object sender, EventArgs e)
        {
            //Changes to new room Travel Room
            labelAreaName.Text = objectTravelRoom.AreaName;
            //Change area description
            textBoxAreaDescription.Text = objectTravelRoom.AreaDescription;
            //Changing backround image
            this.BackgroundImage = Properties.Resources._110_048_0620_plate_1001;
        }

        private void buttonSimRoom_Click(object sender, EventArgs e)
        {
            //Changes to new room Simulation Room
            labelAreaName.Text = objectSimRoom.AreaName;
            //Change area description
            textBoxAreaDescription.Text = objectSimRoom.AreaDescription;
            this.BackgroundImage = Properties.Resources.X_13_VR_simulation_room;
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {
            //Set Starting Room
            labelAreaName.Text = objectGenPurposeRoom.AreaName;
            textBoxAreaDescription.Text = objectGenPurposeRoom.AreaDescription;

            //General Purpose room
            labelAreaName.Text = "General Purpose Room";
            textBoxAreaDescription.Text =
                 "This is the multipurpose room, to the left you see a table of food, around are different chairs to rest on. " +
                 "To the left you see a control panel. To the far left you see a shelf holding different space rocks. " +
                 "To the very right you see a window giving you a nice view of large space rocks. In the furthest left chair you see a man napping peacefully, " +
                 "while the screen on the wall monitors his breathing and heart rate.";

            //Set Properties of new objects
            objectGenPurposeRoom.AreaName = "General Purpose Room";
            objectGenPurposeRoom.AreaDescription = "This is the multipurpose room, to the left you see a table of food, around are different chairs to rest on. " +
                "To the left you see a control panel. To the far left you see a shelf holding different space rocks. " +
                "To the very right you see a window giving you a nice view of large space rocks. In the furthest left chair you see a man napping peacefully, " +
                "while the screen on the wall monitors his breathing and heart rate.";
            objectControlRoom.AreaName = "Control Room";
            objectControlRoom.AreaDescription =
                "In our sleak yet highly intelligent control room you see two comfortable chairs placed for the captain and " +
                "co-captain. To the right of their seats is video monitor set up for the crew to be able to video home to their loved ones. " +
                "Large panoramic windows cover the front of the ship for optimal view of the land." +
                "Don't be fooled by this minimalistic set up, this base is so advanced it does not need much human interaction.";
            objectRelaxStation.AreaName = "Relaxation Station";
            objectRelaxStation.AreaDescription =
                "Welcome to the Relaxation Station! Here you will find many books to keep you intertained during your down time" +
                "On the top desk you see a virtual game board along with its two controllers" +
                "On the wall there is a tv to watch all your favorite movies, t.v. shows, or any type of online entertainment." +
                "Tired of staring at that beautiful hunk of grey rock all the time? The windows have many options" +
                " showing a very life like projection screen. From glaciers, to deserts, to lakes or fields of flowers. " +
                "Down below you are tables to do your own activities on or watch a different show on. Feel free to open the cabinets on either " +
                "level to find an abundance of board games or arts and crafts supplies.";
            objectTravelRoom.AreaName = "Travel Room";
            objectTravelRoom.AreaDescription =
                "In this room we have our different vehicles and robots that we explore the moon with." +
                "Don't mind the dent in the land rover, a tiny meteor hit our vehicle, " +
                "but as you can see our land rover was way stronger. The Travel Room must always be kept" +
                "clean and without clutter.";
            objectSimRoom.AreaName = "Simulation Room";
            objectSimRoom.AreaDescription =
                "Are the projector screens just not doing it for you? Then climb aboard one of our simulation controls!" +
                "Find yourself sunbathing on the beautiful shores of the Bahamas, or relaxing in a treehouse in the jungle, " +
                "listening to the pitter patter of raindrops falling on the thatched roof. Any biome you can think of, we'll" +
                "take you there! Want something more exciting? Choose adventure mode and play through many of our thrilling games!" +
                "Does your family back on earth own our VR headset etention? Then you can join them in the comfort of your own home, " +
                "it's almost like you are there!";
        }

        /*private void labelAreaName_Click(object sender, EventArgs e)
        {

        }
        private void textBoxAreaDescription_TextChanged(object sender, EventArgs e)
        {

        }*/

    }
}

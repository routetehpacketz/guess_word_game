using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace guess_word_game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private static string[] words_array = { "Abuse", "Adult", "Agent", "Anger", "Apple", "Award", "Basis", "Beach", "Birth", "Block", "Blood", "Board", "Brain", "Bread", "Break", "Brown", "Buyer", "Cause", "Chain", "Chair", "Chest", "Chief", "Child", "China", "Claim", "Class", "Clock", "Coach", "Coast", "Court", "Cover", "Cream", "Crime", "Cross", "Crowd", "Crown", "Cycle", "Dance", "Death", "Depth", "Doubt", "Draft", "Drama", "Dream", "Dress", "Drink", "Drive", "Earth", "Enemy", "Entry", "Error", "Event", "Faith", "Fault", "Field", "Fight", "Final", "Floor", "Focus", "Force", "Frame", "Frank", "Front", "Fruit", "Glass", "Grant", "Grass", "Green", "Group", "Guide", "Heart", "Henry", "Horse", "Hotel", "House", "Image", "Index", "Input", "Issue", "Japan", "Jones", "Judge", "Knife", "Laura", "Layer", "Level", "Lewis", "Light", "Limit", "Lunch", "Major", "March", "Match", "Metal", "Model", "Money", "Month", "Motor", "Mouth", "Music", "Night", "Noise", "North", "Novel", "Nurse", "Offer", "Order", "Other", "Owner", "Panel", "Paper", "Party", "Peace", "Peter", "Phase", "Phone", "Piece", "Pilot", "Pitch", "Place", "Plane", "Plant", "Plate", "Point", "Pound", "Power", "Press", "Price", "Pride", "Prize", "Proof", "Queen", "Radio", "Range", "Ratio", "Reply", "Right", "River", "Round", "Route", "Rugby", "Scale", "Scene", "Scope", "Score", "Sense", "Shape", "Share", "Sheep", "Sheet", "Shift", "Shirt", "Shock", "Sight", "Simon", "Skill", "Sleep", "Smile", "Smith", "Smoke", "Sound", "South", "Space", "Speed", "Spite", "Sport", "Squad", "Staff", "Stage", "Start", "State", "Steam", "Steel", "Stock", "Stone", "Store", "Study", "Stuff", "Style", "Sugar", "Table", "Taste", "Terry", "Theme", "Thing", "Title", "Total", "Touch", "Tower", "Track", "Trade", "Train", "Trend", "Trial", "Trust", "Truth", "Uncle", "Union", "Unity", "Value", "Video", "Visit", "Voice", "Waste", "Watch", "Water", "While", "White", "Whole", "Woman", "World", "Youth", "", "There", "Where", "Which", "Whose", "Admit", "Adopt", "Agree", "Allow", "Alter", "Apply", "Argue", "Arise", "Avoid", "Begin", "Blame", "Break", "Bring", "Build", "Burst", "Carry", "Catch", "Cause", "Check", "Claim", "Clean", "Clear", "Climb", "Close", "Count", "Cover", "Cross", "Dance", "Doubt", "Drink", "Drive", "Enjoy", "Enter", "Exist", "Fight", "Focus", "Force", "Guess", "Imply", "Issue", "Judge", "Laugh", "Learn", "Leave", "Limit", "Marry", "Match", "Occur", "Offer", "Order", "Phone", "Place", "Point", "Press", "Prove", "Raise", "Reach", "Refer", "Relax", "Serve", "Shall", "Share", "Shift", "Shoot", "Sleep", "Solve", "Sound", "Speak", "Spend", "Split", "Stand", "Start", "State", "Stick", "Study", "Teach", "Thank", "Think", "Throw", "Touch", "Train", "Treat", "Trust", "Visit", "Voice", "Waste", "Watch", "Worry", "Would", "Write", "Above", "Acute", "Alive", "Alone", "Angry", "Aware", "Awful", "Basic", "Black", "Blind", "Brave", "Brief", "Broad", "Brown", "Cheap", "Chief", "Civil", "Clean", "Clear", "Close", "Crazy", "Daily", "Dirty", "Early", "Empty", "Equal", "Exact", "Extra", "Faint", "False", "Fifth", "Final", "First", "Fresh", "Front", "Funny", "Giant", "Grand", "Great", "Green", "Gross", "Happy", "Harsh", "Heavy", "Human", "Ideal", "Inner", "Joint", "Large", "Legal", "Level", "Light", "Local", "Loose", "Lucky", "Magic", "Major", "Minor", "Moral", "Naked", "Nasty", "Naval", "Other", "Outer", "Plain", "Prime", "Prior", "Proud", "Quick", "Quiet", "Rapid", "Ready", "Right", "Roman", "Rough", "Round", "Royal", "Rural", "Sharp", "Sheer", "Short", "Silly", "Sixth", "Small", "Smart", "Solid", "Sorry", "Spare", "Steep", "Still", "Super", "Sweet", "Thick", "Third", "Tight", "Total", "Tough", "Upper", "Upset", "Urban", "Usual", "Vague", "Valid", "Vital", "White", "Whole", "Wrong", "Young", "Afore", "After", "Bothe", "Other", "Since", "Slash", "Until", "Where", "While", "Aback", "Abaft", "Aboon", "About", "Above", "Accel", "Adown", "Afoot", "Afore", "Afoul", "After", "Again", "Agape", "Agogo", "Agone", "Ahead", "Ahull", "Alife", "Alike", "Aline", "Aloft", "Alone", "Along", "Aloof", "Aloud", "Amiss", "Amply", "Amuck", "Apace", "Apart", "Aptly", "Arear", "Aside", "Askew", "Awful", "Badly", "Bally", "Below", "Canny", "Cheap", "Clean", "Clear", "Coyly", "Daily", "Dimly", "Dirty", "Ditto", "Drily", "Dryly", "Dully", "Early", "Extra", "False", "Fatly", "Feyly", "First", "Fitly", "Forte", "Forth", "Fresh", "Fully", "Funny", "Gaily", "Gayly", "Godly", "Great", "Haply", "Heavy", "Hella", "Hence", "Hotly", "Icily", "Infra", "Intl.", "Jildi", "Jolly", "Laxly", "Lento", "Light", "Lowly", "Madly", "Maybe", "Never", "Newly", "Nobly", "Oddly", "Often", "Other", "Ought", "Party", "Piano", "Plain", "Plonk", "Plumb", "Prior", "Queer", "Quick", "Quite", "Ramen", "Rapid", "Redly", "Right", "Rough", "Round", "Sadly", "Secus", "Selly", "Sharp", "Sheer", "Shily", "Short", };
        private static List<string> words_list = new List<string>(words_array);
        private static Random rnd = new Random();
        private static int r = rnd.Next(words_list.Count);
        //private static string word = words_list[r];
        private string secret_word = "GUESS";
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guess1_0 = new System.Windows.Forms.RichTextBox();
            this.guess1_1 = new System.Windows.Forms.RichTextBox();
            this.guess1_2 = new System.Windows.Forms.RichTextBox();
            this.guess1_3 = new System.Windows.Forms.RichTextBox();
            this.guess1_4 = new System.Windows.Forms.RichTextBox();
            this.guess2_4 = new System.Windows.Forms.RichTextBox();
            this.guess2_3 = new System.Windows.Forms.RichTextBox();
            this.guess2_2 = new System.Windows.Forms.RichTextBox();
            this.guess2_1 = new System.Windows.Forms.RichTextBox();
            this.guess2_0 = new System.Windows.Forms.RichTextBox();
            this.guess3_4 = new System.Windows.Forms.RichTextBox();
            this.guess3_3 = new System.Windows.Forms.RichTextBox();
            this.guess3_2 = new System.Windows.Forms.RichTextBox();
            this.guess3_1 = new System.Windows.Forms.RichTextBox();
            this.guess3_0 = new System.Windows.Forms.RichTextBox();
            this.guess4_4 = new System.Windows.Forms.RichTextBox();
            this.guess4_3 = new System.Windows.Forms.RichTextBox();
            this.guess4_2 = new System.Windows.Forms.RichTextBox();
            this.guess4_1 = new System.Windows.Forms.RichTextBox();
            this.guess4_0 = new System.Windows.Forms.RichTextBox();
            this.guess5_4 = new System.Windows.Forms.RichTextBox();
            this.guess5_3 = new System.Windows.Forms.RichTextBox();
            this.guess5_2 = new System.Windows.Forms.RichTextBox();
            this.guess5_1 = new System.Windows.Forms.RichTextBox();
            this.guess5_0 = new System.Windows.Forms.RichTextBox();
            this.guess6_4 = new System.Windows.Forms.RichTextBox();
            this.guess6_3 = new System.Windows.Forms.RichTextBox();
            this.guess6_2 = new System.Windows.Forms.RichTextBox();
            this.guess6_1 = new System.Windows.Forms.RichTextBox();
            this.guess6_0 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.alphaA = new System.Windows.Forms.Label();
            this.alphaB = new System.Windows.Forms.Label();
            this.alphaD = new System.Windows.Forms.Label();
            this.alphaC = new System.Windows.Forms.Label();
            this.alphaF = new System.Windows.Forms.Label();
            this.alphaE = new System.Windows.Forms.Label();
            this.alphaL = new System.Windows.Forms.Label();
            this.alphaK = new System.Windows.Forms.Label();
            this.alphaJ = new System.Windows.Forms.Label();
            this.alphaI = new System.Windows.Forms.Label();
            this.alphaH = new System.Windows.Forms.Label();
            this.alphaG = new System.Windows.Forms.Label();
            this.alphaT = new System.Windows.Forms.Label();
            this.alphaS = new System.Windows.Forms.Label();
            this.alphaR = new System.Windows.Forms.Label();
            this.alphaQ = new System.Windows.Forms.Label();
            this.alphaP = new System.Windows.Forms.Label();
            this.alphaO = new System.Windows.Forms.Label();
            this.alphaN = new System.Windows.Forms.Label();
            this.alphaM = new System.Windows.Forms.Label();
            this.alphaZ = new System.Windows.Forms.Label();
            this.alphaY = new System.Windows.Forms.Label();
            this.alphaX = new System.Windows.Forms.Label();
            this.alphaW = new System.Windows.Forms.Label();
            this.alphaV = new System.Windows.Forms.Label();
            this.alphaU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guess1_0
            // 
            this.guess1_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess1_0.DetectUrls = false;
            this.guess1_0.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess1_0.Location = new System.Drawing.Point(14, 12);
            this.guess1_0.MaxLength = 0;
            this.guess1_0.Multiline = false;
            this.guess1_0.Name = "guess1_0";
            this.guess1_0.Size = new System.Drawing.Size(81, 79);
            this.guess1_0.TabIndex = 0;
            this.guess1_0.Text = "";
            this.guess1_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess1_1
            // 
            this.guess1_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess1_1.DetectUrls = false;
            this.guess1_1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess1_1.Location = new System.Drawing.Point(101, 12);
            this.guess1_1.MaxLength = 0;
            this.guess1_1.Name = "guess1_1";
            this.guess1_1.Size = new System.Drawing.Size(81, 79);
            this.guess1_1.TabIndex = 1;
            this.guess1_1.Text = "";
            this.guess1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess1_2
            // 
            this.guess1_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess1_2.DetectUrls = false;
            this.guess1_2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess1_2.Location = new System.Drawing.Point(188, 12);
            this.guess1_2.MaxLength = 0;
            this.guess1_2.Name = "guess1_2";
            this.guess1_2.Size = new System.Drawing.Size(81, 79);
            this.guess1_2.TabIndex = 2;
            this.guess1_2.Text = "";
            this.guess1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess1_3
            // 
            this.guess1_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess1_3.DetectUrls = false;
            this.guess1_3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess1_3.Location = new System.Drawing.Point(275, 12);
            this.guess1_3.MaxLength = 0;
            this.guess1_3.Name = "guess1_3";
            this.guess1_3.Size = new System.Drawing.Size(81, 79);
            this.guess1_3.TabIndex = 3;
            this.guess1_3.Text = "";
            this.guess1_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess1_4
            // 
            this.guess1_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess1_4.DetectUrls = false;
            this.guess1_4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess1_4.Location = new System.Drawing.Point(362, 12);
            this.guess1_4.MaxLength = 0;
            this.guess1_4.Name = "guess1_4";
            this.guess1_4.Size = new System.Drawing.Size(81, 79);
            this.guess1_4.TabIndex = 4;
            this.guess1_4.Text = "";
            this.guess1_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess2_4
            // 
            this.guess2_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess2_4.DetectUrls = false;
            this.guess2_4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess2_4.Location = new System.Drawing.Point(362, 96);
            this.guess2_4.MaxLength = 0;
            this.guess2_4.Name = "guess2_4";
            this.guess2_4.Size = new System.Drawing.Size(81, 83);
            this.guess2_4.TabIndex = 9;
            this.guess2_4.Text = "";
            this.guess2_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess2_3
            // 
            this.guess2_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess2_3.DetectUrls = false;
            this.guess2_3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess2_3.Location = new System.Drawing.Point(275, 96);
            this.guess2_3.MaxLength = 0;
            this.guess2_3.Name = "guess2_3";
            this.guess2_3.Size = new System.Drawing.Size(81, 83);
            this.guess2_3.TabIndex = 8;
            this.guess2_3.Text = "";
            this.guess2_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess2_2
            // 
            this.guess2_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess2_2.DetectUrls = false;
            this.guess2_2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess2_2.Location = new System.Drawing.Point(188, 96);
            this.guess2_2.MaxLength = 0;
            this.guess2_2.Name = "guess2_2";
            this.guess2_2.Size = new System.Drawing.Size(81, 83);
            this.guess2_2.TabIndex = 7;
            this.guess2_2.Text = "";
            this.guess2_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess2_1
            // 
            this.guess2_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess2_1.DetectUrls = false;
            this.guess2_1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess2_1.Location = new System.Drawing.Point(101, 96);
            this.guess2_1.MaxLength = 0;
            this.guess2_1.Name = "guess2_1";
            this.guess2_1.Size = new System.Drawing.Size(81, 83);
            this.guess2_1.TabIndex = 6;
            this.guess2_1.Text = "";
            this.guess2_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess2_0
            // 
            this.guess2_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess2_0.DetectUrls = false;
            this.guess2_0.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess2_0.Location = new System.Drawing.Point(14, 96);
            this.guess2_0.MaxLength = 0;
            this.guess2_0.Name = "guess2_0";
            this.guess2_0.Size = new System.Drawing.Size(81, 83);
            this.guess2_0.TabIndex = 5;
            this.guess2_0.Text = "";
            this.guess2_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess3_4
            // 
            this.guess3_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess3_4.DetectUrls = false;
            this.guess3_4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess3_4.Location = new System.Drawing.Point(362, 181);
            this.guess3_4.MaxLength = 0;
            this.guess3_4.Name = "guess3_4";
            this.guess3_4.Size = new System.Drawing.Size(81, 83);
            this.guess3_4.TabIndex = 14;
            this.guess3_4.Text = "";
            this.guess3_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess3_3
            // 
            this.guess3_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess3_3.DetectUrls = false;
            this.guess3_3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess3_3.Location = new System.Drawing.Point(275, 181);
            this.guess3_3.MaxLength = 0;
            this.guess3_3.Name = "guess3_3";
            this.guess3_3.Size = new System.Drawing.Size(81, 83);
            this.guess3_3.TabIndex = 13;
            this.guess3_3.Text = "";
            this.guess3_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess3_2
            // 
            this.guess3_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess3_2.DetectUrls = false;
            this.guess3_2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess3_2.Location = new System.Drawing.Point(188, 181);
            this.guess3_2.MaxLength = 0;
            this.guess3_2.Name = "guess3_2";
            this.guess3_2.Size = new System.Drawing.Size(81, 83);
            this.guess3_2.TabIndex = 12;
            this.guess3_2.Text = "";
            this.guess3_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess3_1
            // 
            this.guess3_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess3_1.DetectUrls = false;
            this.guess3_1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess3_1.Location = new System.Drawing.Point(101, 181);
            this.guess3_1.MaxLength = 0;
            this.guess3_1.Name = "guess3_1";
            this.guess3_1.Size = new System.Drawing.Size(81, 83);
            this.guess3_1.TabIndex = 11;
            this.guess3_1.Text = "";
            this.guess3_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess3_0
            // 
            this.guess3_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess3_0.DetectUrls = false;
            this.guess3_0.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess3_0.Location = new System.Drawing.Point(14, 181);
            this.guess3_0.MaxLength = 0;
            this.guess3_0.Name = "guess3_0";
            this.guess3_0.Size = new System.Drawing.Size(81, 83);
            this.guess3_0.TabIndex = 10;
            this.guess3_0.Text = "";
            this.guess3_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess4_4
            // 
            this.guess4_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess4_4.DetectUrls = false;
            this.guess4_4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess4_4.Location = new System.Drawing.Point(362, 266);
            this.guess4_4.MaxLength = 0;
            this.guess4_4.Name = "guess4_4";
            this.guess4_4.Size = new System.Drawing.Size(81, 83);
            this.guess4_4.TabIndex = 19;
            this.guess4_4.Text = "";
            this.guess4_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess4_3
            // 
            this.guess4_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess4_3.DetectUrls = false;
            this.guess4_3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess4_3.Location = new System.Drawing.Point(275, 266);
            this.guess4_3.MaxLength = 0;
            this.guess4_3.Name = "guess4_3";
            this.guess4_3.Size = new System.Drawing.Size(81, 83);
            this.guess4_3.TabIndex = 18;
            this.guess4_3.Text = "";
            this.guess4_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess4_2
            // 
            this.guess4_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess4_2.DetectUrls = false;
            this.guess4_2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess4_2.Location = new System.Drawing.Point(188, 266);
            this.guess4_2.MaxLength = 0;
            this.guess4_2.Name = "guess4_2";
            this.guess4_2.Size = new System.Drawing.Size(81, 83);
            this.guess4_2.TabIndex = 17;
            this.guess4_2.Text = "";
            this.guess4_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess4_1
            // 
            this.guess4_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess4_1.DetectUrls = false;
            this.guess4_1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess4_1.Location = new System.Drawing.Point(101, 266);
            this.guess4_1.MaxLength = 0;
            this.guess4_1.Name = "guess4_1";
            this.guess4_1.Size = new System.Drawing.Size(81, 83);
            this.guess4_1.TabIndex = 16;
            this.guess4_1.Text = "";
            this.guess4_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess4_0
            // 
            this.guess4_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess4_0.DetectUrls = false;
            this.guess4_0.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess4_0.Location = new System.Drawing.Point(14, 266);
            this.guess4_0.MaxLength = 0;
            this.guess4_0.Name = "guess4_0";
            this.guess4_0.Size = new System.Drawing.Size(81, 83);
            this.guess4_0.TabIndex = 15;
            this.guess4_0.Text = "";
            this.guess4_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess5_4
            // 
            this.guess5_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess5_4.DetectUrls = false;
            this.guess5_4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess5_4.Location = new System.Drawing.Point(362, 351);
            this.guess5_4.MaxLength = 0;
            this.guess5_4.Name = "guess5_4";
            this.guess5_4.Size = new System.Drawing.Size(81, 83);
            this.guess5_4.TabIndex = 24;
            this.guess5_4.Text = "";
            this.guess5_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess5_3
            // 
            this.guess5_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess5_3.DetectUrls = false;
            this.guess5_3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess5_3.Location = new System.Drawing.Point(275, 351);
            this.guess5_3.MaxLength = 0;
            this.guess5_3.Name = "guess5_3";
            this.guess5_3.Size = new System.Drawing.Size(81, 83);
            this.guess5_3.TabIndex = 23;
            this.guess5_3.Text = "";
            this.guess5_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess5_2
            // 
            this.guess5_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess5_2.DetectUrls = false;
            this.guess5_2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess5_2.Location = new System.Drawing.Point(188, 351);
            this.guess5_2.MaxLength = 0;
            this.guess5_2.Name = "guess5_2";
            this.guess5_2.Size = new System.Drawing.Size(81, 83);
            this.guess5_2.TabIndex = 22;
            this.guess5_2.Text = "";
            this.guess5_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess5_1
            // 
            this.guess5_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess5_1.DetectUrls = false;
            this.guess5_1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess5_1.Location = new System.Drawing.Point(101, 351);
            this.guess5_1.MaxLength = 0;
            this.guess5_1.Name = "guess5_1";
            this.guess5_1.Size = new System.Drawing.Size(81, 83);
            this.guess5_1.TabIndex = 21;
            this.guess5_1.Text = "";
            this.guess5_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess5_0
            // 
            this.guess5_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess5_0.DetectUrls = false;
            this.guess5_0.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess5_0.Location = new System.Drawing.Point(14, 351);
            this.guess5_0.MaxLength = 0;
            this.guess5_0.Name = "guess5_0";
            this.guess5_0.Size = new System.Drawing.Size(81, 83);
            this.guess5_0.TabIndex = 20;
            this.guess5_0.Text = "";
            this.guess5_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess6_4
            // 
            this.guess6_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess6_4.DetectUrls = false;
            this.guess6_4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess6_4.Location = new System.Drawing.Point(362, 440);
            this.guess6_4.MaxLength = 0;
            this.guess6_4.Name = "guess6_4";
            this.guess6_4.Size = new System.Drawing.Size(81, 79);
            this.guess6_4.TabIndex = 29;
            this.guess6_4.Text = "";
            this.guess6_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess6_3
            // 
            this.guess6_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess6_3.DetectUrls = false;
            this.guess6_3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess6_3.Location = new System.Drawing.Point(275, 440);
            this.guess6_3.MaxLength = 0;
            this.guess6_3.Name = "guess6_3";
            this.guess6_3.Size = new System.Drawing.Size(81, 79);
            this.guess6_3.TabIndex = 28;
            this.guess6_3.Text = "";
            this.guess6_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess6_2
            // 
            this.guess6_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess6_2.DetectUrls = false;
            this.guess6_2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess6_2.Location = new System.Drawing.Point(188, 440);
            this.guess6_2.MaxLength = 0;
            this.guess6_2.Name = "guess6_2";
            this.guess6_2.Size = new System.Drawing.Size(81, 79);
            this.guess6_2.TabIndex = 27;
            this.guess6_2.Text = "";
            this.guess6_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess6_1
            // 
            this.guess6_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess6_1.DetectUrls = false;
            this.guess6_1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess6_1.Location = new System.Drawing.Point(101, 440);
            this.guess6_1.MaxLength = 0;
            this.guess6_1.Name = "guess6_1";
            this.guess6_1.Size = new System.Drawing.Size(81, 79);
            this.guess6_1.TabIndex = 26;
            this.guess6_1.Text = "";
            this.guess6_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess6_0
            // 
            this.guess6_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess6_0.DetectUrls = false;
            this.guess6_0.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess6_0.Location = new System.Drawing.Point(14, 440);
            this.guess6_0.MaxLength = 0;
            this.guess6_0.Name = "guess6_0";
            this.guess6_0.Size = new System.Drawing.Size(81, 79);
            this.guess6_0.TabIndex = 25;
            this.guess6_0.Text = "";
            this.guess6_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(115, 686);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 82);
            this.button1.TabIndex = 30;
            this.button1.Text = "Submit guess";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alphaA
            // 
            this.alphaA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaA.Location = new System.Drawing.Point(72, 556);
            this.alphaA.Name = "alphaA";
            this.alphaA.Size = new System.Drawing.Size(26, 28);
            this.alphaA.TabIndex = 31;
            this.alphaA.Text = "A";
            this.alphaA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaB
            // 
            this.alphaB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaB.Location = new System.Drawing.Point(104, 556);
            this.alphaB.Name = "alphaB";
            this.alphaB.Size = new System.Drawing.Size(26, 28);
            this.alphaB.TabIndex = 32;
            this.alphaB.Text = "B";
            this.alphaB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaD
            // 
            this.alphaD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaD.Location = new System.Drawing.Point(168, 556);
            this.alphaD.Name = "alphaD";
            this.alphaD.Size = new System.Drawing.Size(26, 28);
            this.alphaD.TabIndex = 34;
            this.alphaD.Text = "D";
            this.alphaD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaC
            // 
            this.alphaC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaC.Location = new System.Drawing.Point(136, 556);
            this.alphaC.Name = "alphaC";
            this.alphaC.Size = new System.Drawing.Size(26, 28);
            this.alphaC.TabIndex = 33;
            this.alphaC.Text = "C";
            this.alphaC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaF
            // 
            this.alphaF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaF.Location = new System.Drawing.Point(232, 556);
            this.alphaF.Name = "alphaF";
            this.alphaF.Size = new System.Drawing.Size(26, 28);
            this.alphaF.TabIndex = 36;
            this.alphaF.Text = "F";
            this.alphaF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaE
            // 
            this.alphaE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaE.Location = new System.Drawing.Point(200, 556);
            this.alphaE.Name = "alphaE";
            this.alphaE.Size = new System.Drawing.Size(26, 28);
            this.alphaE.TabIndex = 35;
            this.alphaE.Text = "E";
            this.alphaE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaL
            // 
            this.alphaL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaL.Location = new System.Drawing.Point(104, 593);
            this.alphaL.Name = "alphaL";
            this.alphaL.Size = new System.Drawing.Size(26, 28);
            this.alphaL.TabIndex = 42;
            this.alphaL.Text = "L";
            this.alphaL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaK
            // 
            this.alphaK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaK.Location = new System.Drawing.Point(72, 593);
            this.alphaK.Name = "alphaK";
            this.alphaK.Size = new System.Drawing.Size(26, 28);
            this.alphaK.TabIndex = 41;
            this.alphaK.Text = "K";
            this.alphaK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaJ
            // 
            this.alphaJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaJ.Location = new System.Drawing.Point(360, 556);
            this.alphaJ.Name = "alphaJ";
            this.alphaJ.Size = new System.Drawing.Size(26, 28);
            this.alphaJ.TabIndex = 40;
            this.alphaJ.Text = "J";
            this.alphaJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaI
            // 
            this.alphaI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaI.Location = new System.Drawing.Point(328, 556);
            this.alphaI.Name = "alphaI";
            this.alphaI.Size = new System.Drawing.Size(26, 28);
            this.alphaI.TabIndex = 39;
            this.alphaI.Text = "I";
            this.alphaI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaH
            // 
            this.alphaH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaH.Location = new System.Drawing.Point(296, 556);
            this.alphaH.Name = "alphaH";
            this.alphaH.Size = new System.Drawing.Size(26, 28);
            this.alphaH.TabIndex = 38;
            this.alphaH.Text = "H";
            this.alphaH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaG
            // 
            this.alphaG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaG.Location = new System.Drawing.Point(264, 556);
            this.alphaG.Name = "alphaG";
            this.alphaG.Size = new System.Drawing.Size(26, 28);
            this.alphaG.TabIndex = 37;
            this.alphaG.Text = "G";
            this.alphaG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaT
            // 
            this.alphaT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaT.Location = new System.Drawing.Point(360, 593);
            this.alphaT.Name = "alphaT";
            this.alphaT.Size = new System.Drawing.Size(26, 28);
            this.alphaT.TabIndex = 50;
            this.alphaT.Text = "T";
            this.alphaT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaS
            // 
            this.alphaS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaS.Location = new System.Drawing.Point(328, 593);
            this.alphaS.Name = "alphaS";
            this.alphaS.Size = new System.Drawing.Size(26, 28);
            this.alphaS.TabIndex = 49;
            this.alphaS.Text = "S";
            this.alphaS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaR
            // 
            this.alphaR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaR.Location = new System.Drawing.Point(296, 593);
            this.alphaR.Name = "alphaR";
            this.alphaR.Size = new System.Drawing.Size(26, 28);
            this.alphaR.TabIndex = 48;
            this.alphaR.Text = "R";
            this.alphaR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaQ
            // 
            this.alphaQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaQ.Location = new System.Drawing.Point(264, 593);
            this.alphaQ.Name = "alphaQ";
            this.alphaQ.Size = new System.Drawing.Size(26, 28);
            this.alphaQ.TabIndex = 47;
            this.alphaQ.Text = "Q";
            this.alphaQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaP
            // 
            this.alphaP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaP.Location = new System.Drawing.Point(232, 593);
            this.alphaP.Name = "alphaP";
            this.alphaP.Size = new System.Drawing.Size(26, 28);
            this.alphaP.TabIndex = 46;
            this.alphaP.Text = "P";
            this.alphaP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaO
            // 
            this.alphaO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaO.Location = new System.Drawing.Point(200, 593);
            this.alphaO.Name = "alphaO";
            this.alphaO.Size = new System.Drawing.Size(26, 28);
            this.alphaO.TabIndex = 45;
            this.alphaO.Text = "O";
            this.alphaO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaN
            // 
            this.alphaN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaN.Location = new System.Drawing.Point(168, 593);
            this.alphaN.Name = "alphaN";
            this.alphaN.Size = new System.Drawing.Size(26, 28);
            this.alphaN.TabIndex = 44;
            this.alphaN.Text = "N";
            this.alphaN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaM
            // 
            this.alphaM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaM.Location = new System.Drawing.Point(136, 593);
            this.alphaM.Name = "alphaM";
            this.alphaM.Size = new System.Drawing.Size(26, 28);
            this.alphaM.TabIndex = 43;
            this.alphaM.Text = "M";
            this.alphaM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaZ
            // 
            this.alphaZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaZ.Location = new System.Drawing.Point(296, 631);
            this.alphaZ.Name = "alphaZ";
            this.alphaZ.Size = new System.Drawing.Size(26, 28);
            this.alphaZ.TabIndex = 56;
            this.alphaZ.Text = "Z";
            this.alphaZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaY
            // 
            this.alphaY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaY.Location = new System.Drawing.Point(264, 631);
            this.alphaY.Name = "alphaY";
            this.alphaY.Size = new System.Drawing.Size(26, 28);
            this.alphaY.TabIndex = 55;
            this.alphaY.Text = "Y";
            this.alphaY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaX
            // 
            this.alphaX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaX.Location = new System.Drawing.Point(232, 631);
            this.alphaX.Name = "alphaX";
            this.alphaX.Size = new System.Drawing.Size(26, 28);
            this.alphaX.TabIndex = 54;
            this.alphaX.Text = "X";
            this.alphaX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaW
            // 
            this.alphaW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaW.Location = new System.Drawing.Point(200, 631);
            this.alphaW.Name = "alphaW";
            this.alphaW.Size = new System.Drawing.Size(26, 28);
            this.alphaW.TabIndex = 53;
            this.alphaW.Text = "W";
            this.alphaW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaV
            // 
            this.alphaV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaV.Location = new System.Drawing.Point(168, 631);
            this.alphaV.Name = "alphaV";
            this.alphaV.Size = new System.Drawing.Size(26, 28);
            this.alphaV.TabIndex = 52;
            this.alphaV.Text = "V";
            this.alphaV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaU
            // 
            this.alphaU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaU.Location = new System.Drawing.Point(136, 631);
            this.alphaU.Name = "alphaU";
            this.alphaU.Size = new System.Drawing.Size(26, 28);
            this.alphaU.TabIndex = 51;
            this.alphaU.Text = "U";
            this.alphaU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 826);
            this.Controls.Add(this.alphaZ);
            this.Controls.Add(this.alphaY);
            this.Controls.Add(this.alphaX);
            this.Controls.Add(this.alphaW);
            this.Controls.Add(this.alphaV);
            this.Controls.Add(this.alphaU);
            this.Controls.Add(this.alphaT);
            this.Controls.Add(this.alphaS);
            this.Controls.Add(this.alphaR);
            this.Controls.Add(this.alphaQ);
            this.Controls.Add(this.alphaP);
            this.Controls.Add(this.alphaO);
            this.Controls.Add(this.alphaN);
            this.Controls.Add(this.alphaM);
            this.Controls.Add(this.alphaL);
            this.Controls.Add(this.alphaK);
            this.Controls.Add(this.alphaJ);
            this.Controls.Add(this.alphaI);
            this.Controls.Add(this.alphaH);
            this.Controls.Add(this.alphaG);
            this.Controls.Add(this.alphaF);
            this.Controls.Add(this.alphaE);
            this.Controls.Add(this.alphaD);
            this.Controls.Add(this.alphaC);
            this.Controls.Add(this.alphaB);
            this.Controls.Add(this.alphaA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guess6_4);
            this.Controls.Add(this.guess6_3);
            this.Controls.Add(this.guess6_2);
            this.Controls.Add(this.guess6_1);
            this.Controls.Add(this.guess6_0);
            this.Controls.Add(this.guess5_4);
            this.Controls.Add(this.guess5_3);
            this.Controls.Add(this.guess5_2);
            this.Controls.Add(this.guess5_1);
            this.Controls.Add(this.guess5_0);
            this.Controls.Add(this.guess4_4);
            this.Controls.Add(this.guess4_3);
            this.Controls.Add(this.guess4_2);
            this.Controls.Add(this.guess4_1);
            this.Controls.Add(this.guess4_0);
            this.Controls.Add(this.guess3_4);
            this.Controls.Add(this.guess3_3);
            this.Controls.Add(this.guess3_2);
            this.Controls.Add(this.guess3_1);
            this.Controls.Add(this.guess3_0);
            this.Controls.Add(this.guess2_4);
            this.Controls.Add(this.guess2_3);
            this.Controls.Add(this.guess2_2);
            this.Controls.Add(this.guess2_1);
            this.Controls.Add(this.guess2_0);
            this.Controls.Add(this.guess1_4);
            this.Controls.Add(this.guess1_3);
            this.Controls.Add(this.guess1_2);
            this.Controls.Add(this.guess1_1);
            this.Controls.Add(this.guess1_0);
            this.Name = "Form1";
            this.Text = "Guess the Word";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox guess1_0;
        private System.Windows.Forms.RichTextBox guess1_1;
        private System.Windows.Forms.RichTextBox guess1_2;
        private System.Windows.Forms.RichTextBox guess1_3;
        private System.Windows.Forms.RichTextBox guess1_4;
        private System.Windows.Forms.RichTextBox guess2_4;
        private System.Windows.Forms.RichTextBox guess2_3;
        private System.Windows.Forms.RichTextBox guess2_2;
        private System.Windows.Forms.RichTextBox guess2_1;
        private System.Windows.Forms.RichTextBox guess2_0;
        private System.Windows.Forms.RichTextBox guess3_4;
        private System.Windows.Forms.RichTextBox guess3_3;
        private System.Windows.Forms.RichTextBox guess3_2;
        private System.Windows.Forms.RichTextBox guess3_1;
        private System.Windows.Forms.RichTextBox guess3_0;
        private System.Windows.Forms.RichTextBox guess4_4;
        private System.Windows.Forms.RichTextBox guess4_3;
        private System.Windows.Forms.RichTextBox guess4_2;
        private System.Windows.Forms.RichTextBox guess4_1;
        private System.Windows.Forms.RichTextBox guess4_0;
        private System.Windows.Forms.RichTextBox guess5_4;
        private System.Windows.Forms.RichTextBox guess5_3;
        private System.Windows.Forms.RichTextBox guess5_2;
        private System.Windows.Forms.RichTextBox guess5_1;
        private System.Windows.Forms.RichTextBox guess5_0;
        private System.Windows.Forms.RichTextBox guess6_4;
        private System.Windows.Forms.RichTextBox guess6_3;
        private System.Windows.Forms.RichTextBox guess6_2;
        private System.Windows.Forms.RichTextBox guess6_1;
        private System.Windows.Forms.RichTextBox guess6_0;
        private Button button1;
        private Label alphaA;
        private Label alphaB;
        private Label alphaD;
        private Label alphaC;
        private Label alphaF;
        private Label alphaE;
        private Label alphaL;
        private Label alphaK;
        private Label alphaJ;
        private Label alphaI;
        private Label alphaH;
        private Label alphaG;
        private Label alphaT;
        private Label alphaS;
        private Label alphaR;
        private Label alphaQ;
        private Label alphaP;
        private Label alphaO;
        private Label alphaN;
        private Label alphaM;
        private Label alphaZ;
        private Label alphaY;
        private Label alphaX;
        private Label alphaW;
        private Label alphaV;
        private Label alphaU;
        private RichTextBox[] guess1_letter_list;
        private RichTextBox[] guess2_letter_list;
        private RichTextBox[] guess3_letter_list;
        private RichTextBox[] guess4_letter_list;
        private RichTextBox[] guess5_letter_list;
        private RichTextBox[] guess6_letter_list;
    }
}


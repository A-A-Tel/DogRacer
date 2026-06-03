
namespace DogsAtTheRaces
{
    partial class BettingParlor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BettingParlor));
            pb_raceTrack = new PictureBox();
            pb_dog1 = new PictureBox();
            pb_dog2 = new PictureBox();
            pb_dog3 = new PictureBox();
            pb_dog4 = new PictureBox();
            gB_bettingParlor = new GroupBox();
            bt_race = new Button();
            lb_guy3BetLabel = new Label();
            lb_guy2BetLabel = new Label();
            lb_guy1BetLabel = new Label();
            label4 = new Label();
            num_dogNumber = new NumericUpDown();
            bt_bet = new Button();
            label2 = new Label();
            lb_name = new Label();
            lb_minimumBet = new Label();
            label1 = new Label();
            rb_Guy3 = new RadioButton();
            rb_Guy2 = new RadioButton();
            rb_Guy1 = new RadioButton();
            t_raceTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pb_raceTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_dog1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_dog2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_dog3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_dog4).BeginInit();
            gB_bettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_dogNumber).BeginInit();
            SuspendLayout();
            // 
            // pb_raceTrack
            // 
            pb_raceTrack.BackColor = SystemColors.Control;
            pb_raceTrack.BackgroundImage = (Image)resources.GetObject("pb_raceTrack.BackgroundImage");
            pb_raceTrack.BackgroundImageLayout = ImageLayout.Stretch;
            pb_raceTrack.InitialImage = null;
            pb_raceTrack.Location = new Point(12, 12);
            pb_raceTrack.Name = "pb_raceTrack";
            pb_raceTrack.Size = new Size(926, 337);
            pb_raceTrack.TabIndex = 0;
            pb_raceTrack.TabStop = false;
            // 
            // pb_dog1
            // 
            pb_dog1.BackgroundImage = (Image)resources.GetObject("pb_dog1.BackgroundImage");
            pb_dog1.BackgroundImageLayout = ImageLayout.Stretch;
            pb_dog1.Location = new Point(22, 23);
            pb_dog1.Name = "pb_dog1";
            pb_dog1.Size = new Size(128, 48);
            pb_dog1.TabIndex = 1;
            pb_dog1.TabStop = false;
            // 
            // pb_dog2
            // 
            pb_dog2.BackgroundImage = (Image)resources.GetObject("pb_dog2.BackgroundImage");
            pb_dog2.BackgroundImageLayout = ImageLayout.Stretch;
            pb_dog2.Location = new Point(22, 105);
            pb_dog2.Name = "pb_dog2";
            pb_dog2.Size = new Size(128, 48);
            pb_dog2.TabIndex = 2;
            pb_dog2.TabStop = false;
            // 
            // pb_dog3
            // 
            pb_dog3.BackgroundImage = (Image)resources.GetObject("pb_dog3.BackgroundImage");
            pb_dog3.BackgroundImageLayout = ImageLayout.Stretch;
            pb_dog3.Location = new Point(22, 196);
            pb_dog3.Name = "pb_dog3";
            pb_dog3.Size = new Size(128, 48);
            pb_dog3.TabIndex = 3;
            pb_dog3.TabStop = false;
            // 
            // pb_dog4
            // 
            pb_dog4.BackgroundImage = (Image)resources.GetObject("pb_dog4.BackgroundImage");
            pb_dog4.BackgroundImageLayout = ImageLayout.Stretch;
            pb_dog4.Location = new Point(22, 287);
            pb_dog4.Name = "pb_dog4";
            pb_dog4.Size = new Size(128, 48);
            pb_dog4.TabIndex = 4;
            pb_dog4.TabStop = false;
            // 
            // gB_bettingParlor
            // 
            gB_bettingParlor.Controls.Add(bt_race);
            gB_bettingParlor.Controls.Add(lb_guy3BetLabel);
            gB_bettingParlor.Controls.Add(lb_guy2BetLabel);
            gB_bettingParlor.Controls.Add(lb_guy1BetLabel);
            gB_bettingParlor.Controls.Add(label4);
            gB_bettingParlor.Controls.Add(num_dogNumber);
            gB_bettingParlor.Controls.Add(bt_bet);
            gB_bettingParlor.Controls.Add(label2);
            gB_bettingParlor.Controls.Add(lb_name);
            gB_bettingParlor.Controls.Add(lb_minimumBet);
            gB_bettingParlor.Controls.Add(label1);
            gB_bettingParlor.Controls.Add(rb_Guy3);
            gB_bettingParlor.Controls.Add(rb_Guy2);
            gB_bettingParlor.Controls.Add(rb_Guy1);
            gB_bettingParlor.Location = new Point(12, 355);
            gB_bettingParlor.Name = "gB_bettingParlor";
            gB_bettingParlor.Size = new Size(926, 223);
            gB_bettingParlor.TabIndex = 5;
            gB_bettingParlor.TabStop = false;
            gB_bettingParlor.Text = "Betting Parlor";
            // 
            // bt_race
            // 
            bt_race.Location = new Point(719, 27);
            bt_race.Name = "bt_race";
            bt_race.Size = new Size(190, 180);
            bt_race.TabIndex = 14;
            bt_race.Text = "Race!";
            bt_race.UseVisualStyleBackColor = true;
            bt_race.Click += bt_race_Click;
            // 
            // lb_guy3BetLabel
            // 
            lb_guy3BetLabel.AutoSize = true;
            lb_guy3BetLabel.Location = new Point(373, 127);
            lb_guy3BetLabel.Name = "lb_guy3BetLabel";
            lb_guy3BetLabel.Size = new Size(178, 25);
            lb_guy3BetLabel.TabIndex = 13;
            lb_guy3BetLabel.Text = "<<guy 3 bet label>>";
            // 
            // lb_guy2BetLabel
            // 
            lb_guy2BetLabel.AutoSize = true;
            lb_guy2BetLabel.Location = new Point(373, 92);
            lb_guy2BetLabel.Name = "lb_guy2BetLabel";
            lb_guy2BetLabel.Size = new Size(178, 25);
            lb_guy2BetLabel.TabIndex = 12;
            lb_guy2BetLabel.Text = "<<guy 2 bet label>>";
            // 
            // lb_guy1BetLabel
            // 
            lb_guy1BetLabel.AutoSize = true;
            lb_guy1BetLabel.Location = new Point(373, 57);
            lb_guy1BetLabel.Name = "lb_guy1BetLabel";
            lb_guy1BetLabel.Size = new Size(178, 25);
            lb_guy1BetLabel.TabIndex = 11;
            lb_guy1BetLabel.Text = "<<guy 1 bet label>>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(373, 27);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 10;
            label4.Text = "Bets";
            // 
            // num_dogNumber
            // 
            num_dogNumber.Location = new Point(373, 164);
            num_dogNumber.Name = "num_dogNumber";
            num_dogNumber.Size = new Size(59, 31);
            num_dogNumber.TabIndex = 8;
            // 
            // bt_bet
            // 
            bt_bet.Location = new Point(109, 161);
            bt_bet.Name = "bt_bet";
            bt_bet.Size = new Size(63, 34);
            bt_bet.TabIndex = 7;
            bt_bet.Text = "Bets";
            bt_bet.UseVisualStyleBackColor = true;
            bt_bet.Click += bt_bet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 166);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 6;
            label2.Text = "bucks on dog number: ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(10, 166);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(104, 25);
            lb_name.TabIndex = 5;
            lb_name.Text = "<<name>>";
            // 
            // lb_minimumBet
            // 
            lb_minimumBet.AutoSize = true;
            lb_minimumBet.Location = new Point(138, 27);
            lb_minimumBet.Name = "lb_minimumBet";
            lb_minimumBet.Size = new Size(167, 25);
            lb_minimumBet.TabIndex = 4;
            lb_minimumBet.Text = "<<minimum bet>>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 3;
            label1.Text = "Minimum bet: ";
            // 
            // rb_Guy3
            // 
            rb_Guy3.AutoSize = true;
            rb_Guy3.Location = new Point(10, 125);
            rb_Guy3.Name = "rb_Guy3";
            rb_Guy3.Size = new Size(141, 29);
            rb_Guy3.TabIndex = 2;
            rb_Guy3.TabStop = true;
            rb_Guy3.Text = "radioButton3";
            rb_Guy3.UseVisualStyleBackColor = true;
            // 
            // rb_Guy2
            // 
            rb_Guy2.AutoSize = true;
            rb_Guy2.Location = new Point(10, 90);
            rb_Guy2.Name = "rb_Guy2";
            rb_Guy2.Size = new Size(141, 29);
            rb_Guy2.TabIndex = 1;
            rb_Guy2.TabStop = true;
            rb_Guy2.Text = "radioButton2";
            rb_Guy2.UseVisualStyleBackColor = true;
            // 
            // rb_Guy1
            // 
            rb_Guy1.AutoSize = true;
            rb_Guy1.Location = new Point(10, 55);
            rb_Guy1.Name = "rb_Guy1";
            rb_Guy1.Size = new Size(141, 29);
            rb_Guy1.TabIndex = 0;
            rb_Guy1.TabStop = true;
            rb_Guy1.Text = "radioButton1";
            rb_Guy1.UseVisualStyleBackColor = true;
            // 
            // t_raceTimer
            // 
            t_raceTimer.Tick += t_raceTimer_Tick;
            // 
            // BettingParlor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 590);
            Controls.Add(gB_bettingParlor);
            Controls.Add(pb_dog4);
            Controls.Add(pb_dog3);
            Controls.Add(pb_dog2);
            Controls.Add(pb_dog1);
            Controls.Add(pb_raceTrack);
            Name = "BettingParlor";
            Text = "Betting Parlor";
            ((System.ComponentModel.ISupportInitialize)pb_raceTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_dog1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_dog2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_dog3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_dog4).EndInit();
            gB_bettingParlor.ResumeLayout(false);
            gB_bettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_dogNumber).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private PictureBox pb_raceTrack;
        private PictureBox pb_dog1;
        private PictureBox pb_dog2;
        private PictureBox pb_dog3;
        private PictureBox pb_dog4;
        private GroupBox gB_bettingParlor;
        private Label lb_name;
        private Label lb_minimumBet;
        private Label label1;
        private RadioButton rb_Guy3;
        private RadioButton rb_Guy2;
        private RadioButton rb_Guy1;
        private NumericUpDown num_dogNumber;
        private Button bt_bet;
        private Label label2;
        private Label lb_guy3BetLabel;
        private Label lb_guy2BetLabel;
        private Label lb_guy1BetLabel;
        private Label label4;
        private Button bt_race;
        private System.Windows.Forms.Timer t_raceTimer;
    }
}

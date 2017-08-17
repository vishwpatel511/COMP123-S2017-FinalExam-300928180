using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_300928180
{

    /*
     * Name: Vishw Patel
     * Date: August 17, 2017
     * StudentID: 300928180
     * Description: This is the ScorBoard class for pickHighestCard class.
     * Version 0.1 : ScoreBoard class created.
     */
    public class ScoreBoard
    {
        //PRIVATE INSTANCE VARIABLES
        private TextBox _finalScoreTextBox;

        private int _score;

        private TextBox _scoreTextBox;

        private int _time;

        private TextBox _timeTextBox;

        //PUBLIC PROPERTIES

        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }

        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
                //this._score = int.Parse(ScoreTextBox.Text);
                //this._score = int.Parse(FinalScoreTextBox.Text);
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = Convert.ToInt16(this.TimeTextBox);

            }
        }

        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }

        //CONSTRUCTOR
        /// <summary>
        /// This is the main constructor for the ScoreBoard Class.
        /// It takes three parameter - scoreTextBox (TextBox), timeTextBox (TextBox) , finalScoreTextBox (TextBox).
        /// </summary>
        /// <param name="scoreTextBox"></param>
        /// <param name="timeTextBox"></param>
        /// <param name="finalScoreTextBox"></param>
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {

        }

        // PUBLIC METHODS

        /// <summary>
        /// This method updates the TimeTextBox value.
        /// </summary>
        public void UpdateTime()
        {

            this.Time = ((int.Parse(this.TimeTextBox.Text)) - 1);
            this.TimeTextBox.Text = Convert.ToString(this.Time);
        }
    }
}

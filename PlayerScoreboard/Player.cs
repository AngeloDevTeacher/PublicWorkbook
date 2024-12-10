using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerScoreboard
{
    internal class Player
    {
        // Fields
        string _firstName;
        string _lastName;
        int _playCount;
        double _lifetimeScore;
        // Properties
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _firstName = value.Trim();
                }
                else
                {
                    throw new Exception("First name cannot be null or empty");
                }
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _lastName = value.Trim();
                }
                else
                {
                    throw new Exception("Last name cannot be null or empty");
                }
            }
        }

        public int PlayCount
        {
            get
            {
                return _playCount;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("PlayCount must be 0 or greater");
                }
                else
                {
                    _playCount = value;
                }
            }
        }

        public double LifetimeScore
        {
            get
            {
                return _lifetimeScore;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("HighScore must be 0 or greater");
                }
                else
                {
                    _lifetimeScore = value;
                }
            }
        }

        public double AverageScore
        {
            get
            {
                return _lifetimeScore / PlayCount;
            }
        }

        public string PlayerLevel
        {
            get
            {
                string output = "";
                if (_playCount < 10)
                {
                    output = "Bronze";
                }
                else if (_playCount < 49)
                {
                    output = "Silver";
                }
                else
                {
                    output = "Gold";
                }
                return output;
            }
        }

        public string FullName
        {
            get
            {
                return $"{_lastName},{_firstName}";
            }
        }

        public override string ToString()
        {
            return $"{_lastName},{_firstName},{_playCount},{_lifetimeScore}";
        }
        // Constructors

        /// <summary>
        /// Creates the player object.
        /// </summary>
        /// <param name="first">The first name of the player.</param>
        /// <param name="last">The last name of the player.</param>
        /// <param name="plays">The player's lifetime plays.</param>
        /// <param name="score">The player's lifetime score.</param>
        public Player(string first, string last, int plays, double score)
        {
            FirstName = first;
            LastName = last;
            PlayCount = plays;
            LifetimeScore = score;
        }

        // Methods

    }
}

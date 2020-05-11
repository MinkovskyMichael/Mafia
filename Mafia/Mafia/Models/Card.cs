using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mafia.Models
{
    public class Card
    {
        string cardImgName;
        string cardName;
        string playerName;

        public string CardImgName
        {
            get
            {
                return cardImgName;
            }

            set
            {
                cardImgName = value;
            }
        }

        public string CardName
        {
            get
            {
                return cardName;
            }

            set
            {
                cardName = value;
            }
        }

        public string PlayerName
        {
            get
            {
                return playerName;
            }

            set
            {
                playerName = value;
            }
        }

        public Card (string cardName, string cardImgName)
        {
            CardImgName = cardImgName;
            CardName = cardName;
        }

        public Card(string cardName, string cardImgName, string playerName)
        {
            CardImgName = cardImgName;
            CardName = cardName;
            PlayerName = playerName;
        }
    }
}
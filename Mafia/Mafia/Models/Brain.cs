using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mafia.Models
{
    public class Brain
    {
        //просто добавь героев сюда
        public static readonly string[] cardName = { "Шериф", "Доктор", "Мафия", "Мирный Житель" };
        private static Random rng = new Random();
        public static readonly string[] cardImg
            = { "cop", "doc", "host", "inocent", "inocent1", "inocent2", "mafia", "manyak", "prostitude" };

        //build a deck

        public List<Card> BuildDeck (int numUsers, bool doc, bool sherif, bool prostitute, List<string> users)
        {
            List<Card> newDeck = new List<Card>();
         
            int remainder;
            int mafiaCount = Math.DivRem(numUsers, 4, out remainder);

            AddMafiaToTheDeck(mafiaCount, newDeck);

            if(sherif == true)newDeck.Add(new Card("Доктор", "doc"));
            if(doc==true)newDeck.Add(new Card("Шериф", "cop"));
            if (prostitute == true) newDeck.Add(new Card("Проститутка", "prostituте"));

            int counter = numUsers - newDeck.Count;
            for (int i = 0; i < counter; i++)
            {
                if(i % 2 == 0 && i!=  counter-1 && i != counter-2)
                {
                    newDeck.Add(new Card("Мирный Житель", "inocent1"));
                }
                else if (i % 2 != 0 && i != counter - 1 && i != counter - 2)
                {
                    newDeck.Add(new Card("Мирный Житель", "inocent2"));
                }
                else { newDeck.Add(new Card("Мирный Житель", "inocent")); }
            }

            List<Card> shuffledDeck = ShuffledDeck(newDeck);

            AddUsers(shuffledDeck, users);
            return shuffledDeck;
            }

        private void AddMafiaToTheDeck(int numMafia, List<Card> newDeck)
        {
            for (int i = 0; i < numMafia; i++)
            {
                newDeck.Add(new Card("Мафия", "mafia"));
            }
            
        }

        private List<Card> ShuffledDeck(List<Card> fullDeck)
        {   
            int n = fullDeck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card card = fullDeck[k];
                fullDeck[k] = fullDeck[n];
                fullDeck[n] = card;
            }
            return fullDeck;
        }

        private void AddUsers(List<Card> shuffledDeck, List<string> users)
        {
            for (int i = 0; i < shuffledDeck.Count; i++)
            {
                shuffledDeck[i].PlayerName = users[i];
            }
        }
    }
}
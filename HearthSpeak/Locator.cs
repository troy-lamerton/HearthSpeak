﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthSpeak
{
    class Locator
    {

        private LogFileParser parser;
        private int CreatureSep;
        public Locator(LogFileParser parser)
        {
            this.parser = parser;
            CreatureSep = 100;
        }

        public int[] EndTurnButton()
        {
            return new int[] { 1112, 347 };
        }

        public int[] PlayButton()
        {
            return new int[] { 660, 240 };
        }

        public int[] SoloAdventuresButton()
        {
            return new int[] { 660, 290 };
        }

        public int[] BackButton()
        {
            return new int[] { 1125, 706 };
        }

        public int[] CardInHand(int cardNum)
        {
            int xpos = -1;
            int ypos = 721;
            cardNum--;
            switch (parser.FriendlyHandCount)
            {
                case 1:
                    xpos = 650;
                    break;
                case 2:
                    xpos = 650 + cardNum * 100;
                    break;
                case 3:
                    xpos = 530 + cardNum * 120;
                    break;
                case 4:
                    xpos = 452 + cardNum * 105;
                    break;
                case 5:
                    xpos = 450 + cardNum * 100;
                    break;
                case 6:
                    xpos = 435 + cardNum * 75;
                    break;
                case 7:
                    xpos = 429 + cardNum * 68;
                    break;
                case 8:
                    xpos = 425 + cardNum * 58;
                    break;
                case 9:
                    xpos = 420 + cardNum * 50;
                    break;
                case 10:
                    xpos = 420 + cardNum * 44;
                    ypos = 740;
                    break;
            }
            return new int[] { xpos, ypos };
        }

        public int[] FriendlyBoard(int pos)
        {
            int ypos = 420;
            return new int[] { CreateXPos(pos, parser.FriendlyPlayCount), ypos };
        }

        public int[] OpposingBoard(int pos)
        {
            int ypos = 250;
            return new int[] { CreateXPos(pos, parser.OpposingPlayCount), ypos };
        }
        
        private int CreateXPos(int pos, int cardCount)
        {
            pos--;
            int firstLeft = 693 - 49 * cardCount;
            int xpos = firstLeft + pos * CreatureSep;
            return xpos;
        }

        public int[] FriendlyPortrait()
        {
            return new int[] { 690, 585 };
        }

        public int[] OpposingPortrait()
        {
            return new int[] { 690, 150 };
        }

        public int[] HeroPower()
        {
            return new int[] { 815, 580 };
        }

        public int[] Mulligan(string word)
        {
            int ypos = 350;
            var mulliganPositions = new Dictionary<string, int[]> {
                ["1"] = new int[] { 450, ypos },
                ["2"] = new int[] { 630, ypos },
                ["3"] = new int[] { 850, ypos },
                ["4"] = new int[] { 965, ypos },
                ["confirm"] = new int[] { 680, 600 }
            };
            return mulliganPositions[word];
        }

        public int[] ConcedeButton()
        {
            return new int[] { 684, 281 };
        }

        public int[] BlueButton()
        {
            return new int[] { 986, 631 };
        }
        

        public int[] MyCollectionButton()
        {
            return new int[] { 750, 650 };
        }


        public int[] GameCancelButton()
        {
            return new int[] { 700, 645 };
        }

        public int[] Emote(string words)
        {
            var emoteMap = new Dictionary<string, int[]>
            {
                ["thank you"] = new int[] { 575, 475 },
                ["sorry"] = new int[] { 800, 475 },
                ["well played"] = new int[] { 575, 541 },
                ["good game"] = new int[] { 575, 541 },
                ["oops"] = new int[] { 800, 541 },
                ["greetings"] = new int[] { 575, 611 },
                ["threaten"] = new int[] { 800, 611 },

            };
            return emoteMap[words];
        }

        public int[] Deck(int deckNum)
        {
            var deckMap = new Dictionary<int, int[]>
            {
                [1] = new int[] { 350, 215 },
                [2] = new int[] { 500, 215 },
                [3] = new int[] { 650, 215 },
                [4] = new int[] { 350, 380 },
                [5] = new int[] { 500, 380 },
                [6] = new int[] { 650, 380 },
                [7] = new int[] { 350, 540 },
                [8] = new int[] { 500, 540 },
                [9] = new int[] { 650, 540 },

            };
            return deckMap[deckNum];
        }

        public int[] FaceCard(int cardNum)
        {
            int xpos = 300;
            int ypos = 383;
            cardNum--;
            switch (parser.SetAsideCount)
            {
                case 1:
                    xpos = 650;
                    break;
                case 3:
                    xpos = 400 + 300 * cardNum;
                    break;
            }
            return new int[] { xpos, ypos };
        }


    }
}
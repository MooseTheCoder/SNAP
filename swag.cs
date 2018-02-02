 static void Main(string[] args)
        {  
            bool stack = false;
            string[] suits = { "hearts", "spades", "diamonds" , "clubs" };
            while (stack == false) {
                for(int suitNum = 0; suitNum < suits.Length; suitNum++)
                {
                    string suitName = suits[suitNum];
                 
                    Console.WriteLine(suitName);
                    for (int cardNum = 0; cardNum < 14; cardNum++) {
                        string resource = "";
                        string cardName = "";
                        if (cardNum == 1) {
                            cardName = "ace";
                        }
                        if (cardNum != 1) {
                            cardName = "_"+cardNum+"_of_"+suitName;
                        }
                        resource = cardName;
                        Bitmap cardBitmap = (Bitmap)Properties.Resources.ResourceManager.GetObject(resource);
                        cards.Add(cardBitmap);
                        numbers.Add(cardNum);
                        Console.WriteLine(cardName);
                    }
                }
                stack = true;
            }
            Console.ReadLine();
        }
    }

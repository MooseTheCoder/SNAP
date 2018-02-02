 static void Main(string[] args)
        {  
            bool stack = false;
            while (stack == false) {
                for(int suitNum = 0; suitNum < 4; suitNum++)
                {
                    string suitName = "";
                    switch (suitNum) {
                        case 1:
                            suitName = "hearts";
                            break;
                        case 2:
                            suitName = "spades";
                            break;
                        case 3:
                            suitName = "diamonds";
                            break;
                        case 4:
                            suitName = "clubs";
                            break;
                    }
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
                        Console.WriteLine(cardName);
                    }
                }
                stack = true;
            }
            Console.ReadLine();
        }
    }

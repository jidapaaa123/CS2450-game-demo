public class Maps
{
    public static List<string[]> Home(int movementTime)
    {
        // First move = player at 39th index of the line
        int playerColumn = 39 + movementTime;
        int playerRow = 11;

        List<char[]> toDisplay = new();
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("..........................／l、.......................".ToCharArray());
        toDisplay.Add("........................（ﾟ､ ｡７......................".ToCharArray());
        toDisplay.Add("..........................l、ﾞ~ヽ.....................".ToCharArray());
        toDisplay.Add("..........................じしf_, )ノ.................".ToCharArray());
        toDisplay.Add("..........................◢■■■■■◣.....................".ToCharArray());
        toDisplay.Add("..............................*.......................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());


        List<string[]> lines = new();
        for (int i = 0; i < toDisplay.Count; i++)
        {
            char[] line = toDisplay[i];
            string[] stringArray = new string[line.Length];

            for (int j = 0; j < line.Length; j++)
            {
                if (i == playerRow && j == playerColumn)
                {
                    stringArray[j] = "O";
                }
                else if (line[j] == '.')
                {
                    stringArray[j] = " ".ToString();
                }
                else
                {
                    stringArray[j] = line[j].ToString();
                }
            }

            lines.Add(stringArray);
        }

        return lines;
    }

        public static List<string[]> HomeBackward(int movementTime)
    {
        // First move = player at 39th index of the line
        int playerColumn = 50 - movementTime;
        int playerRow = 11;

        List<char[]> toDisplay = new();
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("..........................／l、.......................".ToCharArray());
        toDisplay.Add("........................（ﾟ､ ｡７......................".ToCharArray());
        toDisplay.Add("..........................l、ﾞ~ヽ.....................".ToCharArray());
        toDisplay.Add("..........................じしf_, )ノ.................".ToCharArray());
        toDisplay.Add("..........................◢■■■■■◣.....................".ToCharArray());
        toDisplay.Add("..............................*.......................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());


        List<string[]> lines = new();
        for (int i = 0; i < toDisplay.Count; i++)
        {
            char[] line = toDisplay[i];
            string[] stringArray = new string[line.Length];

            for (int j = 0; j < line.Length; j++)
            {
                if (i == playerRow && j == playerColumn)
                {
                    stringArray[j] = "O";
                }
                else if (line[j] == '.')
                {
                    stringArray[j] = " ".ToString();
                }
                else
                {
                    stringArray[j] = line[j].ToString();
                }
            }

            lines.Add(stringArray);
        }

        return lines;
    }

    public static List<string[]> RanchForward(int movementTime)
    {
        // First move = player just arrived at the map Row 11 Column 0
        int playerColumn = 0 + movementTime;
        int playerRow = 11;

        List<char[]> toDisplay = new();
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("..................................................V...".ToCharArray());
        toDisplay.Add("..................M...................................".ToCharArray());
        toDisplay.Add("............V.........................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add(".......................E..............................".ToCharArray());
        toDisplay.Add("..................................................E...".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("...........................................V..........".ToCharArray());
        toDisplay.Add(".........EVMV.........................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("............E.........................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add(".......................V..............................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......V...............................................".ToCharArray());
        toDisplay.Add("..................................................V...".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());


        List<string[]> lines = new();

        for (int i = 0; i < toDisplay.Count; i++)
        {
            char[] line = toDisplay[i];
            string[] stringArray = new string[line.Length];

            for (int j = 0; j < line.Length; j++)
            {
                if (i == playerRow && j == playerColumn)
                {
                    stringArray[j] = "O";
                }
                else if (line[j] == '.')
                {
                    stringArray[j] = " ".ToString();
                }
                else
                {
                    stringArray[j] = line[j].ToString();
                }
            }

            // fix collected items display
            if (playerColumn >= 9)
            {
                int collectedItems = playerColumn - 9;

                for (int k = 1; k <= collectedItems; k++)
                {
                    stringArray[playerColumn - k] = " ";
                }
            }

            lines.Add(stringArray);
        }

        return lines;
    }

        public static List<string[]> RanchBackward(int movementTime)
    {
        // First move = player just arrived at the map Row 11 Column 0
        int playerColumn = 12 - movementTime;
        int playerRow = 11;

        List<char[]> toDisplay = new();
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("..................................................V...".ToCharArray());
        toDisplay.Add("..................M...................................".ToCharArray());
        toDisplay.Add("............V.........................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add(".......................E..............................".ToCharArray());
        toDisplay.Add("..................................................E...".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("...........................................V..........".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("............E.........................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add(".......................V..............................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());
        toDisplay.Add("......V...............................................".ToCharArray());
        toDisplay.Add("..................................................V...".ToCharArray());
        toDisplay.Add("......................................................".ToCharArray());


        List<string[]> lines = new();

        for (int i = 0; i < toDisplay.Count; i++)
        {
            char[] line = toDisplay[i];
            string[] stringArray = new string[line.Length];

            for (int j = 0; j < line.Length; j++)
            {
                if (i == playerRow && j == playerColumn)
                {
                    stringArray[j] = "O";
                }
                else if (line[j] == '.')
                {
                    stringArray[j] = " ".ToString();
                }
                else
                {
                    stringArray[j] = line[j].ToString();
                }
            }

            lines.Add(stringArray);
        }

        return lines;
    }

}
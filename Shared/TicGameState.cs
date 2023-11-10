namespace MaxsGameCorner.Shared;

public class TicGameState
{
    public string CalculateWinner(string[] squares)
    {
        int[][] lines = new int[][]
        {
            new int[] {0, 1, 2},
            new int[] {3, 4, 5},
            new int[] {6, 7, 8},
            new int[] {0, 3, 6},
            new int[] {1, 4, 7},
            new int[] {2, 5, 8},
            new int[] {0, 4, 8},
            new int[] {2, 4, 6}
        };

        foreach (var line in lines)
        {
            int a = line[0];
            int b = line[1];
            int c = line[2];

            if (!string.IsNullOrEmpty(squares[a]) && squares[a] == squares[b] && squares[a] == squares[c])
            {
                return squares[a];
            }
        }

        return "";
    }
}
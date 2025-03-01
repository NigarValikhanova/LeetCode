public class Solution79 {
    public bool Exist(char[][] board, string word) {
        int m = board.Length;
        int n = board[0].Length;

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (Backtrack(board, word, i, j, 0)) {
                    return true;
                }
            }
        }
        return false;
    }

    private bool Backtrack(char[][] board, string word, int i, int j, int index) {
        if (index == word.Length) return true; // Found the word
        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[index]) {
            return false;
        }

        char temp = board[i][j];
        board[i][j] = '#'; // Mark as visited

        bool found = Backtrack(board, word, i + 1, j, index + 1) ||
                     Backtrack(board, word, i - 1, j, index + 1) ||
                     Backtrack(board, word, i, j + 1, index + 1) ||
                     Backtrack(board, word, i, j - 1, index + 1);

        board[i][j] = temp; // Restore the original value
        return found;
    }
}

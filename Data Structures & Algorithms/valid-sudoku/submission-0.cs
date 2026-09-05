public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[i].Length; j++) {
                if (board[i][j] != '.') {
                    char result = board[i][j];
                    int boxIdx = (i / 3) * 3 + (j / 3);
                    if (rows[i].Contains(result) || cols[j].Contains(result) || boxes[boxIdx].Contains(result)) {
                        return false;
                    }
                    rows[i].Add(result);
                    cols[j].Add(result);
                    boxes[boxIdx].Add(result);
                }
            }
        }
        return true;
    }
}
#include <iostream>
#include <vector>
#include <string>
#include <tuple>

using namespace std;

string can_capture(const vector<vector<char>>& board, const vector<tuple<int, int>>& pieces, char opponent) {
    int rows = board.size();
    int cols = board[0].size();
    int directions[4][2] = {{1, 1}, {1, -1}, {-1, 1}, {-1, -1}};

    for (const auto& piece : pieces) {
        int row = get<0>(piece);
        int col = get<1>(piece);

        for (const auto& dir : directions) {
            int dr = dir[0];
            int dc = dir[1];

            if (row + dr >= 0 && row + dr < rows && col + dc >= 0 && col + dc < cols) {
                if (board[row + dr][col + dc] == opponent &&
                    row + 2 * dr >= 0 && row + 2 * dr < rows &&
                    col + 2 * dc >= 0 && col + 2 * dc < cols &&
                    board[row + 2 * dr][col + 2 * dc] == '.') {
                    return "Yes";
                }
            }
        }
    }
    return "No";
}

vector<tuple<int, int>> arrange_pieces(vector<vector<char>>& board, int count, char color) {
    vector<tuple<int, int>> pieces;
    for (int _ = 0; _ < count; ++_) {
        int i, j;
        cin >> i >> j;
        board[i - 1][j - 1] = color;
        pieces.emplace_back(i - 1, j - 1);
    }
    return pieces;
}

int main() {
    int n, m;
    cin >> n >> m;
    vector<vector<char>> board(n, vector<char>(m, '.'));

    int w;
    cin >> w;
    vector<tuple<int, int>> w_pieces = arrange_pieces(board, w, 'w');

    int b;
    cin >> b;
    vector<tuple<int, int>> b_pieces = arrange_pieces(board, b, 'b');

    string player;
    cin >> player;

    if (player == "white") {
        cout << can_capture(board, w_pieces, 'b') << endl;
    } else {
        cout << can_capture(board, b_pieces, 'w') << endl;
    }

    return 0;
}
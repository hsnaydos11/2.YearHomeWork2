#include "Header.h"


int sparseMatrixGeneration() {
    int sparseMatrix[5][6] = {
                {0 , 0 , 0 , 0 , 9, 0 },
        {0 , 8 , 0 , 0 , 0, 0 },
        {4 , 0 , 0 , 2 , 0, 0 },
        {0 , 0 , 0 , 0 , 0, 5 },
        {0 , 0 , 2 , 0 , 0, 0 }
    };
    // Finding total non-zero values in the sparse matrix
    int size = 0;
    for (int row = 0; row < 5; row++)
        for (int column = 0; column < 6; column++)
            if (sparseMatrix[row][column] != 0)
                size++;
    int* resultMatrix[3];
    for (int i = 0; i < 3; i++) {
        resultMatrix[i] = (int*)malloc(size * sizeof(int));
    }
    int k = 0;

    //to generate result matrix
    for (int row = 0; row < 5; row++) {
        for (int column = 0; column < 6; column++) {
            if (sparseMatrix[row][column] != 0) {
                resultMatrix[0][k] = row;
                resultMatrix[1][k] = column;
                resultMatrix[2][k] = sparseMatrix[row][column];
                k++;
            }
        }
    }
    // Displaying result matrix
    cout << "Triplet Representation : " << endl;
    for (int row = 0; row < 3; row++)
    {
        for (int column = 0; column < size; column++)
            cout << resultMatrix[row][column] << " ";

        cout << endl;
    }
    return 0;
}
//to add items to col, row and value
void insertCopy(int r, int c, int val)
{
    datacopy[len][0] = r;  //to add item for row

    datacopy[len][1] = c;  //to add item for column

    datacopy[len][2] = val;  //to add result for value

    // increment number of data in matrix
    len++;
}

//to print result of sparse matrix to normal matrix
int PrintCopySpareToMatrix() {
    cout << "\nDimension of Sparse Matrix: "
        << len << " x " << 3;
    cout << "\nSparse Matrix: \nRow Column Value\n";

    for (int i = 0; i < len; i++) {

        cout << datacopy[i][0] << " "
            << datacopy[i][1] << " "
            << datacopy[i][2] << "\n";
    }
    return 0;
}
class sparse_matrixAdd
{

    // Maximum number of elements in matrix
    const static int MAX = 100;

    //Double pointer defined to store triple dara
    int** data;

    // dimensions of matrix
    int row, col;

    // total number of elements in matrix
    int len;

public:
    sparse_matrixAdd(int r, int c)
    {

        // initialize row
        row = r;

        // initialize col
        col = c;

        // initialize length to 0
        len = 0;

        //Array of Pointer to make a matrix
        data = new int* [MAX];

        // Array representation
        // of sparse matrix
        //[,0] represents row
        //[,1] represents col
        //[,2] represents value
        for (int i = 0; i < MAX; i++)
            data[i] = new int[3];
    }
    // insert elements into sparse matrix
    void insert(int r, int c, int val)
    {

        //when entered unsuitable matrix, to encounter 
        if (r > row || c > col)
        {

        }
        else
        {

            // insert row value
            data[len][0] = r;

            // insert col value
            data[len][1] = c;

            // insert element's value
            data[len][2] = val;

            // increment number of data in matrix
            len++;
        }
    }

    void add(sparse_matrixAdd b)
    {

        if (row != b.row || col != b.col)          //to throw an error if the matrices are not suitable for insertion
        {
            cout << "Matrices can't be added";
        }

        else
        {
            int apos = 0, bpos = 0;
            sparse_matrixAdd result(row, col);

            while (apos < len && bpos < b.len)
            {

                // if b's row and col is smaller
                if (data[apos][0] > b.data[bpos][0] ||
                    (data[apos][0] == b.data[bpos][0] &&
                        data[apos][1] > b.data[bpos][1]))

                {

                    // insert smaller value into result
                    result.insert(b.data[bpos][0],
                        b.data[bpos][1],
                        b.data[bpos][2]);

                    bpos++;
                }

                // if a's row and col is smaller
                else if (data[apos][0] < b.data[bpos][0] ||
                    (data[apos][0] == b.data[bpos][0] &&
                        data[apos][1] < b.data[bpos][1]))

                {

                    // insert smaller value into result
                    result.insert(data[apos][0],
                        data[apos][1],
                        data[apos][2]);

                    apos++;
                }

                else
                {
                    // add the values as row and col is same
                    int addedval = data[apos][2] +
                        b.data[bpos][2];

                    if (addedval != 0)
                        result.insert(data[apos][0],
                            data[apos][1],
                            addedval);
                    // then insert
                    apos++;
                    bpos++;
                }
            }

            // insert remaining elements
            while (apos < len)
                result.insert(data[apos][0],
                    data[apos][1],
                    data[apos++][2]);

            while (bpos < b.len)
                result.insert(b.data[bpos][0],
                    b.data[bpos][1],
                    b.data[bpos++][2]);

            // print result
            result.print();
        }
    }
    void print()
    {
        //to print result all matrix
        cout << "\nDimension: " << row << "x" << col;
        cout << "\nSparse Matrix: \nRow\tColumn\tValue\n";

        for (int i = 0; i < len; i++)
        {
            cout << data[i][0] << "\t " << data[i][1]
                << "\t " << data[i][2] << endl;
        }
    }
};


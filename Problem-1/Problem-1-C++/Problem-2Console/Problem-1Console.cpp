#include "..\Problem-1\Header.h"
#include "../Problem-1/Problem-1SparseLib.cpp"

int main()
{
	int choice;
	sparse_matrixAdd a(4, 4);
	sparse_matrixAdd b(4, 4);
	int r = 5, c = 6;
	int sparseMatrix[5][6] = {
	{0 , 0 , 0 , 0 , 9, 0 },
	{0 , 8 , 0 , 0 , 0, 0 },
	{4 , 0 , 0 , 2 , 0, 0 },
	{0 , 0 , 0 , 0 , 0, 5 },
	{0 , 0 , 2 , 0 , 0, 0 }
	};
	printf("\n\n****** MENU ******\n1. Generation\n2. Access\n3. Addition\n4. Deletion\n5. Copy\n6. Measure\n");
	scanf_s("%d", &choice);
	switch (choice) {
	case 1:
		sparseMatrixGeneration();
		break;
	case 2:
		break;
	case 3:
		a.insert(0, 4, 9);
		a.insert(1, 1, 8);
		a.insert(2, 0, 4);
		a.insert(2, 3, 2);
		a.insert(3, 5, 5);
		a.insert(4, 2, 2);
		b.insert(0, 3, 5);
		b.insert(1, 4, 23);
		b.insert(2, 3, 9);
		b.insert(3, 1, 20);
		b.insert(4, 2, 25);
		cout << "\nAddition: ";
		a.add(b);
		break;
	case 4:
		break;
	case 5:
		// print the matrix
		cout << "\nMatrix:\n";
		for (int i = 0; i < r; i++) {
			for (int j = 0; j < c; j++) {
				cout << sparseMatrix[i][j] << " ";
			}
			cout << endl;
		}

		//to iterate through the matrix and add every non-0 value to the result 
		for (int i = 0; i < r; i++)
			for (int j = 0; j < c; j++)
				if (sparseMatrix[i][j] > 0)
					insertCopy(i, j, sparseMatrix[i][j]);

		// Print the Sparse Matrix
		PrintCopySpareToMatrix();
		break;
	case 6:
		break;
	case 7:
		break;
	}
	return 0;
}


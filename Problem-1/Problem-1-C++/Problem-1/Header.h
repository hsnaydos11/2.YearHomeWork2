#pragma once
#define CRT_SECURE_NO_WARNINGS
#define MAXCOPY 100
#include <stdio.h>
#include <iostream>
using namespace std;

int sparseMatrixGeneration();
int datacopy[MAXCOPY][3];
int len;
void insertCopy(int r, int c, int val);
int PrintCopySpareToMatrix();
class sparse_matrixAdd;


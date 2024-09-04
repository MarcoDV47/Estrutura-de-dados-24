﻿// JaggedArray é também conhecido como um 
// vetor de vetores

int[][] numbers = new int[4][];

// Neste caso [][] indica que é um vetor de vetor.
// Neste exemplo, um vetor de 4 posições contendo vetores
// de tamanho indefinido

numbers[0] = new int[] { 1, 2, 3 };
numbers[1] = new int[] { 4, 3, 2, 1, 0 };
numbers[2] = new int[] { 1, 2, 0 };
numbers[3] = new int[] { 57 };
numbers[4] = null!;
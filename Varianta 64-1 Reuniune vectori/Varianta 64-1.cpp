
#include "stdafx.h"
#include <iostream>

using namespace std;

void Afisare_vector_reuniune(int vec1[], int vec2[], int vec3[], int max, int maxr);
int main()
{
	const int max1 = 3;
	const int max2 = 3;
	const int max3 = 6;
	int v1[max1], v2[max2], v3[max3], i;
	//Introducem elemente vector 1
	for (i = 1; i <= max1; i++)
	{
		cout << "Introduceti elementele vectorului 1:";
		cin >> v1[i];
	}
	//Introducem elemente vector 2
	for (i = 1; i <= max2; i++)
	{
		cout << "Introduceti elementele vectorului 2:";
		cin >> v2[i];
	}
	//Afisam elemente vector 1
	cout << "\tValorile din primul vector sunt: ";
	for (i = 1; i <= max1; i++)
	{
		cout << v1[i] << ";";
	}
	//Afisam elemente vector 2
	cout << "\n\tValorile din al doilea vector sunt: ";
	for (i = 1; i <= max2; i++)
	{
		cout << v2[i] << ";";
	}
	Afisare_vector_reuniune(v1, v2, v3, max1, max3);
	cin.ignore();
	cin.get();
	return 0;
}
void Afisare_vector_reuniune(int vec1[], int vec2[], int vec3[], int max, int maxr)
{
	int i = 1;
	max = 3;
	maxr = 6;
	cout << "\n\tValorile din al treilea vector sunt: ";
	for (i = 1; i <= max; i++)
	{
		vec3[i] = vec1[i];
		vec3[i + max] = vec2[i];
	}
	for (i = 1; i <= sizeof(vec3)+2; i++)
	{
		cout << vec3[i] << ";";
	}
}


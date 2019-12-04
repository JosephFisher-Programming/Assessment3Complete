#include <iostream>

int sum(int * numbers, size_t length) 
{
	int total = 0;

	for (int i = 0; i < length; i++) 
	{
		total += numbers[i];
	}

	return total;
}

int * zeroArray(size_t length) 
{
	int * arr = new int[length];

	for (size_t i = 0; i < length; i++) 
	{
		arr[i] = 0;
	}

	return arr;
}
int main() 
{
	//  pointer syntax

	int walletCount = 10;
	int  * wallets = new int[walletCount];
	int wallets[10];

	wallets[0] = 5;
	wallets[1] = 2;
	wallets[2] = 7;
	wallets[3] = 0;
	wallets[4] = 8;
	wallets[5] = 75;
	wallets[6] = 30;
	wallets[7] = 132;
	wallets[8] = 0;
	wallets[9] = 0;

	int * noWallets = zeroArray(1000);

	int total = sum(wallets, walletCount);

	delete[] wallets;
	delete[] noWallets;

	int * something = nullptr;
	int * other = something;
	*something = 55;
	delete something;
	something = nullptr;

	if (other != nullptr)
	{
		std::cout << *other << std::endl;
	}
	else
	{
		std::cout << "Something was null! :( a bruh moment" << std::endl;
	}

	return 0;
}
//  Main.cpp

#include <iostream>
#include "Utils.h"

//  Declare and Define sum.
int sum(int a, int b) 
{
	return a + b;
}


//  Declare sub.
int sub(int a, int b);

int main() 
{
	//  Call sum function.
	std::cout << sum(5, 7) << std::endl;

	//  Call sub function.
	std::cout << sub(10, 5) << std::endl;

	//  Call mul function.
	std::cout << mul(5, 7) << std::endl;

	//  Call div function.
	std::cout << division(10, 5) << std::endl;

	while (true) {}

	return 0;
}

//  Declare and Define sub.
int sub(int a, int b) 
{
	return a - b;
}
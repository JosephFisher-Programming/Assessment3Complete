#include <iostream>

int main() 
{
	//  Variables Tutorial.

	std::cout << "My" << " Height" << " -" << "\n" << "Yall Height" << " -";

	int age = -1;
	std::cout << "\n" << "What is your age?" << std::endl;
	std::cin >> age;
	std::cout << "Wow, you're at the ripe old age of " << age << std::endl;

	while (true) {}

	return 0;

	// First Evercise.

	int numberA = 5;

	numberA = 9;
	numberA = 11;
	numberA = 14;

	std::cout << "A) " << numberA << std::endl;
	//  Second Exercise.

	int numberB = 10;
	numberB = 9;

	int thingB = 55;
	thingB = 22;

	std::cout << "B) " << numberB << std::endl;

	//  Third Exercise.

	int numberC = 3;
	numberC = 7;
	numberC = 1;

	int somethingC = 23;
	somethingC = 21;

	numberC = somethingC;

	std::cout << "C) " << numberC << std::endl;

	// Fourth Exercise.

	int numberD = 1;
	int somethingD = 3;

	numberD = somethingD;

	std::cout << "D) " << somethingD << std::endl;

	// Fifth Exercise.

	int x = 13;

	x = x / 2;

	std::cout << "E) " << x << std::endl;

	//  Sixth Exercise.

	float y = 13;

	y = y / 2;

	std::cout << "F) " << y << std::endl;

	//  Area of Rectangle Exercise.

	float rectWidth = 0.0f;
	float rectHeight = 0.0f;
	float rectArea = 0.0f;

	std::cout << "What is the rectangle's Width?" << std::endl;
	std::cin >> rectWidth;
	std::cout << "What is the rectangle's Height?" << std::endl;
	std::cin >> rectHeight;
	rectArea = rectWidth * rectHeight;

	std::cout << "Area of a Rectangle)" << std::endl;
	std::cout << "H: " << rectHeight << " , W: " << rectWidth << std::endl;
	std::cout << "Area: " << rectArea << std::endl;

	//  Average of Five Exercise.

	float a, b, c, d, e;
	float avg;
	avg = a = b = c = d = e = 0.0f;

	std::cout << "What is your first number?" << std::endl;
	std::cin >> a;
	std::cout << "What is your second number?" << std::endl;
	std::cin >> b;
	std::cout << "What is your third number?" << std::endl;
	std::cin >> c;
	std::cout << "What is your fourth number?" << std::endl;
	std::cin >> d;
	std::cout << "What is your fifth number?" << std::endl;
	std::cin >> e;
	avg = (a + b + c + d + e) / 5;

	std::cout << "Average of Five)" << std::endl;
	std::cout << a << ", " << b << ", " << c << ", " << d << ", " << e << std::endl;
	std::cout << "avg: " << avg << std::endl;

	//  Number Swapping Exercise.

	int x1 = 13;
	int y1 = 24;

	std::cout << "What is your X Value?" << std::endl;
	std::cin >> x1;
	std::cout << "What is your Y Value?" << std::endl;
	std::cin >> y1;

	int tempValStorage = x1;
	x1 = y1;
	y1 = tempValStorage;

	std::cout << "Number Swap)" << std::endl;
	std::cout << "x is " << x1 << std::endl;
	std::cout << "y is " << y1 << std::endl;

	// Fun fact for age.

	int age1 = -1;

	std::cout << "What is your age?" << std::endl;
	std::cin >> age1;

	std::cout << "Wow you really are old! You are " << age1 << " afterall!" << std::endl;
	std::cout << "If you lived in Japan then you have " << 84 - age1 << " years left to live!" << std::endl;

	//  Challenge Exercise.

	bool validNum = false;
	int bigBoiNum = 0;
	
	while (validNum == false) 
	{
		std::cout << "GIVE ME A NUMBER" << std::endl;
		std::cin >> bigBoiNum;
		if (bigBoiNum != NULL)
		{
			std::cout << "Your number is " << bigBoiNum << std::endl;
			break;
		}
		else
		{
			if (std::cin.fail()) 
			{
				std::cin.clear();
				std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
			}
			std::cout << "INVALID VALUE" << std::endl;
			
		}
	}

	while (true) {}
}
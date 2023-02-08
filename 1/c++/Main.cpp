#include <iostream>
#include "TCyllinder.cpp"
using namespace std;

int main(){
	TCircle ball1 = TCircle();
	TCircle ball2 = TCircle(3);
	TCircle ball3 = TCircle(ball2);
	
	std::cout << "ball2 area: " << ball2.getArea() << "\n";
	std::cout << "ball1 > ball3: " << ball1.isBiggerThan(ball3) << "\n";
	ball1.incRad(10);
	std::cout << "ball1 > ball3: " << ball1.isBiggerThan(ball3) << "\n";
	
	std::cout << "-------------------" << "\n";
	
	TCyllinder cyll1 = TCyllinder(3, 5);
	TCyllinder cyll2 = TCyllinder(cyll1);
	std::cout << "cyll1 area: " << cyll1.getArea() << "\n";
	std::cout << "cyll1 volume: " << cyll1.getVolume() << "\n";
	std::cout << "cyll2 volume: " << cyll2.getVolume();
	cyll2.mulRad(2);
	std::cout << "cyll2 volume: " << cyll2.getVolume() << "\n";
}
//https://www.onlinegdb.com/online_c++_compiler
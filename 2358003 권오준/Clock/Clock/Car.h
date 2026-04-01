#include <iostream> // 입출력 스트림 라이브러리
class Car {
protected:
	int 	speed; 			// 속도 (private)
	char	name[40]; 		// 이름 (private)
public:
	int 	gear; 			// 기어 (public)
	Car() {}				// 수정 / 기본 생성자
	~Car() {}				// 생성자와 소멸자
	Car(int s, char* n, int g) // 매개변수 있는 생성자
		: speed(s), gear(g)	   // 초기화 리스트
	{
		strcpy_s(name, n); // 이름 복사 (문자열 복사 함수)
	}
	void changeGear(int g = 4) // 기어 변경 함수 (기본값 4단)
	{
		gear = g; // 기어 변경
	}
	void speedUp() // 가속 함수
	{
		speed += 5; // 속도 증가 (기본적으로 5씩 증가)
	}
	void display() // 자동차 상태 출력 함수
	{
		printf("[%s] : 기어= %d단 속도=%dkmph\n", name, gear, speed); // 자동차 이름, 기어, 속도 출력
	}
	void whereAmI() // 객체 주소를 알려주는 함수
	{ 
		printf("객체 주소 = %p\n", this); // this는 내 객체의 주소 
	}
};
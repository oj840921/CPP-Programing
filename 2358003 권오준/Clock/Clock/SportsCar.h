#include "Car.h"			// 자동차 클래스 헤더파일 포함
// 스포츠카 클래스 (자식 클래스) : 자동차 클래스에 터보 기능 추가
class SportsCar : public Car // Car 클래스에서 상속받음
{
public: // public 접근 지정자
	bool bTurbo;		// 터보 장치 사용 여부
	SportsCar(int s, char* n, int g) : Car(s, n, g), bTurbo(true) {} // 매개변수 있는 생성자
	void setTurbo(bool bTur) { bTurbo = bTur; } // 터보 장치 사용 여부 설정
	void speedUp() {		// 터보가 On이 되어 있으면 가속이 빨리됨
		if (bTurbo) speed += 20; // 터보가 켜져 있으면 20씩 가속
		else Car::speedUp(); // 터보가 꺼져 있으면 부모 클래스의 speedUp() 함수 호출
	}
};

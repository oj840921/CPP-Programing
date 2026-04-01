#include "SportsCar.h" // 스포츠카 클래스 헤더파일 포함
int main()
{
	char carName[40] = "내차";			// 차 이름 문자열

	SportsCar myCar(0, carName, 4);		// SportsCar형 객체 생성
	printf("튜닝 이전 차\n");			// 튜닝 이전 차 상태 출력
	myCar.display();					// 차 상태 출력
	myCar.whereAmI();					// 객체 주소 출력

	myCar.changeGear(10);				// 기어 변경
	myCar.speedUp();					// 가속 (터보가 켜져 있으면 20씩 가속)
	printf("튜닝 이후 차\n");			// 튜닝 이후 차 상태 출력
	myCar.display(); 					// 차 상태 출력		
	myCar.whereAmI(); 					// 객체 주소 출력 (튜닝 이후에도 객체 주소는 동일)

	return 0;							// 프로그램 종료
}
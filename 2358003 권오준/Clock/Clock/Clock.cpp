#include <cstdio> // C 헤더 파일 <stdio.h>을 포함하는 것과 동일
#include <cstdlib> // C 헤더 파일 <stdlib.h>을 포함하는 것과 동일
#include <ctime> // C 헤더 파일 <time.h>을 포함하는 것과 동일

int main(void)
{
	clock_t start, finish;
	double duration;
	start = clock();
	// 실행 시간을 측정하고자 하는 코드
	for (int i = 1; i < 1000; i++)
	//
	finish = clock();
	duration = (double)(finish - start) / CLOCKS_PER_SEC;
	printf("%f 초입니다.\n", duration);
	return 0;
}
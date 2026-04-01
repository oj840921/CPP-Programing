void copy_array(int a[], int b[], int len) {
	int i;
	for (i = 0; i < len; i++)
		b[i] = a[i];
}
void copy_variable(int a, int b) {
	b = a;
}
int main()
{
	int A[5] = { 10, 20, 30 };
	int B[5], i, x = 2018, y = 0;
	copy_variable(x, y); //Call by value
	copy_array(A, B, 5); //배열의 이름이 배열의 주소값, 주소값이 복사
}
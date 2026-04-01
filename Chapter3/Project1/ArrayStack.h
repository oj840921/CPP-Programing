#pragma once
const int MAX_SIZE = 100; // Maximum size of the stack
class ArrayStack
{
private:
	int top;
	int data[MAX_SIZE]; // Fixed size stack of 100 elements
public:
	ArrayStack();
	~ArrayStack();
	void push(int value);
	int pop();
	int peek();
	bool isEmpty();
	bool isFull();
	void display(); 
};
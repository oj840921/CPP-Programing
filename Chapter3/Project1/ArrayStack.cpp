#include "ArrayStack.h"
#include <iostream>
using namespace std;

	ArrayStack::ArrayStack() 
	{
		top = -1; // Initialize top to -1 to indicate an empty stack
	}
	ArrayStack::~ArrayStack() 
	{
		// Destructor (not needed for this implementation, but included for completeness)
	}
	bool ArrayStack::isEmpty() 
	{
		return top == -1; // Stack is empty if top is -1
	}
	bool ArrayStack::isFull() 
	{
		return top == MAX_SIZE-1; // Stack is full if top is 99 (since we have a fixed size of 100)
	}
	void ArrayStack::push(int value) 
	{
		if (isFull()) 
		{
			cout << "Stack overflow! Cannot push " << value << endl;
			return;
		}
		data[++top] = value; // Increment top and add the value to the stack
	}
	int ArrayStack::pop() 
	{
		if (isEmpty()) 
		{
			cout << "Stack underflow! Cannot pop from an empty stack." << endl;
			
		}
		return data[top--]; // Return the top element and then decrement top to remove it from the stack
		top--; // Decrement top to remove the top element
	}
	int ArrayStack::peek() 
	{
		if (isEmpty()) 
		{
			cout << "Stack is empty! Cannot peek." << endl;
			return -1; // Return -1 to indicate an error
		}
		return data[top]; // Return the top element without removing it
	}
	void ArrayStack::display() 
	{
		if (isEmpty()) 
		{
			cout << "Stack is empty! Nothing to display." << endl;
			return;
		}
		cout << "Stack elements: ";
		for (int i = top; i >= 0; i--) 
		{
			cout << data[i] << " ";
		}
		cout << endl;
	}

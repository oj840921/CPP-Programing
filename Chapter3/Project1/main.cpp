#include "ArrayStack.h"
#include <iostream>

int main(void) {
	ArrayStack stack;
	for (int i = 1; i < 10; i++)
		stack.push(i);
	stack.display();
	stack.pop();
	stack.pop();
	stack.pop();
	stack.display();
	return 0;
}

/*
ArrayStack stack;
    // Push some elements onto the stack
    stack.push(10);
    stack.push(20);
    stack.push(30);
    // Display the top element
    std::cout << "Top element: " << stack.peek() << std::endl;
    // Pop an element from the stack
    int value = stack.pop();
    std::cout << "Top element after pop: " << stack.peek() << std::endl;
    // Check if the stack is empty
    std::cout << "Is the stack empty? " << (stack.isEmpty() ? "Yes" : "No") << std::endl;
    return 0;
*/
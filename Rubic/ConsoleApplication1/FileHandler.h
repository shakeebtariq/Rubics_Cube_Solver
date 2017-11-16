#pragma once
#ifndef FILE_HANDLER_H_
#define FILE_HANDLER_H_

#include<fstream>
#include"Moves.h"

//derived class
class FileHandler :public Moves
{
private:

	string addressOfInput;
	string addressOfOutput;
protected:
	void writter_(node *);
public:
	FileHandler();
	void eraseText(char);
	void reader();
	/*void writeArrayToFile();*/
	void displayArray();
	~FileHandler();
};

#endif
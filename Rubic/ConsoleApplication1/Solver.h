#pragma once
#ifndef SOLVER_H_
#define SOLVER_H_

#include"FileHandler.h"

class Solver : public FileHandler
{
public:
	//Constructor
	Solver();
	//Solve First Layer part 1
	void SFL1();
	//Display Moves
	void displayMoves();
	//Solve First Layer part 2
	void SFL2();
	//Solve First Layer part 3
	void SFL3();
	//Solve second layer
	void SSL();
	//solve third layer part 1
	void STL1();
	//solve third layer part 2
	void STL2();
	//Write Moves
	void writter();
	//Final step
	void FinalStep();
	//Check for Solved Cube
	bool CFSC();//return true for solved cube
	//destructor
	~Solver();
};

#endif
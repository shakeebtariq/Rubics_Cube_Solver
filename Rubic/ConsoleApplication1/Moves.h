#pragma once
#ifndef MOVES_H_
#define MOVES_H_

#include<iostream>
#include<string>
#include<fstream>

using namespace std;
struct node{
	char data;
	node*next;
};
//base class
class Moves
{
protected:

	int arr[54];

	//right clockwise
	void RC();
	//right anti-clockwise
	void RA();

	//left clockwise
	void LC();
	//left anti-clockwise
	void LA();

	//up clockwise
	void UC();
	//up anti-clockwise
	void UA();

	//down clockwise
	void DC();
	//down anti-clockwise
	void DA();

	//up clockwise
	void FC();
	//up anti-clockwise
	void FA();

	//down clockwise
	void BC();
	//down anti-clockwise
	void BA();

	//middle clockwise
	void MC();
	//middle anti-clockwise
	void MA();

	//equator clockwise
	void EC();
	//equator anti-clockwise
	void EA();

	//standing clockwise
	void SC();
	//standing anti-clockwise
	void SA();

	//Move All to right
	void AR();
	//Move All to left
	void AL();
	//Move All Up
	void AU();
	//Move All Down
	void AD();

public:
	Moves();
	//Initializing List
	node *head, *cur;
	~Moves();

};

#endif
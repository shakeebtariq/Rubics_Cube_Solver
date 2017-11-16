#include"Solver.h"
void main()
{
	Solver x;
	x.reader();
	if (x.CFSC() == true)
	{
		system("CLS");
		cout << "Cube is Already Solved!" << endl;
		x.writter();
		return;

	}
	else if (x.CFSC() != true)
	{
		//x.displayArray();
		x.SFL1();
		x.SFL2();
		x.SFL3();
		//solve second layer
		x.SSL();
		//solve Third Layer
		x.STL1();
		x.STL2();
		x.FinalStep();
		//x.displayArray();
		//x.displayMoves();
		//system("pause");
		cout << "Wait until this window Vanishes." << endl;
		if (x.CFSC() == true)
		{
			
		}
		else
		{
			cout << "Sorry! cann't solve such formation    :(" << endl;
		}
		cout << "Writing to file..." << endl;
		x.writter();
		system("CLS");
		//x.writeArrayToFile();
		//system("pause");
	}
}
#include"Solver.h"
//Constructor
Solver::Solver() 
{
	head = new node;
	cur = new node;
	cur->next = NULL;
	cur->data = 'x';//Random No.
	head = cur;
}
void Solver::SFL1()
{
	//4 No. shows that color is yellow
	if (arr[5 - 1] == 4)
	{
		SC();
	}
	else if (arr[14 - 1] == 4)
	{
		MC();
	}
	else if (arr[23 - 1] == 4)
	{
		SA();
	}
	else if (arr[32 - 1] == 4)
	{
		MA();
	}
	else if (arr[50 - 1] == 4)
	{
		MC();
		MC();
	}
	while (true)
	{
		
		if (arr[38 - 1] == 5 && arr[40 - 1] == 5 && arr[42 - 1] == 5 && arr[44 - 1] == 5)
			break;
		if (arr[42 - 1] != 5)
		{
		}
		else if (arr[44 - 1] != 5)
			UA();
		else if (arr[38 - 1] != 5)
			UC();
		else if (arr[40 - 1] != 5)
		{
			UC();
			UC();
		}
		if (arr[11 - 1] == 5 || arr[17 - 1] == 5 || arr[13 - 1] == 5 || arr[15 - 1] == 5)
		{
			if (arr[11 - 1] == 5)
			{
				FC();
				RC();
			}
			if (arr[15 - 1] == 5)
			{
				RC();
			}
			if (arr[17 - 1] == 5)
			{
				FA();
				RC();
			}
			if (arr[13 - 1] == 5)
			{
				FC();
				FC();
				RC();
			}
		}
		else if (arr[2 - 1] == 5 || arr[4 - 1] == 5 || arr[6 - 1] == 5 || arr[8 - 1] == 5)
		{
			if (arr[2 - 1] == 5)
			{
				LC();
				EA();
				LC();
			}
			else
			{
				EA();
				DA();
				if (arr[15 - 1] == 5)
				{
					RC();
				}
				else if (arr[17 - 1] == 5)
				{
					FA();
					RC();
				}
				else if (arr[13 - 1] == 5)
				{
					FC();
					FC();
					RC();
				}
			}
		}
		else if (arr[20 - 1] == 5 || arr[22 - 1] == 5 || arr[24 - 1] == 5 || arr[26 - 1] == 5)
		{
			if (arr[20 - 1] == 5)
			{
				RC();
				EC();
				RC();
			}
			else
			{
				EC();
				DC();
				if (arr[15 - 1] == 5)
				{
					RC();
				}
				else if (arr[17 - 1] == 5)
				{
					FA();
					RC();
				}
				else if (arr[13 - 1] == 5)
				{
					FC();
					FC();
					RC();
				}
			}
		}
		else if (arr[29 - 1] == 5 || arr[31 - 1] == 5 || arr[33 - 1] == 5 || arr[35 - 1] == 5)
		{
			if (arr[29 - 1] == 5)
			{
				BA();
				EC();
				BA();
			}
			else
			{
				EC();
				EC();
				DC();
				DC();
				if (arr[15 - 1] == 5)
				{
					RC();
				}
				else if (arr[17 - 1] == 5)
				{
					FA();
					RC();
				}
				else if (arr[13 - 1] == 5)
				{
					FC();
					FC();
					RC();
				}
			}
		}
		else if (arr[47 - 1] == 5 || arr[49 - 1] == 5 || arr[51 - 1] == 5 || arr[53 - 1] == 5)
		{
			if (arr[47 - 1] == 5)
			{
				DA();
				RC();
				RC();
			}
			else if (arr[51 - 1] == 5)
			{
				RC();
				RC();
			}
			else if (arr[53 - 1] == 5)
			{
				DA();
				RC();
				RC();
			}
			else if (arr[49 - 1] == 5)
			{
				DA();
				DA();
				RC();
				RC();
			}
		}
	}

}
void Solver::SFL2()
{
	//making white cross across white centre
	int countarr[4] = { 0, 0, 0, 0 };
	while (1)
	{
		if (countarr[0] == 1 && countarr[1] == 1 && countarr[2] == 1 && countarr[3] == 1)
		{
			AU();
			AU();
			break;
		}
		if (arr[5 - 1] == arr[2 - 1] && countarr[0] == 0)
		{
			LC();
			LC();
			countarr[0] = 1;
		}
		if (arr[14 - 1] == arr[11 - 1] && countarr[1] == 0)
		{
			FC();
			FC();
			countarr[1] = 1;
		}
		if (arr[23 - 1] == arr[20 - 1] && countarr[2] == 0)
		{
			RC();
			RC();
			countarr[2] = 1;
		}
		if (arr[32 - 1] == arr[29 - 1] && countarr[3] == 0)
		{
			BC();
			BC();
			countarr[3] = 1;
		}
		//if non of the above condition runs then followind conditions runs
		if (countarr[0] == 0)
		{
			if (arr[2 - 1] == arr[14 - 1])
			{
				EC();
				DC();
				LC();
				LC();
				countarr[0] = 1;
			}
			else if (arr[2 - 1] == arr[32 - 1])
			{
				EA();
				DA();
				LC();
				LC();
				countarr[0] = 1;
			}
			else if (arr[2 - 1] == arr[23 - 1])
			{
				EA();
				EA();
				DA();
				DA();
				LC();
				LC();
				countarr[0] = 1;
			}
		}
		if (countarr[1] == 0)
		{
			if (arr[11 - 1] == arr[23 - 1])
			{
				EC();
				DC();
				FC();
				FC();
				countarr[1] = 1;
			}
			else if (arr[11 - 1] == arr[5 - 1])
			{
				EA();
				DA();
				FC();
				FC();
				countarr[1] = 1;
			}
			else if (arr[11 - 1] == arr[32 - 1])
			{
				EA();
				EA();
				DA();
				DA();
				FC();
				FC();
				countarr[1] = 1;
			}
		}
		if (countarr[2] == 0)
		{
			if (arr[20 - 1] == arr[32 - 1])
			{
				EC();
				DC();
				RC();
				RC();
				countarr[2] = 1;
			}
			else if (arr[20 - 1] == arr[14 - 1])
			{
				EA();
				DA();
				RC();
				RC();
				countarr[2] = 1;
			}
			else if (arr[20 - 1] == arr[5 - 1])
			{
				EA();
				EA();
				DA();
				DA();
				RC();
				RC();
				countarr[2] = 1;
			}
		}
		if (countarr[3] == 0)
		{
			if (arr[29 - 1] == arr[5 - 1])
			{
				EC();
				DC();
				BC();
				BC();
				countarr[3] = 1;
			}
			else if (arr[29 - 1] == arr[23 - 1])
			{
				EA();
				DA();
				BC();
				BC();
				countarr[3] = 1;
			}
			else if (arr[29 - 1] == arr[14 - 1])
			{
				EA();
				EA();
				DA();
				DA();
				BC();
				BC();
				countarr[3] = 1;
			}
		}
	}

}
void Solver::SFL3()
{
	int count[5] = { 0 };
	for (int i = 0; i < 30;i++)
	//while (true)
	{
		if (count[0] == 1 && count[1] == 1 && count[2] == 1 && count[3] == 1 && count[4] == 1)
			break;
		
		if (count[0] == 1/* && count[1] == 1 && count[2] == 1 && count[3] == 1 && count[4] == 1*/)
			break;

		//if Top is all White => count[0]=1
		if (arr[1 - 1] == 5 && arr[2 - 1] == 5 && arr[3 - 1] == 5 && arr[4 - 1] == 5 && arr[5 - 1] == 5 && arr[6 - 1] == 5 && arr[7 - 1] == 5 && arr[8 - 1] == 5 && arr[9 - 1] == 5)
			count[0] = 1;
		//if top layer of left side is same => count[1]=1
		if (arr[1 - 1] == arr[2 - 1] && arr[2 - 1] == arr[3 - 1] && arr[3 - 1] == arr[5 - 1])
			count[1] = 1;
		//if top layer of Front side is same => count[2]=1
		if (arr[10 - 1] == arr[11 - 1] && arr[11 - 1] == arr[12 - 1] && arr[12 - 1] == arr[14 - 1])
			count[2] = 1;
		//if top layer of Right side is same => count[3]=1
		if (arr[19 - 1] == arr[20 - 1] && arr[20 - 1] == arr[21 - 1] && arr[21 - 1] == arr[23 - 1])
			count[3] = 1;
		//if top layer of back side is same => count[4]=1
		if (arr[28 - 1] == arr[29 - 1] && arr[29 - 1] == arr[30 - 1] && arr[30 - 1] == arr[32 - 1])
			count[4] = 1;

		//Solving for making all top elements White

		//1. Solving for Whites in Bottom layer
		if (arr[7 - 1] == 5)
		{
			if (arr[36 - 1] == arr[14 - 1])
			{
				DC();
				FC();
				DC();
				FA();
			}
			else if (arr[36 - 1] == arr[5 - 1])
			{
				DC();
				DC();
				LA();
				DC();
				LC();
			}
			else if (arr[36 - 1] == arr[23 - 1])
			{
				RC();
				DC();
				RA();
			}
			else if (arr[36 - 1] == arr[32 - 1])
			{
				DA();
				BA();
				DC();
				BC();
			}
		}
		else if (arr[9 - 1] == 5)
		{
			if (arr[16 - 1] == arr[14 - 1])
			{
				DC();
				FA();
				DA();
				FC();
			}
			else if (arr[16 - 1] == arr[5 - 1])
			{
				DC();
				DC();
				LC();
				DA();
				LA();
			}
			else if (arr[16 - 1] == arr[23 - 1])
			{
				RA();
				DA();
				RC();
			}
			else if (arr[16 - 1] == arr[32 - 1])
			{
				DA();
				BC();
				DA();
				BA();
			}
		}
		else if (arr[16 - 1] == 5 || arr[18 - 1] == 5)
		{
			DC();
		}
		else if (arr[25 - 1] == 5 || arr[27 - 1] == 5)
		{
			DC();
			DC();
		}
		else if (arr[34 - 1] == 5 || arr[36 - 1] == 5)
		{
			DA();
		}
		//2. Solving for Whites in upper layer
		else if (arr[1 - 1] == 5)
		{
			BA();
			DC();
			BC();
		}
		else if (arr[3 - 1] == 5)
		{
			FA();
			DA();
			FC();
		}
		else if (arr[10 - 1] == 5)
		{
			LA();
			DC();
			LC();
		}
		else if (arr[12 - 1] == 5)
		{
			RA();
			DA();
			RC();
		}
		else if (arr[19 - 1] == 5)
		{
			FC();
			DC();
			FA();
		}
		else if (arr[21 - 1] == 5)
		{
			BC();
			DA();
			BA();
		}
		else if (arr[28 - 1] == 5)
		{
			RC();
			DC();
			RA();
		}
		else if (arr[30 - 1] == 5)
		{
			LC();
			DA();
			LA();
		}
		//3. Solving for Whites in Bootom Face
		else if (arr[46 - 1] == 5)
		{
			while (arr[43 - 1] == 5)
			{
				UC();
				EC();
			}
			LA();
			DC();
			LC();
		}
		else if (arr[48 - 1] == 5)
		{
			while (arr[45 - 1] == 5)
			{
				UC();
				EC();
			}
			RA();
			DA();
			RC();
		}
		else if (arr[52 - 1] == 5)
		{
			while (arr[37 - 1] == 5)
			{
				UC();
				EC();
			}
			LC();
			DA();
			LA();
		}
		else if (arr[54 - 1] == 5)
		{
			while (arr[39 - 1] == 5)
			{
				UC();
				EC();
			}
			RC();
			DC();
			RA();
		}
	}
}
void Solver::SSL()
{
	bool wosrtCase = false;
	bool breakCondition = false;
	for (int i = 0; i < 50; i++)
	{
		if ((arr[4 - 1] == arr[5 - 1] && arr[5 - 1] == arr[6 - 1]) && 
			(arr[13 - 1] == arr[14 - 1] && arr[14 - 1] == arr[15 - 1]) && 
			(arr[22 - 1] == arr[23 - 1] && arr[23 - 1] == arr[24 - 1]) && 
			(arr[31 - 1] == arr[32 - 1] && arr[32 - 1] == arr[33 - 1]))
		{
			break;
		}
		int temp[4] = { 0 };
		if (arr[8 - 1] != 4)
		{
			if (arr[49 - 1] == 4)
				temp[0] = 1;
			else 
				temp[0] = 0;
		}
		else
			temp[0] = 1;
		if (arr[17 - 1] != 4)
		{
			if (arr[47 - 1] == 4)
				temp[1] = 1;
			else
				temp[0] = 0;
		}
		else
			temp[1] = 1;
		
		if (arr[26 - 1] != 4)
		{
			if (arr[51 - 1] == 4)
				temp[2] = 1;
			else
				temp[0] = 0;
		}
		else
			temp[2] = 1;
		
		if (arr[35 - 1] != 4)
		{
			if (arr[53 - 1] == 4)
				temp[3] = 1;
			else
				temp[0] = 0;
		}
		else
			temp[3] = 1;
		if ((arr[4 - 1] != arr[5 - 1] || arr[5 - 1] != arr[6 - 1]) ||
			(arr[13 - 1] != arr[14 - 1] || arr[14 - 1] != arr[15 - 1]) ||
			(arr[22 - 1] != arr[23 - 1] || arr[23 - 1] != arr[24 - 1]) ||
			(arr[31 - 1] != arr[32 - 1] || arr[32 - 1] != arr[33 - 1]))
		{
			if (temp[0] == 1 && temp[1] == 1 && temp[2] == 1 && temp[3] == 1)
				wosrtCase = true;
			else 
				wosrtCase = false;
		}
		else
			wosrtCase = false;
		//worst Case
		if (wosrtCase == true)
		{
			wosrtCase = false;
			if (arr[4 - 1] != arr[5 - 1] || arr[5 - 1] != arr[6 - 1])
			{
				//bring to front
				UC();
				EC();
			}
			else if (arr[22 - 1] != arr[23 - 1] || arr[23 - 1] != arr[24 - 1])
			{
				UA();
				EA();
			}
			else if (arr[31 - 1] != arr[32 - 1] || arr[32 - 1] != arr[33 - 1])
			{
				UA();
				EA();
				UA();
				EA();
			}
			if (arr[5 - 1] != arr[6 - 1])
			{
				DC();
				BA();
				RA();
				SA();
				RC();
				SC();
				BC();
				DA();
				SC();
				DC();
				SA();
			}
			else if (arr[4 - 1] != arr[5 - 1])
			{
				DA();
				BC();
				LA();
				SC();
				LC();
				SA();
				BA();
				DC();
				SA();
				DA();
				SC();
			}
		}
		if (arr[17 - 1] != 4 && arr[47 - 1] != 4)
		{
			if (arr[17 - 1] == arr[14 - 1] && arr[47 - 1] == arr[23 - 1])
			{
				DC();
				BA();
				RA();
				SA();
				RC();
				SC();
				BC();
				DA();
				SC();
				DC();
				SA();
			}
			else if (arr[17 - 1] == arr[14 - 1] && arr[47 - 1] == arr[5 - 1])
			{
				DA();
				BC();
				LA();
				SC();
				LC();
				SA();
				BA();
				DC();
				SA();
				DA();
				SC();
			}
			else if (arr[17 - 1] == arr[23 - 1])
			{
				EC();
				UC();
			}
			else if (arr[17 - 1] == arr[5 - 1])
			{
				EA();
				UA();
			}
			else if (arr[17 - 1] == arr[32 - 1])
			{
				EA();
				UA();
				EA();
				UA();
			}
		}
		else if (arr[8 - 1] != 4 && arr[49 - 1] != 4)
		{
			DA();
		}
		else if (arr[26 - 1] != 4 && arr[51 - 1] != 4)
		{
			DC();
		}
		else if (arr[35 - 1] != 4 && arr[53 - 1] != 4)
		{
			DA();
			DA();
		}
	}
}
void Solver::STL1()
{
	bool conditon = true;
	AU();
	AU();
	int current_move = 0;
	int change = 0;
	//for (int j = 0; j < 50;j++)
	while (true)
	{
		if (arr[38 - 1] == 4 && arr[40 - 1] == 4 && arr[42 - 1] == 4 && arr[44 - 1] == 4)
		{
			break;
		}
		int No_Of_Yellow = 0;
		for (int i = 37 - 1; i <= 45 - 1; i++)
		{
			if (arr[i] == 4)
				No_Of_Yellow++;
		}
		 if (arr[38 - 1] == 4 && arr[41 - 1] == 4 && arr[44 - 1] == 4)
		{
			 if (arr[2 - 1] == 4)
			 {
				 UA();
				 FC();
				 RC();
				 UC();
				 RA();
				 UA();
				 FA();
			 }
			 else if (arr[20 - 1] == 4)
			 {
				 UC();

				 FC();
				 RC();
				 UC();

				 RA();
				 UA();
				 FA();
			 }
			 else
			 {
				 UC();

				 FC();
				 RC();
				 UC();

				 RA();
				 UA();
				 FA();
			 }
		}
		else if (arr[40 - 1] == 4 && arr[41 - 1] == 4 && arr[42 - 1] == 4)
		{
			if (arr[11 - 1] == 4)
			{

				FC();
				RC();
				UC();

				RA();
				UA();
				FA();
			}
			else if (arr[29 - 1] == 4)
			{
				UC();
				UC();

				FC();
				RC();
				UC();

				RA();
				UA();
				FA();
			}
			else
			{
				FC();
				RC();
				UC();

				RA();
				UA();
				FA();
			}
		}
		//Solving for zig zag pattern of yellow
		else if (arr[38 - 1] == 4 && arr[40 - 1] == 4 && arr[41 - 1] == 4 && arr[43 - 1] == 4)
		{
			//cout << "zig zag pattern of yellow" << endl;
			//displayArray();
			FC();
			UC();
			RC();

			UA();
			RA();
			FA();
		}
		else if (arr[40 - 1] == 4 && arr[41 - 1] == 4 && arr[44 - 1] == 4 && arr[45 - 1] == 4)
		{
			//cout << "zig zag pattern of yellow" << endl;
			//displayArray();
			RC();
			UC();
			BA();

			UA();
			BC();
			RA();
		}
		else if (arr[39 - 1] == 4 && arr[41 - 1] == 4 && arr[42 - 1] == 4 && arr[44 - 1] == 4)
		{
			//cout << "zig zag pattern of yellow" << endl;
			//displayArray();
			BA();
			UC();
			LA();

			UA();
			LC();
			BC();
		}
		else if (arr[37 - 1] == 4 && arr[38 - 1] == 4 && arr[41 - 1] == 4 && arr[42 - 1] == 4)
		{
			//cout << "zig zag pattern of yellow" << endl;
			//displayArray();
			LA();
			UC();
			FC();

			UA();
			FA();
			LC(); 
		}
		else if (arr[38 - 1] == 4 && arr[40 - 1] == 4 && arr[41 - 1] == 4)
		{
			FC();
			RC();
			UC();

			RA();
			UA();
			FA();
		}
		else if (arr[38 - 1] == 4 && arr[41 - 1] == 4 && arr[42 - 1] == 4)
		{
			UA();

			FC();
			RC();
			UC();

			RA();
			UA();
			FA();
		}
		else if (arr[41 - 1] == 4 && arr[42 - 1] == 4 && arr[44 - 1] == 4)
		{
			UA();
			UA();

			FC();
			RC();
			UC();

			RA();
			UA();
			FA();
		}
		else if (arr[40 - 1] == 4 && arr[41 - 1] == 4 && arr[44 - 1] == 4)
		{
			UC();

			FC();
			RC();
			UC();

			RA();
			UA();
			FA();
		}
		else if (No_Of_Yellow <= 3)
		{
			//displayArray();
			if (conditon == true)
			{
				FC();
				UC();
				RC();

				UA();
				RA();
				FA();
				conditon = false;
			}
			else
			{
				if (change == 4)
					change = 0;
				if (change == 0 ||change ==2 || change == 3)
					UC();
				FC();
				RC();
				UC();

				RA();
				UA();
				FA();
				conditon = true;
				change++;
			}
		}
	}
}
void Solver::STL2()
{
	int current_move = 0;
	//for (int j = 0; j < 40; j++)
	while (true)
	{
		int yellow = 0;
		for (int i = 37 - 1; i <= 45 - 1; i++)
		{
			if (arr[i] == 4)
				yellow++;
		}
		if (yellow == 9)
		{
			//cout << "Top layer solved" << endl;
			break;
		}
		int No_Of_Yellow = 0;
		for (int i = 37 - 1; i <= 45 - 1; i++)
		{
			if (arr[i] == 4)
				No_Of_Yellow++;
		}
		if (No_Of_Yellow == 6  && arr[38 - 1] == 4 && arr[40 - 1] == 4 && arr[41 - 1] == 4
			&& arr[42 - 1] == 4 && arr[44 - 1] == 4 && arr[37 - 1] == 4)
		
		{
			//cout << "Fish pattern is formed" << endl;
			UA();

			RC();
			UC();
			RA();
			UC();
			RC();
			UC();
			UC();
			RA();
		}
		else if (No_Of_Yellow ==6 && arr[38 - 1] == 4 && arr[40 - 1] == 4 && arr[41 - 1] == 4
			&& arr[42 - 1] == 4 && arr[44 - 1] == 4 && arr[39 - 1] == 4)
		{
			//cout << "Fish pattern is formed" << endl;
			UA();
			UA();

			RC();
			UC();
			RA();
			UC();
			RC();
			UC();
			UC();
			RA();
		}
		else if (No_Of_Yellow == 6 && arr[38 - 1] == 4 && arr[40 - 1] == 4 && arr[41 - 1] == 4
			&& arr[42 - 1] == 4 && arr[44 - 1] == 4 && arr[45 - 1] == 4)
		{
			//cout << "Fish pattern is formed" << endl;
			UC();

			RC();
			UC();
			RA();
			UC();
			RC();
			UC();
			UC();
			RA();
		}
		else if (No_Of_Yellow == 6 && arr[38 - 1] == 4 && arr[40 - 1] == 4 && arr[41 - 1] == 4
			&& arr[42 - 1] == 4 && arr[44 - 1] == 4 && arr[43 - 1] == 4)
		{
			//cout << "Fish pattern is formed" << endl;
			current_move++;
			RC();
			UC();
			RA();
			UC();
			RC();
			UC();
			UC();
			RA();
		}		
		else if (arr[37 - 1] == 4 && arr[38 - 1] == 4 && arr[39 - 1] == 4
			&& arr[40 - 1] == 4 && arr[41 - 1] == 4 && arr[42 - 1] == 4
			&& arr[44 - 1] == 4 && No_Of_Yellow == 7)
		{
			/*cout << "irregular 7" << endl;*/
			RC();
			UC();
			RA();
			UC();
			RC();
			UC();
			UC();
			RA();
		}
		else if (arr[38 - 1] == 4 && arr[39 - 1] == 4 && arr[40 - 1] == 4
			&& arr[41 - 1] == 4 && arr[42 - 1] == 4 && arr[44 - 1] == 4
			&& arr[45 - 1] == 4 && No_Of_Yellow == 7)
		{
			/*cout << "irregular 7" << endl;*/
			//bringing the right side
			UA();

			RC();
			UC();
			RA();
			UC();
			RC();
			UC();
			UC();
			RA();
		}
		else if (arr[38 - 1] == 4 && arr[40 - 1] == 4 && arr[41 - 1] == 4
			&& arr[42 - 1] == 4 && arr[43 - 1] == 4 && arr[44 - 1] == 4
			&& arr[45 - 1] == 4 && No_Of_Yellow == 7)
		{
			/*cout << "irregular 7" << endl;*/
			UA();
			UA();

			RC();
			UC();
			RA();
			UC();
			RC();
			UC();
			UC();
			RA();
		}
		else if (arr[37 - 1] == 4 && arr[38 - 1] == 4 && arr[40 - 1] == 4
			&& arr[41 - 1] == 4 && arr[42 - 1] == 4 && arr[43 - 1] == 4
			&& arr[44 - 1] == 4 && No_Of_Yellow == 7)
		{
			/*cout << "irregular 7" << endl;*/
			UC();

			RC();
			UC();
			RA();
			UC();
			RC();
			UC();
			UC();
			RA();
		}
		//if 2 Squares on top
		else if ((arr[37 - 1] != 4 && arr[45 - 1] == 4) ||
			(arr[39 - 1] != 4 && arr[43 - 1] == 4) && No_Of_Yellow == 7)
		{
			/*cout << "regular 7" << endl;*/
			while (arr[10 - 1] != 4)
				UC();

			RC();
			UC();
			RA();
			UC();
			RC();
			UC();
			UC();
			RA();
		}
		/*cout << "arr[38 - 1] = " << arr[38 - 1] << endl;
		cout << "arr[40 - 1] = " << arr[40 - 1] << endl;
		cout << "arr[42 - 1] = " << arr[42 - 1] << endl;
		cout << "arr[44 - 1] = " << arr[44 - 1] << endl;*/
		else if (arr[38 - 1] == 4 && arr[40 - 1] == 4
			&& arr[42 - 1] == 4 && arr[44 - 1] == 4 && No_Of_Yellow == 4)
		{
			/*cout << "Cross" << endl;*/
			displayArray();
			if (arr[1 - 1] == 4 && arr[3 - 1] == 4)
			{
				UC();
			}
			else if (arr[19 - 1] == 4 && arr[21 - 1] == 4)
			{
				UA();
			}
			else if (arr[28 - 1] == 4 && arr[30 - 1] == 4)
			{
				UA();
				UA();
			}
			RC();
			UC();
			RA();
			UC();
			RC();
			UC();
			UC();
			RA();
		}
		else
		{
			RC();
			UC();
			RA();
			UC();
			RC();
			UC();
			UC();
			RA();
		}
	}
}
void Solver::FinalStep()
{
	while (true)
	{
		if (arr[1 - 1] == arr[3 - 1] && arr[10 - 1] == arr[12 - 1] && 
			arr[28 - 1] == arr[30 - 1] && arr[19 - 1] == arr[21 - 1])
			break;
		if (arr[1 - 1] == arr[3 - 1])
		{
			UC();
			while (arr[32 - 1] != arr[28 - 1])
			{
				EC();
				DC();
			}
			RA();
			FC();
			RA();
			BC();
			BC();
			RC();
			FA();
			RA();
			BC();
			BC();
			RA();
			RA();
		}
		else if (arr[19 - 1] == arr[21 - 1])
		{
			UA();
			while (arr[32 - 1] != arr[28 - 1])
			{
				EC();
				DC();
			}
			RA();
			FC();
			RA();
			BC();
			BC();
			RC();
			FA();
			RA();
			BC();
			BC();
			RA();
			RA();
		}
		else if (arr[10 - 1] == arr[12 - 1])
		{
			UA();
			UA();

			while (arr[32 - 1] != arr[28 - 1])
			{
				EC();
				DC();
			}
			RA();
			FC();
			RA();
			BC();
			BC();
			RC();
			FA();
			RA();
			BC();
			BC();
			RA();
			RA();
		}
		else if (arr[1 - 1] == arr[2 - 1] || arr[2 - 1] == arr[3 - 1])
		{
			UC();
			while (arr[32 - 1] != arr[28 - 1])
			{
				EC();
				DC();
			}
			RA();
			FC();
			RA();
			BC();
			BC();
			RC();
			FA();
			RA();
			BC();
			BC();
			RA();
			RA();
		}
		else if (arr[10 - 1] == arr[11 - 1] || arr[11 - 1] == arr[12 - 1])
		{
			UC();
			UC();
			while (arr[32 - 1] != arr[28 - 1])
			{
				EC();
				DC();
			}
			RA();
			FC();
			RA();
			BC();
			BC();
			RC();
			FA();
			RA();
			BC();
			BC();
			RA();
			RA();
		}
		else if (arr[19 - 1] == arr[20 - 1] || arr[20 - 1] == arr[21 - 1])
		{
			UA();
			while (arr[32 - 1] != arr[28 - 1])
			{
				EC();
				DC();
			}
			RA();
			FC();
			RA();
			BC();
			BC();
			RC();
			FA();
			RA();
			BC();
			BC();
			RA();
			RA();
		}
		else
		{
			RA();
			FC();
			RA();
			BC();
			BC();
			RC();
			FA();
			RA();
			BC();
			BC();
			RA();
			RA();
		}
	}
	//for (int i = 0; i < 20;i++)
	while (true)
	{
		if (arr[1 - 1] == arr[2 - 1] && arr[2 - 1] == arr[3 - 1] &&
			arr[10 - 1] == arr[11 - 1] && arr[11 - 1] == arr[12 - 1] &&
			arr[19 - 1] == arr[20 - 1] && arr[20 - 1] == arr[21 - 1] &&
			arr[28 - 1] == arr[29 - 1] && arr[29 - 1] == arr[30 - 1])
		{
			/*system("CLS");
			cout << "CUBE SOLVED :)" << endl;*/
			break;
		}
		if (arr[1 - 1] == arr[2 - 1] && arr[2 - 1] == arr[3 - 1])
		{
			UC();
		}
		else if (arr[10 - 1] == arr[11 - 1] && arr[11 - 1] == arr[12 - 1])
		{
			UA();
			UA();
		}
		else if (arr[19 - 1] == arr[20 - 1] && arr[20 - 1] == arr[21 - 1])
		{
			UA();
		}
		else if (arr[1 - 1] == arr[3 - 1])
		{
			UC();
		}
		else if (arr[19 - 1] == arr[21 - 1])
		{
			UA();
		}
		else if (arr[10 - 1] == arr[12 - 1])
		{
			UA();
			UA();
		}
		while (arr[32 - 1] != arr[28 - 1])
		{
			DC();
			EC();
		}
		if (arr[20 - 1] == arr[14 - 1])
		{
			RC();
			RC();
			UC();
			RC();
			UC();
			RA();
			UA();
			RA();
			UA();
			RA();
			UC();
			RA();
		}
		else if (arr[2 - 1] == arr[14 - 1])
		{
			RC();
			UA();
			RC();
			UC();
			RC();
			UC();
			RC();
			UA();
			RA();
			UA();
			RC();
			RC();
		}
		else
		{
			RC();
			RC();
			UC();
			RC();
			UC();
			RA();
			UA();
			RA();
			UA();
			RA();
			UC();
			RA();
		}

	}
}
void Solver::writter()
{
	cur = head;
	writter_(head);
}
void Solver::displayMoves()
{
	cur = head;
	while (cur->next != NULL)
	{
		cout << cur->data << "  ";
		cur = cur->next;
	}
	cout << endl;
}
bool Solver::CFSC()
{
	//Left Face is Solved
	for (int i = 0; i < 8; i++)
	{
		if (arr[i] != arr[i + 1])
			return false;
	}
	//Front face is solved
	for (int i = 9; i < 17; i++)
	{
		if (arr[i] != arr[i + 1])
			return false;
	}
	//Right Face is solved
	for (int i = 18; i < 26; i++)
	{
		if (arr[i] != arr[i + 1])
			return false;
	}
	//Back Face is solved
	for (int i = 27; i < 35; i++)
	{
		if (arr[i] != arr[i + 1])
			return false;
	}
	//Top Face is solved
	for (int i = 36; i < 44; i++)
	{
		if (arr[i] != arr[i + 1])
			return false;
	}
	//Bottom Face is solved
	for (int i = 45; i < 53; i++)
	{
		if (arr[i] != arr[i + 1])
			return false;
	}
	return true;
}
Solver::~Solver()
{
	delete head, cur;
}
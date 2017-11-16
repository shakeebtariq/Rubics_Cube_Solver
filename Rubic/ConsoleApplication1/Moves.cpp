#include"Moves.h"
Moves::Moves()
{
	//cout << "constructor of Moves called" << endl;
}
Moves::~Moves()
{
	//cout << "Destructor of Moves called" << endl;
}
void Moves::RC()
{
	cur->data = 'a';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[12 - 1];
	temp[1] = arr[15 - 1];
	temp[2] = arr[18 - 1];
	temp[3] = arr[28 - 1];
	temp[4] = arr[31 - 1];
	temp[5] = arr[34 - 1];
	temp[6] = arr[39 - 1];
	temp[7] = arr[42 - 1];
	temp[8] = arr[45 - 1];
	temp[9] = arr[48 - 1];
	temp[10] = arr[51 - 1];
	temp[11] = arr[54 - 1];

	arr[12 - 1] = temp[9];
	arr[15 - 1] = temp[10];
	arr[18 - 1] = temp[11];

	arr[39 - 1] = temp[0];
	arr[42 - 1] = temp[1];
	arr[45 - 1] = temp[2];

	arr[28 - 1] = temp[8];
	arr[31 - 1] = temp[7];
	arr[34 - 1] = temp[6];

	arr[54 - 1] = temp[3];
	arr[51 - 1] = temp[4];
	arr[48 - 1] = temp[5];
	//roting right side
	temp[0] = arr[19 - 1];
	temp[1] = arr[20 - 1];
	temp[2] = arr[21 - 1];
	temp[3] = arr[22 - 1];
	temp[4] = arr[23 - 1];
	temp[5] = arr[24 - 1];
	temp[6] = arr[25 - 1];
	temp[7] = arr[26 - 1];
	temp[8] = arr[27 - 1];
	arr[19 - 1] = temp[6];
	arr[20 - 1] = temp[3];
	arr[21 - 1] = temp[0];
	arr[22 - 1] = temp[7];
	arr[23 - 1] = temp[4];
	arr[24 - 1] = temp[1];
	arr[25 - 1] = temp[8];
	arr[26 - 1] = temp[5];
	arr[27 - 1] = temp[2];
}
void Moves::RA()
{
	cur->data = 'b';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[12 - 1];
	temp[1] = arr[15 - 1];
	temp[2] = arr[18 - 1];
	temp[3] = arr[28 - 1];
	temp[4] = arr[31 - 1];
	temp[5] = arr[34 - 1];
	temp[6] = arr[39 - 1];
	temp[7] = arr[42 - 1];
	temp[8] = arr[45 - 1];
	temp[9] = arr[48 - 1];
	temp[10] = arr[51 - 1];
	temp[11] = arr[54 - 1];

	arr[12 - 1] = temp[6];
	arr[15 - 1] = temp[7];
	arr[18 - 1] = temp[8];

	arr[39 - 1] = temp[5];
	arr[42 - 1] = temp[4];
	arr[45 - 1] = temp[3];

	arr[28 - 1] = temp[11];
	arr[31 - 1] = temp[10];
	arr[34 - 1] = temp[9];

	arr[54 - 1] = temp[2];
	arr[51 - 1] = temp[1];
	arr[48 - 1] = temp[0];
	//roting right side
	temp[0] = arr[19 - 1];
	temp[1] = arr[20 - 1];
	temp[2] = arr[21 - 1];
	temp[3] = arr[22 - 1];
	temp[4] = arr[23 - 1];
	temp[5] = arr[24 - 1];
	temp[6] = arr[25 - 1];
	temp[7] = arr[26 - 1];
	temp[8] = arr[27 - 1];
	arr[19 - 1] = temp[2];
	arr[20 - 1] = temp[5];
	arr[21 - 1] = temp[8];
	arr[22 - 1] = temp[1];
	arr[23 - 1] = temp[4];
	arr[24 - 1] = temp[7];
	arr[25 - 1] = temp[0];
	arr[26 - 1] = temp[3];
	arr[27 - 1] = temp[6];
}
void Moves::LC()
{
	cur->data = 'c';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[10 - 1];
	temp[1] = arr[13 - 1];
	temp[2] = arr[16 - 1];
	temp[3] = arr[30 - 1];
	temp[4] = arr[33 - 1];
	temp[5] = arr[36 - 1];
	temp[6] = arr[37 - 1];
	temp[7] = arr[40 - 1];
	temp[8] = arr[43 - 1];
	temp[9] = arr[46 - 1];
	temp[10] = arr[49 - 1];
	temp[11] = arr[52 - 1];

	arr[37 - 1] = temp[0];
	arr[40 - 1] = temp[1];
	arr[43 - 1] = temp[2];

	arr[10 - 1] = temp[9];
	arr[13 - 1] = temp[10];
	arr[16 - 1] = temp[11];

	arr[30 - 1] = temp[8];
	arr[33 - 1] = temp[7];
	arr[36 - 1] = temp[6];

	arr[46 - 1] = temp[5];
	arr[49 - 1] = temp[4];
	arr[52 - 1] = temp[3];
	//roting right side
	temp[0] = arr[1 - 1];
	temp[1] = arr[2 - 1];
	temp[2] = arr[3 - 1];
	temp[3] = arr[4 - 1];
	temp[4] = arr[5 - 1];
	temp[5] = arr[6 - 1];
	temp[6] = arr[7 - 1];
	temp[7] = arr[8 - 1];
	temp[8] = arr[9 - 1];
	arr[1 - 1] = temp[2];
	arr[2 - 1] = temp[5];
	arr[3 - 1] = temp[8];
	arr[4 - 1] = temp[1];
	arr[5 - 1] = temp[4];
	arr[6 - 1] = temp[7];
	arr[7 - 1] = temp[0];
	arr[8 - 1] = temp[3];
	arr[9 - 1] = temp[6];
}
void Moves::LA()
{
	cur->data = 'd';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[10 - 1];
	temp[1] = arr[13 - 1];
	temp[2] = arr[16 - 1];
	temp[3] = arr[30 - 1];
	temp[4] = arr[33 - 1];
	temp[5] = arr[36 - 1];
	temp[6] = arr[37 - 1];
	temp[7] = arr[40 - 1];
	temp[8] = arr[43 - 1];
	temp[9] = arr[46 - 1];
	temp[10] = arr[49 - 1];
	temp[11] = arr[52 - 1];

	arr[37 - 1] = temp[5];
	arr[40 - 1] = temp[4];
	arr[43 - 1] = temp[3];

	arr[10 - 1] = temp[6];
	arr[13 - 1] = temp[7];
	arr[16 - 1] = temp[8];

	arr[30 - 1] = temp[11];
	arr[33 - 1] = temp[10];
	arr[36 - 1] = temp[9];

	arr[46 - 1] = temp[0];
	arr[49 - 1] = temp[1];
	arr[52 - 1] = temp[2];
	//roting right side
	temp[0] = arr[1 - 1];
	temp[1] = arr[2 - 1];
	temp[2] = arr[3 - 1];
	temp[3] = arr[4 - 1];
	temp[4] = arr[5 - 1];
	temp[5] = arr[6 - 1];
	temp[6] = arr[7 - 1];
	temp[7] = arr[8 - 1];
	temp[8] = arr[9 - 1];
	arr[1 - 1] = temp[6];
	arr[2 - 1] = temp[3];
	arr[3 - 1] = temp[0];
	arr[4 - 1] = temp[7];
	arr[5 - 1] = temp[4];
	arr[6 - 1] = temp[1];
	arr[7 - 1] = temp[8];
	arr[8 - 1] = temp[5];
	arr[9 - 1] = temp[2];
}
void Moves::UC()
{
	cur->data = 'e';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[1 - 1];
	temp[1] = arr[2 - 1];
	temp[2] = arr[3 - 1];
	temp[3] = arr[10 - 1];
	temp[4] = arr[11 - 1];
	temp[5] = arr[12 - 1];
	temp[6] = arr[19 - 1];
	temp[7] = arr[20 - 1];
	temp[8] = arr[21 - 1];
	temp[9] = arr[28 - 1];
	temp[10] = arr[29 - 1];
	temp[11] = arr[30 - 1];

	arr[1 - 1] = temp[3];
	arr[2 - 1] = temp[4];
	arr[3 - 1] = temp[5];

	arr[10 - 1] = temp[6];
	arr[11 - 1] = temp[7];
	arr[12 - 1] = temp[8];

	arr[19 - 1] = temp[9];
	arr[20 - 1] = temp[10];
	arr[21 - 1] = temp[11];

	arr[28 - 1] = temp[0];
	arr[29 - 1] = temp[1];
	arr[30 - 1] = temp[2];
	//roting right side
	temp[0] = arr[37 - 1];
	temp[1] = arr[38 - 1];
	temp[2] = arr[39 - 1];
	temp[3] = arr[40 - 1];
	temp[4] = arr[41 - 1];
	temp[5] = arr[42 - 1];
	temp[6] = arr[43 - 1];
	temp[7] = arr[44 - 1];
	temp[8] = arr[45 - 1];
	arr[37 - 1] = temp[6];
	arr[38 - 1] = temp[3];
	arr[39 - 1] = temp[0];
	arr[40 - 1] = temp[7];
	arr[41 - 1] = temp[4];
	arr[42 - 1] = temp[1];
	arr[43 - 1] = temp[8];
	arr[44 - 1] = temp[5];
	arr[45 - 1] = temp[2];
}
void Moves::UA()
{
	cur->data = 'f';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[1 - 1];
	temp[1] = arr[2 - 1];
	temp[2] = arr[3 - 1];
	temp[3] = arr[10 - 1];
	temp[4] = arr[11 - 1];
	temp[5] = arr[12 - 1];
	temp[6] = arr[19 - 1];
	temp[7] = arr[20 - 1];
	temp[8] = arr[21 - 1];
	temp[9] = arr[28 - 1];
	temp[10] = arr[29 - 1];
	temp[11] = arr[30 - 1];

	arr[1 - 1] = temp[9];
	arr[2 - 1] = temp[10];
	arr[3 - 1] = temp[11];

	arr[10 - 1] = temp[0];
	arr[11 - 1] = temp[1];
	arr[12 - 1] = temp[2];

	arr[19 - 1] = temp[3];
	arr[20 - 1] = temp[4];
	arr[21 - 1] = temp[5];

	arr[28 - 1] = temp[6];
	arr[29 - 1] = temp[7];
	arr[30 - 1] = temp[8];
	//roting right side
	temp[0] = arr[37 - 1];
	temp[1] = arr[38 - 1];
	temp[2] = arr[39 - 1];
	temp[3] = arr[40 - 1];
	temp[4] = arr[41 - 1];
	temp[5] = arr[42 - 1];
	temp[6] = arr[43 - 1];
	temp[7] = arr[44 - 1];
	temp[8] = arr[45 - 1];
	arr[37 - 1] = temp[2];
	arr[38 - 1] = temp[5];
	arr[39 - 1] = temp[8];
	arr[40 - 1] = temp[1];
	arr[41 - 1] = temp[4];
	arr[42 - 1] = temp[7];
	arr[43 - 1] = temp[0];
	arr[44 - 1] = temp[3];
	arr[45 - 1] = temp[6];
}
void Moves::DC()
{
	cur->data = 'g';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[7 - 1];
	temp[1] = arr[8 - 1];
	temp[2] = arr[9 - 1];
	temp[3] = arr[16 - 1];
	temp[4] = arr[17 - 1];
	temp[5] = arr[18 - 1];
	temp[6] = arr[25 - 1];
	temp[7] = arr[26 - 1];
	temp[8] = arr[27 - 1];
	temp[9] = arr[34 - 1];
	temp[10] = arr[35 - 1];
	temp[11] = arr[36 - 1];

	arr[7 - 1] = temp[3];
	arr[8 - 1] = temp[4];
	arr[9 - 1] = temp[5];

	arr[16 - 1] = temp[6];
	arr[17 - 1] = temp[7];
	arr[18 - 1] = temp[8];

	arr[25 - 1] = temp[9];
	arr[26 - 1] = temp[10];
	arr[27 - 1] = temp[11];

	arr[34 - 1] = temp[0];
	arr[35 - 1] = temp[1];
	arr[36 - 1] = temp[2];
	//roting right side
	temp[0] = arr[46 - 1];
	temp[1] = arr[47 - 1];
	temp[2] = arr[48 - 1];
	temp[3] = arr[49 - 1];
	temp[4] = arr[50 - 1];
	temp[5] = arr[51 - 1];
	temp[6] = arr[52 - 1];
	temp[7] = arr[53 - 1];
	temp[8] = arr[54 - 1];
	arr[46 - 1] = temp[2];
	arr[47 - 1] = temp[5];
	arr[48 - 1] = temp[8];
	arr[49 - 1] = temp[1];
	arr[50 - 1] = temp[4];
	arr[51 - 1] = temp[7];
	arr[52 - 1] = temp[0];
	arr[53 - 1] = temp[3];
	arr[54 - 1] = temp[6];
}
void Moves::DA()
{
	cur->data = 'h';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[7 - 1];
	temp[1] = arr[8 - 1];
	temp[2] = arr[9 - 1];
	temp[3] = arr[16 - 1];
	temp[4] = arr[17 - 1];
	temp[5] = arr[18 - 1];
	temp[6] = arr[25 - 1];
	temp[7] = arr[26 - 1];
	temp[8] = arr[27 - 1];
	temp[9] = arr[34 - 1];
	temp[10] = arr[35 - 1];
	temp[11] = arr[36 - 1];

	arr[7 - 1] = temp[9];
	arr[8 - 1] = temp[10];
	arr[9 - 1] = temp[11];

	arr[16 - 1] = temp[0];
	arr[17 - 1] = temp[1];
	arr[18 - 1] = temp[2];

	arr[25 - 1] = temp[3];
	arr[26 - 1] = temp[4];
	arr[27 - 1] = temp[5];

	arr[34 - 1] = temp[6];
	arr[35 - 1] = temp[7];
	arr[36 - 1] = temp[8];
	//roting right side
	temp[0] = arr[46 - 1];
	temp[1] = arr[47 - 1];
	temp[2] = arr[48 - 1];
	temp[3] = arr[49 - 1];
	temp[4] = arr[50 - 1];
	temp[5] = arr[51 - 1];
	temp[6] = arr[52 - 1];
	temp[7] = arr[53 - 1];
	temp[8] = arr[54 - 1];
	arr[46 - 1] = temp[6];
	arr[47 - 1] = temp[3];
	arr[48 - 1] = temp[0];
	arr[49 - 1] = temp[7];
	arr[50 - 1] = temp[4];
	arr[51 - 1] = temp[1];
	arr[52 - 1] = temp[8];
	arr[53 - 1] = temp[5];
	arr[54 - 1] = temp[2];
}
void Moves::FC()
{
	cur->data = 'i';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[3 - 1];
	temp[1] = arr[6 - 1];
	temp[2] = arr[9 - 1];
	temp[3] = arr[19 - 1];
	temp[4] = arr[22 - 1];
	temp[5] = arr[25 - 1];
	temp[6] = arr[43 - 1];
	temp[7] = arr[44 - 1];
	temp[8] = arr[45 - 1];
	temp[9] = arr[46 - 1];
	temp[10] = arr[47 - 1];
	temp[11] = arr[48 - 1];

	arr[3 - 1] = temp[9];
	arr[6 - 1] = temp[10];
	arr[9 - 1] = temp[11];

	arr[43 - 1] = temp[2];
	arr[44 - 1] = temp[1];
	arr[45 - 1] = temp[0];

	arr[19 - 1] = temp[6];
	arr[22 - 1] = temp[7];
	arr[25 - 1] = temp[8];

	arr[46 - 1] = temp[5];
	arr[47 - 1] = temp[4];
	arr[48 - 1] = temp[3];
	//roting right side
	temp[0] = arr[10 - 1];
	temp[1] = arr[11 - 1];
	temp[2] = arr[12 - 1];
	temp[3] = arr[13 - 1];
	temp[4] = arr[14 - 1];
	temp[5] = arr[15 - 1];
	temp[6] = arr[16 - 1];
	temp[7] = arr[17 - 1];
	temp[8] = arr[18 - 1];
	arr[10 - 1] = temp[6];
	arr[11 - 1] = temp[3];
	arr[12 - 1] = temp[0];
	arr[13 - 1] = temp[7];
	arr[14 - 1] = temp[4];
	arr[15 - 1] = temp[1];
	arr[16 - 1] = temp[8];
	arr[17 - 1] = temp[5];
	arr[18 - 1] = temp[2];
}
void Moves::FA()
{
	cur->data = 'j';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[3 - 1];
	temp[1] = arr[6 - 1];
	temp[2] = arr[9 - 1];
	temp[3] = arr[19 - 1];
	temp[4] = arr[22 - 1];
	temp[5] = arr[25 - 1];
	temp[6] = arr[43 - 1];
	temp[7] = arr[44 - 1];
	temp[8] = arr[45 - 1];
	temp[9] = arr[46 - 1];
	temp[10] = arr[47 - 1];
	temp[11] = arr[48 - 1];

	arr[3 - 1] = temp[8];
	arr[6 - 1] = temp[7];
	arr[9 - 1] = temp[6];

	arr[43 - 1] = temp[3];
	arr[44 - 1] = temp[4];
	arr[45 - 1] = temp[5];

	arr[19 - 1] = temp[11];
	arr[22 - 1] = temp[10];
	arr[25 - 1] = temp[9];

	arr[46 - 1] = temp[0];
	arr[47 - 1] = temp[1];
	arr[48 - 1] = temp[2];
	//roting right side
	temp[0] = arr[10 - 1];
	temp[1] = arr[11 - 1];
	temp[2] = arr[12 - 1];
	temp[3] = arr[13 - 1];
	temp[4] = arr[14 - 1];
	temp[5] = arr[15 - 1];
	temp[6] = arr[16 - 1];
	temp[7] = arr[17 - 1];
	temp[8] = arr[18 - 1];
	arr[10 - 1] = temp[2];
	arr[11 - 1] = temp[5];
	arr[12 - 1] = temp[8];
	arr[13 - 1] = temp[1];
	arr[14 - 1] = temp[4];
	arr[15 - 1] = temp[7];
	arr[16 - 1] = temp[0];
	arr[17 - 1] = temp[3];
	arr[18 - 1] = temp[6];
}
void Moves::BC()
{
	cur->data = 'k';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[1 - 1];
	temp[1] = arr[4 - 1];
	temp[2] = arr[7 - 1];
	temp[3] = arr[21 - 1];
	temp[4] = arr[24 - 1];
	temp[5] = arr[27 - 1];
	temp[6] = arr[37 - 1];
	temp[7] = arr[38 - 1];
	temp[8] = arr[39 - 1];
	temp[9] = arr[52 - 1];
	temp[10] = arr[53 - 1];
	temp[11] = arr[54 - 1];

	arr[1 - 1] = temp[9];
	arr[4 - 1] = temp[10];
	arr[7 - 1] = temp[11];

	arr[21 - 1] = temp[6];
	arr[24 - 1] = temp[7];
	arr[27 - 1] = temp[8];

	arr[37 - 1] = temp[2];
	arr[38 - 1] = temp[1];
	arr[39 - 1] = temp[0];

	arr[52 - 1] = temp[5];
	arr[53 - 1] = temp[4];
	arr[54 - 1] = temp[3];
	//roting right side
	temp[0] = arr[28 - 1];
	temp[1] = arr[29 - 1];
	temp[2] = arr[30 - 1];
	temp[3] = arr[31 - 1];
	temp[4] = arr[32 - 1];
	temp[5] = arr[33 - 1];
	temp[6] = arr[34 - 1];
	temp[7] = arr[35 - 1];
	temp[8] = arr[36 - 1];
	arr[28 - 1] = temp[2];
	arr[29 - 1] = temp[5];
	arr[30 - 1] = temp[8];
	arr[31 - 1] = temp[1];
	arr[32 - 1] = temp[4];
	arr[33 - 1] = temp[7];
	arr[34 - 1] = temp[0];
	arr[35 - 1] = temp[3];
	arr[36 - 1] = temp[6];
}
void Moves::BA()
{
	cur->data = 'l';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[1 - 1];
	temp[1] = arr[4 - 1];
	temp[2] = arr[7 - 1];
	temp[3] = arr[21 - 1];
	temp[4] = arr[24 - 1];
	temp[5] = arr[27 - 1];
	temp[6] = arr[37 - 1];
	temp[7] = arr[38 - 1];
	temp[8] = arr[39 - 1];
	temp[9] = arr[52 - 1];
	temp[10] = arr[53 - 1];
	temp[11] = arr[54 - 1];

	arr[1 - 1] = temp[8];
	arr[4 - 1] = temp[7];
	arr[7 - 1] = temp[6];

	arr[21 - 1] = temp[11];
	arr[24 - 1] = temp[10];
	arr[27 - 1] = temp[9];

	arr[37 - 1] = temp[3];
	arr[38 - 1] = temp[4];
	arr[39 - 1] = temp[5];

	arr[52 - 1] = temp[0];
	arr[53 - 1] = temp[1];
	arr[54 - 1] = temp[2];
	//roting right side
	temp[0] = arr[28 - 1];
	temp[1] = arr[29 - 1];
	temp[2] = arr[30 - 1];
	temp[3] = arr[31 - 1];
	temp[4] = arr[32 - 1];
	temp[5] = arr[33 - 1];
	temp[6] = arr[34 - 1];
	temp[7] = arr[35 - 1];
	temp[8] = arr[36 - 1];
	arr[28 - 1] = temp[6];
	arr[29 - 1] = temp[3];
	arr[30 - 1] = temp[0];
	arr[31 - 1] = temp[7];
	arr[32 - 1] = temp[4];
	arr[33 - 1] = temp[1];
	arr[34 - 1] = temp[8];
	arr[35 - 1] = temp[5];
	arr[36 - 1] = temp[2];
}
void Moves::MC()
{
	cur->data = 'm';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[11 - 1];
	temp[1] = arr[14 - 1];
	temp[2] = arr[17 - 1];
	temp[3] = arr[29 - 1];
	temp[4] = arr[32 - 1];
	temp[5] = arr[35 - 1];
	temp[6] = arr[38 - 1];
	temp[7] = arr[41 - 1];
	temp[8] = arr[44 - 1];
	temp[9] = arr[47 - 1];
	temp[10] = arr[50 - 1];
	temp[11] = arr[53 - 1];

	arr[11 - 1] = temp[9];
	arr[14 - 1] = temp[10];
	arr[17 - 1] = temp[11];

	arr[29 - 1] = temp[8];
	arr[32 - 1] = temp[7];
	arr[35 - 1] = temp[6];

	arr[38 - 1] = temp[0];
	arr[41 - 1] = temp[1];
	arr[44 - 1] = temp[2];

	arr[47 - 1] = temp[5];
	arr[50 - 1] = temp[4];
	arr[53 - 1] = temp[3];
}
void Moves::MA()
{

	cur->data = 'n';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[11 - 1];
	temp[1] = arr[14 - 1];
	temp[2] = arr[17 - 1];
	temp[3] = arr[29 - 1];
	temp[4] = arr[32 - 1];
	temp[5] = arr[35 - 1];
	temp[6] = arr[38 - 1];
	temp[7] = arr[41 - 1];
	temp[8] = arr[44 - 1];
	temp[9] = arr[47 - 1];
	temp[10] = arr[50 - 1];
	temp[11] = arr[53 - 1];

	arr[11 - 1] = temp[6];
	arr[14 - 1] = temp[7];
	arr[17 - 1] = temp[8];

	arr[29 - 1] = temp[11];
	arr[32 - 1] = temp[10];
	arr[35 - 1] = temp[9];

	arr[38 - 1] = temp[5];
	arr[41 - 1] = temp[4];
	arr[44 - 1] = temp[3];

	arr[47 - 1] = temp[0];
	arr[50 - 1] = temp[1];
	arr[53 - 1] = temp[2];
}
void Moves::EC()
{
	cur->data = 'o';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[4 - 1];
	temp[1] = arr[5 - 1];
	temp[2] = arr[6 - 1];
	temp[3] = arr[13 - 1];
	temp[4] = arr[14 - 1];
	temp[5] = arr[15 - 1];
	temp[6] = arr[22 - 1];
	temp[7] = arr[23 - 1];
	temp[8] = arr[24 - 1];
	temp[9] = arr[31 - 1];
	temp[10] = arr[32 - 1];
	temp[11] = arr[33 - 1];

	arr[4 - 1] = temp[3];
	arr[5 - 1] = temp[4];
	arr[6 - 1] = temp[5];

	arr[13 - 1] = temp[6];
	arr[14 - 1] = temp[7];
	arr[15 - 1] = temp[8];

	arr[22 - 1] = temp[9];
	arr[23 - 1] = temp[10];
	arr[24 - 1] = temp[11];

	arr[31 - 1] = temp[0];
	arr[32 - 1] = temp[1];
	arr[33 - 1] = temp[2];
}
void Moves::EA()
{
	cur->data = 'p';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[4 - 1];
	temp[1] = arr[5 - 1];
	temp[2] = arr[6 - 1];
	temp[3] = arr[13 - 1];
	temp[4] = arr[14 - 1];
	temp[5] = arr[15 - 1];
	temp[6] = arr[22 - 1];
	temp[7] = arr[23 - 1];
	temp[8] = arr[24 - 1];
	temp[9] = arr[31 - 1];
	temp[10] = arr[32 - 1];
	temp[11] = arr[33 - 1];

	arr[4 - 1] = temp[9];
	arr[5 - 1] = temp[10];
	arr[6 - 1] = temp[11];

	arr[13 - 1] = temp[0];
	arr[14 - 1] = temp[1];
	arr[15 - 1] = temp[2];

	arr[22 - 1] = temp[3];
	arr[23 - 1] = temp[4];
	arr[24 - 1] = temp[5];

	arr[31 - 1] = temp[6];
	arr[32 - 1] = temp[7];
	arr[33 - 1] = temp[8];
}
void Moves::SC()
{
	cur->data = 'q';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[2 - 1];
	temp[1] = arr[5 - 1];
	temp[2] = arr[8 - 1];
	temp[3] = arr[20 - 1];
	temp[4] = arr[23 - 1];
	temp[5] = arr[26 - 1];
	temp[6] = arr[40 - 1];
	temp[7] = arr[41 - 1];
	temp[8] = arr[42 - 1];
	temp[9] = arr[49 - 1];
	temp[10] = arr[50 - 1];
	temp[11] = arr[51 - 1];

	arr[2 - 1] = temp[9];
	arr[5 - 1] = temp[10];
	arr[8 - 1] = temp[11];

	arr[20 - 1] = temp[6];
	arr[23 - 1] = temp[7];
	arr[26 - 1] = temp[8];

	arr[40 - 1] = temp[2];
	arr[41 - 1] = temp[1];
	arr[42 - 1] = temp[0];

	arr[49 - 1] = temp[5];
	arr[50 - 1] = temp[4];
	arr[51 - 1] = temp[3];
}
void Moves::SA()
{
	cur->data = 'r';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	//initializing a temperary array of 12 elements
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[2 - 1];
	temp[1] = arr[5 - 1];
	temp[2] = arr[8 - 1];
	temp[3] = arr[20 - 1];
	temp[4] = arr[23 - 1];
	temp[5] = arr[26 - 1];
	temp[6] = arr[40 - 1];
	temp[7] = arr[41 - 1];
	temp[8] = arr[42 - 1];
	temp[9] = arr[49 - 1];
	temp[10] = arr[50 - 1];
	temp[11] = arr[51 - 1];

	arr[2 - 1] = temp[8];
	arr[5 - 1] = temp[7];
	arr[8 - 1] = temp[6];

	arr[20 - 1] = temp[11];
	arr[23 - 1] = temp[10];
	arr[26 - 1] = temp[9];

	arr[40 - 1] = temp[3];
	arr[41 - 1] = temp[4];
	arr[42 - 1] = temp[5];

	arr[49 - 1] = temp[0];
	arr[50 - 1] = temp[1];
	arr[51 - 1] = temp[2];
}
void Moves::AR()
{
	cur->data = 's';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[1 - 1];
	temp[1] = arr[2 - 1];
	temp[2] = arr[3 - 1];
	temp[3] = arr[10 - 1];
	temp[4] = arr[11 - 1];
	temp[5] = arr[12 - 1];
	temp[6] = arr[19 - 1];
	temp[7] = arr[20 - 1];
	temp[8] = arr[21 - 1];
	temp[9] = arr[28 - 1];
	temp[10] = arr[29 - 1];
	temp[11] = arr[30 - 1];

	arr[1 - 1] = temp[9];
	arr[2 - 1] = temp[10];
	arr[3 - 1] = temp[11];

	arr[10 - 1] = temp[0];
	arr[11 - 1] = temp[1];
	arr[12 - 1] = temp[2];

	arr[19 - 1] = temp[3];
	arr[20 - 1] = temp[4];
	arr[21 - 1] = temp[5];

	arr[28 - 1] = temp[6];
	arr[29 - 1] = temp[7];
	arr[30 - 1] = temp[8];

	temp[0] = arr[37 - 1];
	temp[1] = arr[38 - 1];
	temp[2] = arr[39 - 1];
	temp[3] = arr[40 - 1];
	temp[4] = arr[41 - 1];
	temp[5] = arr[42 - 1];
	temp[6] = arr[43 - 1];
	temp[7] = arr[44 - 1];
	temp[8] = arr[45 - 1];
	arr[37 - 1] = temp[2];
	arr[38 - 1] = temp[5];
	arr[39 - 1] = temp[8];
	arr[40 - 1] = temp[1];
	arr[41 - 1] = temp[4];
	arr[42 - 1] = temp[7];
	arr[43 - 1] = temp[0];
	arr[44 - 1] = temp[3];
	arr[45 - 1] = temp[6];

	//Moving middle layer
	temp[0] = arr[4 - 1];
	temp[1] = arr[5 - 1];
	temp[2] = arr[6 - 1];
	temp[3] = arr[13 - 1];
	temp[4] = arr[14 - 1];
	temp[5] = arr[15 - 1];
	temp[6] = arr[22 - 1];
	temp[7] = arr[23 - 1];
	temp[8] = arr[24 - 1];
	temp[9] = arr[31 - 1];
	temp[10] = arr[32 - 1];
	temp[11] = arr[33 - 1];

	arr[4 - 1] = temp[9];
	arr[5 - 1] = temp[10];
	arr[6 - 1] = temp[11];

	arr[13 - 1] = temp[0];
	arr[14 - 1] = temp[1];
	arr[15 - 1] = temp[2];

	arr[22 - 1] = temp[3];
	arr[23 - 1] = temp[4];
	arr[24 - 1] = temp[5];

	arr[31 - 1] = temp[6];
	arr[32 - 1] = temp[7];
	arr[33 - 1] = temp[8];


	temp[0] = arr[7 - 1];
	temp[1] = arr[8 - 1];
	temp[2] = arr[9 - 1];
	temp[3] = arr[16 - 1];
	temp[4] = arr[17 - 1];
	temp[5] = arr[18 - 1];
	temp[6] = arr[25 - 1];
	temp[7] = arr[26 - 1];
	temp[8] = arr[27 - 1];
	temp[9] = arr[34 - 1];
	temp[10] = arr[35 - 1];
	temp[11] = arr[36 - 1];

	arr[7 - 1] = temp[9];
	arr[8 - 1] = temp[10];
	arr[9 - 1] = temp[11];

	arr[16 - 1] = temp[0];
	arr[17 - 1] = temp[1];
	arr[18 - 1] = temp[2];

	arr[25 - 1] = temp[3];
	arr[26 - 1] = temp[4];
	arr[27 - 1] = temp[5];

	arr[34 - 1] = temp[6];
	arr[35 - 1] = temp[7];
	arr[36 - 1] = temp[8];
	//roting right side
	temp[0] = arr[46 - 1];
	temp[1] = arr[47 - 1];
	temp[2] = arr[48 - 1];
	temp[3] = arr[49 - 1];
	temp[4] = arr[50 - 1];
	temp[5] = arr[51 - 1];
	temp[6] = arr[52 - 1];
	temp[7] = arr[53 - 1];
	temp[8] = arr[54 - 1];
	arr[46 - 1] = temp[6];
	arr[47 - 1] = temp[3];
	arr[48 - 1] = temp[0];
	arr[49 - 1] = temp[7];
	arr[50 - 1] = temp[4];
	arr[51 - 1] = temp[1];
	arr[52 - 1] = temp[8];
	arr[53 - 1] = temp[5];
	arr[54 - 1] = temp[2];
}
void Moves::AL()
{
	cur->data = 't';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[1 - 1];
	temp[1] = arr[2 - 1];
	temp[2] = arr[3 - 1];
	temp[3] = arr[10 - 1];
	temp[4] = arr[11 - 1];
	temp[5] = arr[12 - 1];
	temp[6] = arr[19 - 1];
	temp[7] = arr[20 - 1];
	temp[8] = arr[21 - 1];
	temp[9] = arr[28 - 1];
	temp[10] = arr[29 - 1];
	temp[11] = arr[30 - 1];

	arr[1 - 1] = temp[3];
	arr[2 - 1] = temp[4];
	arr[3 - 1] = temp[5];

	arr[10 - 1] = temp[6];
	arr[11 - 1] = temp[7];
	arr[12 - 1] = temp[8];

	arr[19 - 1] = temp[9];
	arr[20 - 1] = temp[10];
	arr[21 - 1] = temp[11];

	arr[28 - 1] = temp[0];
	arr[29 - 1] = temp[1];
	arr[30 - 1] = temp[2];
	//roting right side
	temp[0] = arr[37 - 1];
	temp[1] = arr[38 - 1];
	temp[2] = arr[39 - 1];
	temp[3] = arr[40 - 1];
	temp[4] = arr[41 - 1];
	temp[5] = arr[42 - 1];
	temp[6] = arr[43 - 1];
	temp[7] = arr[44 - 1];
	temp[8] = arr[45 - 1];
	arr[37 - 1] = temp[6];
	arr[38 - 1] = temp[3];
	arr[39 - 1] = temp[0];
	arr[40 - 1] = temp[7];
	arr[41 - 1] = temp[4];
	arr[42 - 1] = temp[1];
	arr[43 - 1] = temp[8];
	arr[44 - 1] = temp[5];
	arr[45 - 1] = temp[2];


	//Movving middle layer
	temp[0] = arr[4 - 1];
	temp[1] = arr[5 - 1];
	temp[2] = arr[6 - 1];
	temp[3] = arr[13 - 1];
	temp[4] = arr[14 - 1];
	temp[5] = arr[15 - 1];
	temp[6] = arr[22 - 1];
	temp[7] = arr[23 - 1];
	temp[8] = arr[24 - 1];
	temp[9] = arr[31 - 1];
	temp[10] = arr[32 - 1];
	temp[11] = arr[33 - 1];

	arr[4 - 1] = temp[3];
	arr[5 - 1] = temp[4];
	arr[6 - 1] = temp[5];

	arr[13 - 1] = temp[6];
	arr[14 - 1] = temp[7];
	arr[15 - 1] = temp[8];

	arr[22 - 1] = temp[9];
	arr[23 - 1] = temp[10];
	arr[24 - 1] = temp[11];

	arr[31 - 1] = temp[0];
	arr[32 - 1] = temp[1];
	arr[33 - 1] = temp[2];



	temp[0] = arr[7 - 1];
	temp[1] = arr[8 - 1];
	temp[2] = arr[9 - 1];
	temp[3] = arr[16 - 1];
	temp[4] = arr[17 - 1];
	temp[5] = arr[18 - 1];
	temp[6] = arr[25 - 1];
	temp[7] = arr[26 - 1];
	temp[8] = arr[27 - 1];
	temp[9] = arr[34 - 1];
	temp[10] = arr[35 - 1];
	temp[11] = arr[36 - 1];

	arr[7 - 1] = temp[3];
	arr[8 - 1] = temp[4];
	arr[9 - 1] = temp[5];

	arr[16 - 1] = temp[6];
	arr[17 - 1] = temp[7];
	arr[18 - 1] = temp[8];

	arr[25 - 1] = temp[9];
	arr[26 - 1] = temp[10];
	arr[27 - 1] = temp[11];

	arr[34 - 1] = temp[0];
	arr[35 - 1] = temp[1];
	arr[36 - 1] = temp[2];
	//roting right side
	temp[0] = arr[46 - 1];
	temp[1] = arr[47 - 1];
	temp[2] = arr[48 - 1];
	temp[3] = arr[49 - 1];
	temp[4] = arr[50 - 1];
	temp[5] = arr[51 - 1];
	temp[6] = arr[52 - 1];
	temp[7] = arr[53 - 1];
	temp[8] = arr[54 - 1];
	arr[46 - 1] = temp[2];
	arr[47 - 1] = temp[5];
	arr[48 - 1] = temp[8];
	arr[49 - 1] = temp[1];
	arr[50 - 1] = temp[4];
	arr[51 - 1] = temp[7];
	arr[52 - 1] = temp[0];
	arr[53 - 1] = temp[3];
	arr[54 - 1] = temp[6];
}
void Moves::AU()
{
	cur->data = 'u';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[10 - 1];
	temp[1] = arr[13 - 1];
	temp[2] = arr[16 - 1];
	temp[3] = arr[30 - 1];
	temp[4] = arr[33 - 1];
	temp[5] = arr[36 - 1];
	temp[6] = arr[37 - 1];
	temp[7] = arr[40 - 1];
	temp[8] = arr[43 - 1];
	temp[9] = arr[46 - 1];
	temp[10] = arr[49 - 1];
	temp[11] = arr[52 - 1];

	arr[37 - 1] = temp[0];
	arr[40 - 1] = temp[1];
	arr[43 - 1] = temp[2];

	arr[10 - 1] = temp[9];
	arr[13 - 1] = temp[10];
	arr[16 - 1] = temp[11];

	arr[30 - 1] = temp[8];
	arr[33 - 1] = temp[7];
	arr[36 - 1] = temp[6];

	arr[46 - 1] = temp[5];
	arr[49 - 1] = temp[4];
	arr[52 - 1] = temp[3];
	//roting right side
	temp[0] = arr[1 - 1];
	temp[1] = arr[2 - 1];
	temp[2] = arr[3 - 1];
	temp[3] = arr[4 - 1];
	temp[4] = arr[5 - 1];
	temp[5] = arr[6 - 1];
	temp[6] = arr[7 - 1];
	temp[7] = arr[8 - 1];
	temp[8] = arr[9 - 1];
	arr[1 - 1] = temp[2];
	arr[2 - 1] = temp[5];
	arr[3 - 1] = temp[8];
	arr[4 - 1] = temp[1];
	arr[5 - 1] = temp[4];
	arr[6 - 1] = temp[7];
	arr[7 - 1] = temp[0];
	arr[8 - 1] = temp[3];
	arr[9 - 1] = temp[6];


	temp[0] = arr[11 - 1];
	temp[1] = arr[14 - 1];
	temp[2] = arr[17 - 1];
	temp[3] = arr[29 - 1];
	temp[4] = arr[32 - 1];
	temp[5] = arr[35 - 1];
	temp[6] = arr[38 - 1];
	temp[7] = arr[41 - 1];
	temp[8] = arr[44 - 1];
	temp[9] = arr[47 - 1];
	temp[10] = arr[50 - 1];
	temp[11] = arr[53 - 1];

	arr[11 - 1] = temp[9];
	arr[14 - 1] = temp[10];
	arr[17 - 1] = temp[11];

	arr[29 - 1] = temp[8];
	arr[32 - 1] = temp[7];
	arr[35 - 1] = temp[6];

	arr[38 - 1] = temp[0];
	arr[41 - 1] = temp[1];
	arr[44 - 1] = temp[2];

	arr[47 - 1] = temp[5];
	arr[50 - 1] = temp[4];
	arr[53 - 1] = temp[3];

	temp[0] = arr[12 - 1];
	temp[1] = arr[15 - 1];
	temp[2] = arr[18 - 1];
	temp[3] = arr[28 - 1];
	temp[4] = arr[31 - 1];
	temp[5] = arr[34 - 1];
	temp[6] = arr[39 - 1];
	temp[7] = arr[42 - 1];
	temp[8] = arr[45 - 1];
	temp[9] = arr[48 - 1];
	temp[10] = arr[51 - 1];
	temp[11] = arr[54 - 1];

	arr[12 - 1] = temp[9];
	arr[15 - 1] = temp[10];
	arr[18 - 1] = temp[11];

	arr[39 - 1] = temp[0];
	arr[42 - 1] = temp[1];
	arr[45 - 1] = temp[2];

	arr[28 - 1] = temp[8];
	arr[31 - 1] = temp[7];
	arr[34 - 1] = temp[6];

	arr[54 - 1] = temp[3];
	arr[51 - 1] = temp[4];
	arr[48 - 1] = temp[5];
	//roting right side
	temp[0] = arr[19 - 1];
	temp[1] = arr[20 - 1];
	temp[2] = arr[21 - 1];
	temp[3] = arr[22 - 1];
	temp[4] = arr[23 - 1];
	temp[5] = arr[24 - 1];
	temp[6] = arr[25 - 1];
	temp[7] = arr[26 - 1];
	temp[8] = arr[27 - 1];
	arr[19 - 1] = temp[6];
	arr[20 - 1] = temp[3];
	arr[21 - 1] = temp[0];
	arr[22 - 1] = temp[7];
	arr[23 - 1] = temp[4];
	arr[24 - 1] = temp[1];
	arr[25 - 1] = temp[8];
	arr[26 - 1] = temp[5];
	arr[27 - 1] = temp[2];
}
void Moves::AD()
{
	cur->data = 'v';
	cur->next = new node;
	cur = cur->next;
	cur->next = NULL;
	int temp[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
	temp[0] = arr[10 - 1];
	temp[1] = arr[13 - 1];
	temp[2] = arr[16 - 1];
	temp[3] = arr[30 - 1];
	temp[4] = arr[33 - 1];
	temp[5] = arr[36 - 1];
	temp[6] = arr[37 - 1];
	temp[7] = arr[40 - 1];
	temp[8] = arr[43 - 1];
	temp[9] = arr[46 - 1];
	temp[10] = arr[49 - 1];
	temp[11] = arr[52 - 1];

	arr[37 - 1] = temp[5];
	arr[40 - 1] = temp[4];
	arr[43 - 1] = temp[3];

	arr[10 - 1] = temp[6];
	arr[13 - 1] = temp[7];
	arr[16 - 1] = temp[8];

	arr[30 - 1] = temp[11];
	arr[33 - 1] = temp[10];
	arr[36 - 1] = temp[9];

	arr[46 - 1] = temp[0];
	arr[49 - 1] = temp[1];
	arr[52 - 1] = temp[2];
	//roting right side
	temp[0] = arr[1 - 1];
	temp[1] = arr[2 - 1];
	temp[2] = arr[3 - 1];
	temp[3] = arr[4 - 1];
	temp[4] = arr[5 - 1];
	temp[5] = arr[6 - 1];
	temp[6] = arr[7 - 1];
	temp[7] = arr[8 - 1];
	temp[8] = arr[9 - 1];
	arr[1 - 1] = temp[6];
	arr[2 - 1] = temp[3];
	arr[3 - 1] = temp[0];
	arr[4 - 1] = temp[7];
	arr[5 - 1] = temp[4];
	arr[6 - 1] = temp[1];
	arr[7 - 1] = temp[8];
	arr[8 - 1] = temp[5];
	arr[9 - 1] = temp[2];


	temp[0] = arr[11 - 1];
	temp[1] = arr[14 - 1];
	temp[2] = arr[17 - 1];
	temp[3] = arr[29 - 1];
	temp[4] = arr[32 - 1];
	temp[5] = arr[35 - 1];
	temp[6] = arr[38 - 1];
	temp[7] = arr[41 - 1];
	temp[8] = arr[44 - 1];
	temp[9] = arr[47 - 1];
	temp[10] = arr[50 - 1];
	temp[11] = arr[53 - 1];

	arr[11 - 1] = temp[6];
	arr[14 - 1] = temp[7];
	arr[17 - 1] = temp[8];

	arr[29 - 1] = temp[11];
	arr[32 - 1] = temp[10];
	arr[35 - 1] = temp[9];

	arr[38 - 1] = temp[5];
	arr[41 - 1] = temp[4];
	arr[44 - 1] = temp[3];

	arr[47 - 1] = temp[0];
	arr[50 - 1] = temp[1];
	arr[53 - 1] = temp[2];


	temp[0] = arr[12 - 1];
	temp[1] = arr[15 - 1];
	temp[2] = arr[18 - 1];
	temp[3] = arr[28 - 1];
	temp[4] = arr[31 - 1];
	temp[5] = arr[34 - 1];
	temp[6] = arr[39 - 1];
	temp[7] = arr[42 - 1];
	temp[8] = arr[45 - 1];
	temp[9] = arr[48 - 1];
	temp[10] = arr[51 - 1];
	temp[11] = arr[54 - 1];

	arr[12 - 1] = temp[6];
	arr[15 - 1] = temp[7];
	arr[18 - 1] = temp[8];

	arr[39 - 1] = temp[5];
	arr[42 - 1] = temp[4];
	arr[45 - 1] = temp[3];

	arr[28 - 1] = temp[11];
	arr[31 - 1] = temp[10];
	arr[34 - 1] = temp[9];

	arr[54 - 1] = temp[2];
	arr[51 - 1] = temp[1];
	arr[48 - 1] = temp[0];
	//roting right side
	temp[0] = arr[19 - 1];
	temp[1] = arr[20 - 1];
	temp[2] = arr[21 - 1];
	temp[3] = arr[22 - 1];
	temp[4] = arr[23 - 1];
	temp[5] = arr[24 - 1];
	temp[6] = arr[25 - 1];
	temp[7] = arr[26 - 1];
	temp[8] = arr[27 - 1];
	arr[19 - 1] = temp[2];
	arr[20 - 1] = temp[5];
	arr[21 - 1] = temp[8];
	arr[22 - 1] = temp[1];
	arr[23 - 1] = temp[4];
	arr[24 - 1] = temp[7];
	arr[25 - 1] = temp[0];
	arr[26 - 1] = temp[3];
	arr[27 - 1] = temp[6];
}

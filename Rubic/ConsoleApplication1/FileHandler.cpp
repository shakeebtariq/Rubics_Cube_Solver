#include"FileHandler.h"
FileHandler::FileHandler()
{
	 addressOfInput = "array.txt";
	 addressOfOutput = "output.txt";
	//cout << "Object of 'FileHandler' Class is created" << endl;
}
void FileHandler::eraseText(char FileName)
{
	if (FileName == 'i')
	{
		ofstream deleteText(addressOfInput);
		deleteText << "\0";
	}
	else
	{
		ofstream deleteText(addressOfOutput);
		deleteText << "\0";
	}
}
void FileHandler::reader()
{
	fstream file1(addressOfInput, ios::out | ios::in | ios::app);
	string var;
	file1 >> var;
	for (int i = 0; i < 54; i++)
	{
		arr[i] = var[i] - '0';
	}
	//eraseText('i');
}
void FileHandler::writter_(node *cur)
{
	eraseText('o');
	while (cur->next != NULL)
	{
		fstream file1("output.txt", ios::out | ios::in | ios::app);
		file1 << cur->data;
		cur = cur->next;
	}
}
void FileHandler::displayArray()
{
	for (int i = 0; i < 54; i++)
	{
		//cout << "arr[" << i << "]=" << arr[i] << endl;
		cout << arr[i];
	}
	cout << endl;
}

FileHandler::~FileHandler()
{
	//cout << "Destructor of File handler class is called" << endl;
}
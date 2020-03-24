#pragma once
#include <iostream>
#include <string>
#include <vector>

using namespace std;

class Row
{
	string row;
public:
	Row()
	{
		row = "";
	}
	Row(string r)
	{
		row = r;
	}
	char operator[] (const int index)
	{
		return row[index];
	}
	int length()
	{
		return row.length();
	}
	void set(string r)
	{
		row = r;
	}
	string get()
	{
		return row;
	}
};
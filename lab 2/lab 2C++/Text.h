#pragma once
#include "Row.h";
class Text
{
	vector <Row> rows;
public:
	Text(Row r)
	{
		rows.push_back(r);
	}
	void addIt(Row r)
	{
		rows.push_back(r);
	}
	void deleteLast()
	{
		rows.pop_back();
	}
	void clearIt()
	{
		rows.clear();
	}
	string operator[] (const int index)
	{
		Row temp = rows[index];
		return temp.get();
	}
	float symFreq(char ch)
	{
		Row temp;
		float frequency = 0;
		float counter = 0;
		for (int i = 0; i < rows.size(); i++)
		{
			temp.set(rows[i].get());
			for (int j = 0; j < temp.length(); j++)
			{
				counter++;
				if (temp[j] == ch) {
					frequency++;
				}
			}
		}
		return frequency / counter;
	}
	void deleteIt(int ind)
	{
		rows.erase(rows.begin() + ind);
	}
	void replace(int ind, Row r)
	{
		rows[ind] = r;
	}
	void deleteDublicate()
	{
		bool flag = false;
		string temp;
		for (int i = 0; i < rows.size(); i++)
		{
			temp = rows[i].get();
			for (int j = i; j < rows.size(); j++)
			{
				for (int k = 0; k < temp.length() && k < rows[j].get().length(); k++)
				{
					if (temp[k] != rows[j].get()[k])
					{
						flag = true;
					}
				}
			}
			if (!flag)
			{
				deleteIt(i);
			}
			flag = false;
		}
	}
	void Show()
	{
		cout << "--------------------------------------" << endl;
		for (int i = 0; i < rows.size(); i++)
		{
			cout << rows[i].get() << endl;
		}
		cout << "--------------------------------------" << endl;
	}
};
#include "Row.h"
#include "Text.h"

int main()
{
	int del;
	char ask;
	Row first("There once was a boy named Harry");
	Row second("Destined to be a star");
	Row third("His parents were killed by Voldemort");
	Row fourth("Who gave him a lightning scar");
	Text text (first);
	text.addIt(second);
	text.addIt(third);
	text.addIt(fourth);
	cout << "Strings we added:" << endl;
	text.Show();
	cout << "Enter symbol to search it's frequency - "; cin >> ask;
	cout << text.symFreq(ask) * 100 << '%' << endl;
	cout << "Enter which row to delete - " << endl; cin >> del;
	text.deleteIt(del-1);
	text.Show();
	cout << "Entering first row to last row" << endl;
	text.addIt(first);
	text.Show();
	cout << "Delete string dublicates" << endl;
	text.deleteDublicate();
	text.Show();
	return 0;
}

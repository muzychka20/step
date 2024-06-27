#pragma once
#include <vector>
#include <fstream>
#include "MobilePhone.h"

using namespace std;

class RepairService
{
private:
	vector<MobilePhone> listRepairment;

public:
	void addPhoneForRepair(MobilePhone phone);
	int findIndexPhoneById(int id);
	int changeStatusOfRepairByID(int id);
	void changeStatusAndDelete();
	void showInfoListRepairment();
	void registerPhone();
	void saveInFileListRepairment();
	void uploadFromFileListRepairment();
};
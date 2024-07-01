#include <conio.h>
#include "App.h"
#include "RepairService.h"
#include "Menu.h"

void App::realisationMainMenu()
{
	Menu menu;
	RepairService service;
	char choose;

	while (true)
	{
		menu.showMainMenu();

		choose = _getche();

		system("cls");

		switch (choose)
		{
		case '1':		
			service.registerPhone();			
			break;		
		case '2':					
			service.changeStatusAndDelete();			
			break;		
		case '3':		
			service.showInfoListRepairment();			
			break;	
		case '4':
			service.saveInFileListRepairment();
			break;
		case '5':
			service.uploadFromFileListRepairment();
			break;
		case 27:
			exit(0);
		}

		_getche();
	}
}

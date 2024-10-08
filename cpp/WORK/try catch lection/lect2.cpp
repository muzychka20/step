// ��� �������� ��������� ���������� :
// �������� ���������� : ����� � ����� try ������������ ����������, 
// ���������� ����� �����������, � C++ �������� ����� ����������� ����� catch ������� �� ����� try 
// � �������� ����� �� ����� �������.��� ������������ ����������������� � ������������� ���������� ��������.

// ��������� ������� ������ catch : 
// ����� ���������� ��������� ������ catch ��� ��������� ��������� ����� ����������.
// ��� ��������� ����� ����� ��������� ��������� ������, ������������ ������������������ ����������� ��� ������� ���� ����������.

try {
    // ���, ������� ����� ������������ ������ ���� ����������
    riskyFunction();
}
catch (const invalid_argument& e) {
    cerr << "Invalid argument error: " << e.what() << endl;
    // ������������� ��������� ��� invalid_argument
}
catch (const out_of_range& e) {
    cerr << "Out of range error: " << e.what() << endl;
    // ������������� ��������� ��� out_of_range
}
catch (...) {
    cerr << "Unknown exception caught" << endl;
    // ��������� ���� ����������� ����� ����������
}

// � ���� �������, ���� riskyFunction() ���������� invalid_argument, 
// ����� �������� ������ ���� catch.���� ��������� out_of_range, 
// ��������� ��������� �� ������� �����.���� catch (...) ������������� ��� ���� ����������, 
// ������� �� ���� ����������� ����������� �������.

// ��������� � �������� ���������� :
// ��������� ���������� �� �������������� ������ ������������ ��� ������� ���������� ������������.
// �� ������ ��������������� ��������� ���������, ����������� �������,
//  ��������� ��������������� �������� � ���� �������� ������������ ���������� ��� ���������� ���������.
// ��� ������ �������� ���������� ������ ������������ ��� ���������� �������� ����������.
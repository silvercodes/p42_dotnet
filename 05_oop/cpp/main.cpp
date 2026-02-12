#include <iostream>
#include <string>


//void Execute()
//{
//    Role a;
//    a.id = 101;
//    a.level = 3;
//
//    User* b = new User();
//    b->id = 202;
//    b->role.id = 102;
//    b->role.level = 2;
//
//    Role c = a;
//    User* d = b;
//}
//
//int main()
//{
//    Execute();
//
//    return 0;
//}
//
//
//struct Role
//{
//public:
//    int id;
//    int level;
//};
//
//class User
//{
//public:
//    int id;
//    Role role;
//};






//void Execute()
//{
//    Role* a = new Role{};
//
//    User b{};
//
//    Role* c = a;
//    User d = b;
//}
//
//int main()
//{
//    Execute();
//
//    return 0;
//}
//
//
//class Role
//{
//public:
//    int id;
//    int level;
//};
//
//struct User
//{
//public:
//    int id;
//    Role* role;
//};




class User
{
private:
	int id;
	std::string email;

public:
	int getId() const
	{
		return this->id;
	}
	void setId(int id)
	{
		this->id = id;
	}
};
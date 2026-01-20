
#region Base operators

// +  -  *  /  %

// ++  --

// &    |    ^    ~    <<    >>

// =    +=  -=  *=  /=  %=      &=  |=  ^=  ~=  <<=  >>=

//byte a = 255;               // 11111111
//byte b = (byte)(a + 1);     //100000000

// ==   !=    <     >       <=      >=

// &&(сокращённое)  &(полное)  ||(сокращённое)  |(полное)       !

//int a = 4;
//int b = 5;

//bool res1 = (a > b) && (a < b);
//bool res2 = (a > b) & (a < b);

//bool res3 = (a > b) || (a < b);
//bool res4 = (a > b) | (a < b);


#endregion

#region Operators


//if (<condition>)
//{

//}
//else if (<condition 2>)
//{

//}
//else
//{

//}


//int a = 3;
//int b = a > 0 ? 1 : 0;

#endregion

#region Cycles

// for  do/while    while   foreach
//for (int i = 0; i < 100; ++i)
//{
//    // break;
//    // continue;
//}

//for(; ; )
//{

//}

//int i = 10;
//do
//{
//    //
//    //
//    --i;
//} while (i > 0);

//int j = 10;
//while(j > 0)
//{
//    //
//    //
//    --j;
//}


//foreach(variable in enumerable)
//{

//}

string email = "vasia@mail.com";
foreach(char c in email)
    Console.WriteLine(c);


#endregion

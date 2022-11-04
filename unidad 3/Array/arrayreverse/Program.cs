//int i, n;
//int[] a = new int[100];


//Console.WriteLine(" Read n number of values in an array and display");
//n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("input{0} number of elements in the array",n);
//for ( i = 0; i < n; i++)
//{
//    Console.WriteLine("element - {0} :", i);
//    a[i] = Convert.ToInt32(Console.ReadLine()); 
//}


//Console.WriteLine(" the values store into the array are ");
//for ( i = 0; i < n; i++)
//{
//    Console.WriteLine("{0}", a[i]);
//}


//Console.WriteLine(" the values store into the array in reverse are");
//for ( i =n -1; i >=0; i--)
//{
//    Console.WriteLine("{0}", a[i]);

//}


// sum of elements


//int[] a= new int[100];
//int i, n , sum= 0;

//Console.WriteLine("find sum of all elements of array");

//Console.WriteLine(" input the number of elements to be store in array");
//n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine( "Input {0} element in array", n );
//for ( i = 0; i < n; i++)
//{
//    Console.WriteLine("element - {0}", i);
//    a[i] = Convert.ToInt32(Console.ReadLine());
//}

//for (i = 0; i < n; i++)
//{
//    sum += a[i];
//}

//Console.WriteLine( "sum of all elements stored in the array is :{0}", sum );


int[] miArray = new int[5];


Console.WriteLine("Input the number of elements to store in array ");
int cantidadElemnt = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" input {0} number of elements in the array;", cantidadElemnt );

for (int i = 0; i < cantidadElemnt; i++)
{
    Console.WriteLine("element - {0}", i);
    miArray[i] = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine(" search for ?");
int numberSearch = Convert.ToInt32(Console.ReadLine());

bool encontrado = false;

for ( int i = 0; i < cantidadElemnt; i++)
{
    if (miArray[i] == numberSearch)
    {
        Console.WriteLine("index is {0}", i);
        encontrado = true;
         break;
    }
   
}


if (!encontrado)
{
    Console.WriteLine("you number {0} is not found", numberSearch);
}






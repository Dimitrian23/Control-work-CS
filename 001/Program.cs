// Написать программу, которая из имеющегося массива строк формирует массив из сторок, длина которых
// меньше либо равна 3 символа. Первоначально массив можно ввести с клавиатуру, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,лучше обойтись исключительно массивами. 

string [] arr=new string [6];          
arr[0]="FFFFF";                             
arr[1]="AA";                                
arr[2]="QQQ";                               
arr[3]="RRRRRRR";                           
arr[4]="WWWWWW";                            
arr[5]="P";                                 
string [] arr2=new string [0];  

void PrintArr(string[]arr)
{
    for (int i = 0; i<arr.Length; i++)
    {
          System.Console.Write($" {arr[i]}");  
    }
}

void OperationArr(string[]arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
       if (arr[j].Length<=3)
        {
          System.Console.Write($" {arr[j]}");  
        }
    }

}

System.Console.Write("Первоначальный массив");
PrintArr(arr);
System.Console.WriteLine();
System.Console.Write("То из чего надо создать новый массив");
OperationArr(arr);



























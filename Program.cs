int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



int [,] GenerateArray2DDD(int rows, int columns,int min, int max)
{
    
    int [,] numbers = new int [rows, columns];
    Random rnd = new Random ();
    
    for (int i = 0; i <numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           numbers[i,j] = rnd.Next (min,max +1) ;
         
    }
    }
    return numbers;
}

void PrintArray2D(int [,] numbers)
{

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
         
         System.Console.Write($"{numbers[i,j]}\t"); 

        }
        System.Console.WriteLine();
       
        
    }

}


double [] poisk( int[,] numbers) 
{
    double [] number = new double [numbers.GetLength(1)];
 double num=0;
   
    for (int i = 0; i <numbers.GetLength(1); i++)
    {
        num=0;
       
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
          num = num+numbers[j,i];
          
        }
        number[i] = num/numbers.GetLength(0);
    }
   
    return number;
}
void PrintArray2(double [] number)
{
    for (int i = 0; i < number.Length; i++)
    {
       
          System.Console.Write($"{number[i]}\t" ); 
          
        }

       System.Console.WriteLine(); 
}


int[,] array = GenerateArray2DDD(4,5,0,6);

PrintArray2D(array);

double [] rin = poisk( array) ;
PrintArray2(rin);
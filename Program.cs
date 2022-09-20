int[] CreateRandomArray (int numbers){
    int count=1;
    int[] array=new int [numbers];
    for (int i=0; i<array.Length;i++){
        array[i]=count;
        count++;
    }
    return array; 
    }

void ShowArray (int [] array){
    for (int i=0; i<array.GetLength(0);i++){
        
            Console.Write(array[i]+" ");
    }
    Console.WriteLine(" ");
}

void Sum (int [] array){
    int sum =0;
    for (int i=0; i<array.Length;i++){
        sum+=array[i];
                } 
    Console.WriteLine($"Sum of numbers of array is: {sum}");
        }

Console.WriteLine("Input number : ");
int numbers=Convert.ToInt32(Console.ReadLine());


int [] arr=CreateRandomArray(numbers);
Console.WriteLine("Array:");
ShowArray(arr);
Console.WriteLine("");
Sum(arr);
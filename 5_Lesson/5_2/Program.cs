void Print (int[] array) 
{ 
    int size = array.Length; 
    for(int i=0; i<size; i++) 
    { 
        Console.Write($"{array[i]} "); 
 
    } 
    Console.WriteLine(); 
} 
 
int [] MassNums (int size) 
{ 
    int [] array = new int [size]; 
    for(int i=0;i<size; i++) 
    { 
        array[i] = new Random().Next(-9,10); 
    } 
    return array; 
} 
 
int [] Zamena(int [] revers) 
{ 
    for (int i=0; i<revers.Length; i++) 
    { 
        if (revers[i]<0) 
        { 
            revers[i] = revers[i] * -1; 
        } 
        else 
        { 
            revers[i] = revers[i] * -1; 
        } 
         
    } 
    return revers;
    
} 
 
int [] array_1= MassNums(12); 
Print (array_1); 
int [] array_2 = Zamena(array_1); 
Print(array_2);
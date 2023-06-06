Console.Clear();


int [] MakeArray(){
        Console.Write("insert the length: ");
        int len = int.Parse(Console.ReadLine()!);
    int []arr=new int [len];
    for (int i=0;i<len;i++){
    arr[i]=new Random().Next(100,1000);    
    }
    return arr;
}

void AllEvens(int []array){
    int count=0;
    foreach(int elem in array){
        if(elem%2==0)count++;
    }
Console.WriteLine($"in the array {count} even numbers");

}
int []arr= MakeArray();
Console.WriteLine(string.Join(",",arr));
AllEvens(arr);

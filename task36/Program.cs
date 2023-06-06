int [] MakeArray(){
    int []arr=new int [new Random().Next(4,14)];
    for (int i=0;i<arr.Length;i++){
    arr[i]=new Random().Next(1,100);    
    }
    return arr;
}
void OddSum(int []arr){
    int sum=0;
    for(int i=1;i<arr.Length;i+=2)sum+=arr[i];
    Console.WriteLine($"the sum of odd index elements of [{string.Join(",",arr)}] array is {sum}");
}

Console.Clear();
int []arr=MakeArray();

OddSum(arr);
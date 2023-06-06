int [] ArrayMaker(){
    int [] arr=new int [new Random().Next(1,101)];
    for(int i=0; i<arr.Length;i++){
        arr[i]=new Random().Next(1,32);
    }
    return arr;
}
void CompareGrade(int []arr){
    int odd=0;
    int even=0;
    foreach(int el in arr){
        if(el%2==0){
            even++;
            Console.Write($"{el}, ");
    }
    }
    Console.WriteLine();
    foreach(int el in arr){
        if(el%2!=0){
            odd++;
            Console.Write($"{el}, ");
    }
    }
    if(odd>even)Console.WriteLine("yeah");
    else Console.WriteLine("nah");


}
int [] arr= ArrayMaker();
CompareGrade(arr);
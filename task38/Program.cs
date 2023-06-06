double [] GetRArray(){
    double[] arr=new double[new Random().Next(3,10) ];
    for (int i=0;i<arr.Length;i++){
        arr[i]=Math.Round(new Random().NextDouble()*99,2); //[0;99]
    }
    return arr;
}

void ExtremDiff(double [] arr){
    double max=0;
    double min=arr[0];
    foreach(double el in arr){
        if(el>max)max=el;
        else if (el<min)min=el;
    }
    Console.WriteLine($"the difference between extremums {max} and {min} of array [{string.Join("; ",arr)}] is {Math.Round(max-min,2)}");
}
Console.Clear();
double [] arr=GetRArray();
ExtremDiff(arr);
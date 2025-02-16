using _dynamic_arr;
using car_info;
using dynamic2;


dynamic arr1;
arr1 = new dynamic();
dynamic_2 arr2;
arr2 = new dynamic_2();


cars[] car1 = new cars[10];

for(int i = 0; i< car1.Length-5; i++)

{  car1[i] = new cars();
    arr2.add("honda") ;
    car1[i].name = "civic";
    arr1.add(i + 1);
}


for (int i = car1.Length - 5; i < car1.Length - 2; i++)

{
    car1[i] = new cars();
    arr2.add("toyota");
    car1[i].name = "corolla";
    arr1.add(i+1);
}

for (int i = car1.Length - 2; i < car1.Length; i++)

{
    car1[i] = new cars();
    arr2.add("nissan");
    car1[i].name = "sunny";
    arr1.add(i+1) ;
}

for(int i = 0; i< car1.Length; i++)
{
    Console.WriteLine($"{arr2.array[i]} " + $"{car1[i].name} " + $"{9989+ arr1.arr[i]} ");
}

/*
using _dynamic_arr;

dynamic arr1;
arr1 = new dynamic();

arr1.add(1);
arr1.add(2);
arr1.add(3);
arr1.add(4);
arr1.add(5);




for (int i = 0; i < arr1.counter; i++)
{
    Console.WriteLine(arr1.arr[i]);
}*/
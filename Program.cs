void MassData(int[,] mass, int y, int x){
    int d = 0;
    for(int i = 0; i < mass.GetLength(0); i++){ 
        for(int a = 0; a < mass.GetLength(1); a++){
            mass[i, a] = new Random().Next(-30, 30);
            if(a == x & i == y) {
                d = mass[i, a];
            }
        }    
    } 
    EchoMass(mass);
    Console.Write("Итог: " + Convert.ToString(d));
}

Console.WriteLine("Введите m число длинны массива Y: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n число длинны массива X: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты элемента в массиве по оси y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты элемента в массиве по оси x: ");
int x = Convert.ToInt32(Console.ReadLine());

int[,] mass = new int[m, n];

if(y >= mass.GetLength(0) || x >= mass.GetLength(1) || y < 0 || x < 0){
    Console.Write("Такого элемента нет");
}
else{
    MassData(mass, y, x);
}




void EchoMass(int[,] mass){
    for(int i = 0; i < mass.GetLength(0); i++){
        for(int a = 0; a < mass.GetLength(1); a++){
           Console.Write(Convert.ToString(mass[i, a]) + " ");
        } 
        Console.WriteLine();   
    }     
}




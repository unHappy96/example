/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double Promt(string massage) {
    Console.WriteLine(massage);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

double[] Input(int y){
    double[] number = new double[2];
    number[0] = Promt($"Введите коэффицент для {y} прямой");
    number[1] = Promt($"Введите константу для {y} прямой");
    return number;
}

double findX(double[] arg1, double[] arg2){
    double x = (arg2[1]-arg1[1])/(arg1[0]-arg2[0]);
    return x;
}

double findY(double arg1, double[] arg2){
    double y = arg2[0] * arg1 + arg2[1];
    return y;
}

void Print(double arg1, double arg2, double[] arg3, double[] arg4){
    Console.WriteLine($"x = {arg1}");
    Console.WriteLine($"y = {arg2}");
        if (arg1 == arg2){
        Console.WriteLine("Прямые пересекаются");
    } else if (arg3[0]==arg4[0] && arg3[1]==arg4[1]){
        Console.WriteLine("Прямые параллельны");
    } else {
        Console.WriteLine("Прямые не пересекаются");
    }
}

double[] value1 = Input(1);
double[] value2 = Input(2);

double x = findX(value1,value2);
double y = findY(x, value1);

Print(x,y,value1,value2);
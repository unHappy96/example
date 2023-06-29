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

double[] value1 = Input(1);
double[] value2 = Input(2);

double x = findX(value1,value2);
double y = findY(x, value1);

Console.WriteLine(x);
Console.WriteLine(y);
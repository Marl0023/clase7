Console.Write("Ingrese el numero de empleados que desea ingresar: ");
int num= int.Parse(Console.ReadLine());
double sumaSueldo = 0;
double contE1 = 0;
double contE2 = 0;
for (int i = 0; i < num; i++) {
    string nombre = "";
    double salario = 0, faltas = 0, salarioFinal = 0;
    Console.Write("Ingrese su nombre completo: ");
    nombre = Console.ReadLine();
    Console.WriteLine("Ingrese su salario");
    salario = double.Parse(Console.ReadLine());
    Console.Write("Ingrese las faltas (1 mes = 30 dias): ");
    faltas = double.Parse(Console.ReadLine());
    salarioFinal = ((30 - faltas) * salario) / 30;
    Console.WriteLine($"\nEl empleado {nombre}, su salario final es {salarioFinal}");
    sumaSueldo += salarioFinal;
    if (salarioFinal <= 3500 && salarioFinal >= 2500) {
        contE1++;
    }
    if (salarioFinal < 1000 || salarioFinal > 4000) { 
        contE2++;
    }
}
Console.WriteLine($"La suma de todos los salarios de los empleados es de {sumaSueldo}");
Console.WriteLine($"El numero de empleados que ganan entre 2500 y 3500 es de {contE1} empleados");
Console.WriteLine($"El numero de empleados que ganan menos de 1000 o mas de 4000 es de {contE2} empleados");

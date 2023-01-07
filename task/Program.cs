Console.WriteLine("введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите массив");
string [] array = new string [length];
string [] arraynew = new string [length];
for (int i=0; i<array.Length; i++)
{
    array[i] = Console.ReadLine();
}

int count = 0;
for (int i=0; i<array.Length; i++)
{
    if (array[i].Length<=3)
    {
    arraynew[count] = array[i];
    count++;
    }
}

for (int i=0; i<array.Length; i++)
{
Console.Write(arraynew[i]+" ");
}

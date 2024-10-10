//InsertArray methodu yaradılır. Method parametr olaraq int tipindən array və params olaraq int-lər qəbul edir.
//Paramslardan gələn dəyərləri həmin arraya əlavə etsin və sonda dəyişilmiş hal köhnə arraya bərabər olsun.

namespace Mytask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalarray = new int[] { 1, 2, 3 };
            InsertArray(ref originalarray,4,5,6);
            for (int i = 0; i < originalarray.Length; i++)
            {
                Console.WriteLine(originalarray[i]);
            }

            
        }

        static void InsertArray(ref int[]array, params int[] datas)
        {
            int newsize=array.Length+datas.Length;
            int[] newArray = new int[newsize];

            for(int i=0; i<array.Length;i++)
            {
                newArray[i] = array[i];
            }

            for(int i=0; i < datas.Length; i++)
            {
                newArray[array.Length+i] = datas[i];
            }
            array = newArray; 
        }
    }
}

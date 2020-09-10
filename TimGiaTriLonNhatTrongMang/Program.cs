using System;

namespace TimGiaTriLonNhatTrongMang
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bước 1: Khai báo các biến, nhập và kiểm tra kích thước mảng

            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Size should not exceed 20");
            } while (size > 20);
            //Bước 2: Nhập giá trị cho các phần tử của mảng

            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter element" + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            //Bước 3: In ra danh sách phần tử đã nhập

            Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }
            //Bước 4: Duyệt các phần tử trong mảng để tìm GTLN và vị trí

            int max = array[0];
            int index = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                    index = j + 1;
                }
            }
            Console.WriteLine("The largest property value in the list is " + max + " ,at position " + index);
        }
    }
}

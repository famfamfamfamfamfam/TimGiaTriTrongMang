using System;

namespace MANGMOTCHIEU
{
    class TimPhanTuMang
    {
        static void Main(string[] args)
        {
            string[] dsSV = {"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};
            Console.WriteLine("Nhap ten sinh vien can tim:");
            string tenSV = Console.ReadLine();
            bool timten = false;
            for (int i = 0; i < dsSV.Length; i++)
            {
                if(dsSV[i]==tenSV)
                {
                    Console.WriteLine("Ten sinh vien nay nam o vi tri thu "+(i+1)+" trong danh sach");
                    timten = true;
                    break;
                }
            }
            if(timten==false)
            {
                Console.WriteLine("Khong tim thay");
            }
        }
    }
}
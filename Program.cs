using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_HW5_Algorithm_2562_2
{
    class Program
    {
        static void Main(string[] args)
        {

            S_student.gat_val_Stu();
            S_student.title_table_score();
            S_student.table_score();
        }
    }
    class S_student
    {
        //กำหนดตัวแปรเพื่อเอาไปเก็บไว้ในArray
        static float AP_1, MP_1, FP_1, CP_1, AP_2, MP_2, FP_2, CP_2, AP_3, MP_3, FP_3, CP_3, AP_4, MP_4, FP_4, CP_4, AP_5, MP_5, FP_5, CP_5;
        //กำหนดตัวแปรเพื่องไปใช้ในการคำนวณ
        static  float sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0, sum5 = 0;
        static  float std_sum1 = 0, std_sum2 = 0, std_sum3 = 0, std_sum4 = 0, std_sum5 = 0;

        public static void title_table_score()
        {
            //กำหนดชื่อหัวข้อคะแนนต่างๆแต่ละหลักที่อยู่บนตาราง
            string[,] Attend_class_P = new string[,] { { "AP" } };
            string[,] Mid_term_P = new string[,] { { "MP" } };
            string[,] Final_P = new string[,] { { "FP" } };
            string[,] Collect_P = new string[,] { { "CP" } };
            for (int n = 0; n < 1; ++n) //กำหนดแถว
            {
                for (int m = 0; m < 1; ++m) //กำหนดหลัก
                {
                    Console.Write("\t\t{0}", Attend_class_P[n, m]);
                    Console.Write("\t{0}", Mid_term_P[n, m]);
                    Console.Write("\t{0}", Final_P[n, m]);
                    Console.Write("\t{0}", Collect_P[n, m]);

                }
                Console.WriteLine();
            }
        }
        public static void table_score()
        {

            //รับค่าจากตัวแปรมาใส่ในตาราง
            float[,] arr = new float[,] { { AP_1, MP_1, FP_1, CP_1 }, { AP_2, MP_2, FP_2, CP_2 }, { AP_3, MP_3, FP_3, CP_3 }, { AP_4, MP_4, FP_4, CP_4 }, { AP_5, MP_5, FP_5, CP_5 }, };
            for (int i = 0; i < 5; ++i) //กำหนดแต่ละแถว
            {
                Console.Write("student {0}", i + 1); //เริ่มนับที่เลข1
                for (int j = 0; j < 4; ++j) //กำหนดแต่ละหลัก
                {
                    Console.Write("\t{0}", arr[i, j]);

                    sum1 = (sum1 + arr[0, j]); //เอาหลักที่jของแถวที่0มาบวกกัน
                    std_sum1 = sum1 / 5; //เนื่องจากแถวที่0หลักที่jมันจะวนloopทั้งหมด5รอบเป็นเลขชุดเดียวกันทั้ง5รอบ เลยหารด้วย5 
                    sum2 = (sum2 + arr[1, j]);
                    std_sum2 = sum2 / 5;
                    sum3 = (sum3 + arr[2, j]);
                    std_sum3 = sum3 / 5;
                    sum4 = (sum4 + arr[3, j]);
                    std_sum4 = sum4 / 5;
                    sum5 = (sum5 + arr[4, j]);
                    std_sum5 = sum5 / 5;

                }
                Console.WriteLine();

            }
            Console.WriteLine("AP = Attend class points, MP = Mid-term points, FP = Final points, CP = Collect points");
            Console.WriteLine("Total score of student 1 is {0}", std_sum1);
            Console.WriteLine("Total score of student 2 is {0}", std_sum2);
            Console.WriteLine("Total score of student 3 is {0}", std_sum3);
            Console.WriteLine("Total score of student 4 is {0}", std_sum4);
            Console.WriteLine("Total score of student 5 is {0}", std_sum5);
        }
        public static void gat_val_Stu()
        {
            //รับค่าตัวแปลนักเรียนคนที่1,2,3,4 และ5 แล้วจะไปแสดงผลในตาราง
            Console.Write("Enter Attend class points student 1:");
            AP_1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Mid-term student 1:");
            MP_1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Final points student 1:");
            FP_1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Collect points student 1:");
            CP_1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Attend class points student 2:");
            AP_2 = float.Parse(Console.ReadLine());
            Console.Write("Enter Mid-term student 2:");
            MP_2 = float.Parse(Console.ReadLine());
            Console.Write("Enter Final points student 2:");
            FP_2 = float.Parse(Console.ReadLine());
            Console.Write("Enter Collect points student 2:");
            CP_2 = float.Parse(Console.ReadLine());
            Console.Write("Enter Attend class points student 3:");
            AP_3 = float.Parse(Console.ReadLine());
            Console.Write("Enter Mid-term student 3:");
            MP_3 = float.Parse(Console.ReadLine());
            Console.Write("Enter Final points student3:");
            FP_3 = float.Parse(Console.ReadLine());
            Console.Write("Enter Collect points student3:");
            CP_3 = float.Parse(Console.ReadLine());
            Console.Write("Enter Attend class points student 4:");
            AP_4 = float.Parse(Console.ReadLine());
            Console.Write("Enter Mid-term student 4:");
            MP_4 = float.Parse(Console.ReadLine());
            Console.Write("Enter Final points student 4:");
            FP_4 = float.Parse(Console.ReadLine());
            Console.Write("Enter Collect points student 4:");
            CP_4 = float.Parse(Console.ReadLine());
            Console.Write("Enter Attend class points student 5:");
            AP_5 = float.Parse(Console.ReadLine());
            Console.Write("Enter Mid-term student 5:");
            MP_5 = float.Parse(Console.ReadLine());
            Console.Write("Enter Final points student 5:");
            FP_5 = float.Parse(Console.ReadLine());
            Console.Write("Enter Collect points student 5:");
            CP_5 = float.Parse(Console.ReadLine());

        }
    }
}

namespace Exam_DaoLinhDan_31241020878
{
    internal class Exam
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so n muon tao trong mang: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[]a=new int[n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rd.Next(0, 100);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Nhap so ban can tim: ");
            int x=Convert.ToInt32(Console.ReadLine());
            if (find(a,x)!=-1)
            {
                Console.WriteLine($"{x} nam o vi tri: {find(a,x)}");
            }
            else
            {
                Console.WriteLine($"Khong co {x} trong mang.");
            }

            Console.Write("Cac so nguyen to trong mang la: ");
            prime(a);

            Console.Write("Mang da duoc xep: ");
            if (xep(a))
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");

            Console.Write("Mang sap xep giam dan: ");
            sort(a);

            Console.WriteLine("\nTao ma tran NxM");
            Console.Write("Nhap N: ");
            int N= Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap M: ");
            int M= Convert.ToInt32(Console.ReadLine());
            int[,] NM = new int[N, M];
            for (int i=0; i<N; i++)
            {
                for (int j=0; j<M; j++)
                {
                    NM[i,j] = rd.Next(1, 100);
                    Console.Write(NM[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.Write("Tong so tren cot: ");
            int col= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"tong la: {sumcol(NM,col)}");
        }
        static int find (int []a, int x)
        {
            for(int i = 0;i < a.Length;i++)
            {
                if (x == a[i])
                {
                    return i;
                }
            }
            return -1;
        }
        static void prime (int[]a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 2) { continue; }
                bool isprime = true;
                for (int j = 2; j <= Math.Sqrt(a[i]); j++)
                {
                    if (a[i] % j==0)
                    {
                        isprime= false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.Write(a[i]+" ");
                }
            }
            Console.WriteLine();
        }
        static bool xep (int[]a)
        {
            int[] b = new int[a.Length];
            Array.Copy(a,b,a.Length);
            Array.Sort(b);
            if (a == b)
            {
                return true;
            }
            else return false;
        }
        static void sort(int[]a)
        {
            for (int i = 0;i < a.Length-1;i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
        }
        static int sumcol(int[,]NM,int col)
        {
            int sum = 0;
            for (int i = 0;i<NM.GetLength(0);i++)
            {
                sum += NM[i, col];
            }
            return sum;
        }
    }
}

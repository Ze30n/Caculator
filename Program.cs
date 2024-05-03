internal class Program
{
    private static void Main(string[] args)
    {
        int choice = 0;
        do
        {
            int a = 0, b = 0;
            Console.WriteLine("==== M A Y _ T I N H ====");
            Console.WriteLine("1. Cong hai so");
            Console.WriteLine("2. Tru hai so");
            Console.WriteLine("3. Nhan hai so");
            Console.WriteLine("4. Chia hai so");
            Console.WriteLine("5. Chia lay du hai so");
            Console.WriteLine("6. Tinh a^b");
            Console.WriteLine("0. Thoat!");
            Console.WriteLine("Ban chon?");

            string input = Console.ReadLine();
            choice = Convert.ToInt32(input);
            switch (choice)
            {
                case 0: Console.WriteLine("==== H E N _ G A P _ L A I ===="); break;
                case 1:
                    Console.WriteLine("Nhap so nguyen a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so nguyen b");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a} + {b} = {a + b}"); break;
                case 2:
                    Console.WriteLine("Nhap so nguyen a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so nguyen b");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a} - {b} = {a - b}"); break;
                case 3:
                    Console.WriteLine("Nhap so nguyen a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so nguyen b");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a} x {b} = {a * b}"); break;
                case 4:
                    Console.WriteLine("Nhap so nguyen a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so nguyen b");
                    b = Convert.ToInt32(Console.ReadLine());
                    if (b == 0)
                    {
                        Console.WriteLine("Mau so b phai khac 0"); continue;        // K có continue; thì khi sai ctrinh sẽ dừng
                    }
                    else
                    {
                        Console.WriteLine($"{a} / {b} = {1.0f * a / b}"); break;
                    }
                case 5:
                    Console.WriteLine("Nhap so nguyen a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so nguyen b");
                    b = Convert.ToInt32(Console.ReadLine());
                    if (b == 0)
                    {
                        Console.WriteLine("Mau so b phai khac 0"); continue;        // K có continue; thì khi sai ctrinh sẽ dừng
                    }
                    else
                    {
                        Console.WriteLine($"{a} % {b} = {a % b}"); break;
                    }
                case 6:
                    Console.WriteLine("Nhap so nguyen a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so nguyen b");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}"); break;
                default: Console.WriteLine("Hay nhap cac tinh nang co san"); break;
            }

        } while (choice != 0);
    }
}
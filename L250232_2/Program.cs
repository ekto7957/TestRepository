using System;

namespace L250232_2
{
    internal class Program
    {

        static int Plus3(int number, int number2) // 반환할 변수가 int면
        {
            return number + number2;

        }

        static string Eat(string fruit)
        {
            return fruit + "를 먹다";
        }

        static float MultiNum(float a, float b)
        {
            return a * b;
        }

        static void Initialize(int n) // PascalCase , ()가 없으면 클래스명
        {
            int[,] arr = new int[n, n];
            int value = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = value;
                    value++;
                }
            }

            // 배열 출력 예제
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j].ToString("D2") + " "); // "\t"
                }

                Console.WriteLine();
            }
        }

    // 사용자 입력을 받아 두 정수의 곱을 반환하는 함수
        static int Multiply()
        {
            Console.Write("첫 번째 숫자를 입력하세요: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("두 번째 숫자를 입력하세요: ");
            int b = int.Parse(Console.ReadLine());

            return a * b;
        }
        static void Input()
        {

        }
        static void ApplyDamage()
        {

        }

        static void Main(string[] args)
        {


            while (true)
            {
                Input();

            }





















































     /*       Console.WriteLine("Hello, Git!");
            // 함수()사용
            Console.WriteLine(Plus3(2, 3));
            Console.WriteLine(Eat("사과"));
            Console.WriteLine(MultiNum(1.0f, 0.3f));
            // 함수 호출 (입력도 함수 내부에서 처리됨)
            int result = Multiply();

            // 결과 출력
            Console.WriteLine($"두 숫자의 곱: {result}");

            // 초기화 함수 사용
            Initialize(3);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // *****
            for (int j = 0; j < 5; j++)
            {

                Console.WriteLine(new string('*', j + 1));
                //Console.WriteLine();
            }

            int size = 6;
            for (int i = 0; i < size; i++)
            {
                // 내부 for문: i번째 줄에 (i + 1)개의 별을 출력
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                // 한 줄이 끝나면 줄바꿈
                Console.WriteLine();
            }

            // double array
            //int[,] arr = new int[5, 5]
            //{
            //    {  1,  2,  3,  4,  5 },
            //    {  6,  7,  8,  9, 10 },
            //    { 11, 12, 13, 14, 15 },
            //    { 16, 17, 18, 19, 20 },
            //    { 21, 22, 23, 24, 25 }
            //};

            int[,] arr = new int[5, 5];
            int value = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = value;
                    value++;
                }
            }

            // 배열 출력 예제
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j].ToString("D2") + " "); // "\t"
                }

                Console.WriteLine();
            }

            // 강사님 풀이



            // 5x5 배열 선언
            int[,] arr2 = new int[5, 5];

            // Random 객체 생성
            Random random = new Random();

            // 배열 채우기: 이중 for문 사용
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // 0부터 255까지 난수 생성 (256은 제외)
                    arr2[i, j] = random.Next(0, 256);
                }
            }

            // 배열 출력 예제
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr2[i, j].ToString("D3") + " ");
                }

                Console.WriteLine();
            }
            //   *
            //  **
            // ***
            // *을 오른쪽 들여쓰기 -> 공란을 설정후 줄인다?

            int lineNum = 5;
            for (int i = 0; i < lineNum; i++)
            {
                // 앞줄 공백
                for (int j = 0; j < lineNum - (i + 1); j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = 1; i <= lineNum; i++)
            {
                Console.WriteLine(new string('*', i).PadLeft(lineNum));
            }

            int[] data = new int[10];
            String s = "Hello World";

            for (int i = 0; i < 10; i++)
            {
                data[i] = i + 1;
            }*/




        }
    }
}


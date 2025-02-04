namespace L250204_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  1-52 정수를 배열에 넣고 
            // 임의의 숫자를 8개 출력하라
            // 중복은 허용하지 않는다
            int[] arrNum = new int[52];
            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = i + 1;
                // Console.WriteLine(arrNum[i]);
            }

            // random 이용해 숫자 8개 뽑고 , 1개뽑으면 그건 제외하거나? 해서 출력
            
            Random rand = new Random();
            int[] selectedNumbers = new int[8]; // 중복 없는 8개의 숫자를 저장할 배열
            int count = 0;

            while (count < 8)
            {
                int randomNumber = rand.Next(arrNum[0], arrNum[arrNum.Length - 1] + 1); // 1~52 난수 생성
                bool isDuplicate = false;

                // 중복 체크
                for (int j = 0; j < count; j++)
                {
                    if (selectedNumbers[j] == randomNumber)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                // 중복이 아니라면 배열에 추가
                if (!isDuplicate)
                {
                    selectedNumbers[count] = randomNumber;
                    count++;
                }
            }

            Console.WriteLine("랜덤으로 선택된 숫자: " + string.Join(", ", selectedNumbers));
        }
    }
}

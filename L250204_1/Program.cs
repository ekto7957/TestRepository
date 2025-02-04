namespace L250204_1
{
    internal class Program
    {
        static uint A = 1103515245;
        static uint C = 12345;
        static uint M = 2147483648;

        static uint seed = 1;

        static uint rand()
        {
            seed = (A * seed + C) % M;
            return seed;
        }

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


            //// 두번째 방법 Fisher-Yates Shuffle 알고리즘
            //for (int i = arrNum.Length - 1; i > 0; i--)
            //{
            //    int j = rand.Next(i + 1); // 0 ~ i 중에서 랜덤 선택
            //    (arrNum[i], arrNum[j]) = (arrNum[j], arrNum[i]); // Swap
            //}

            //// 앞에서 8개 출력
            //Console.WriteLine("랜덤으로 선택된 숫자: " + string.Join(", ", arrNum[0..8]));

            // 난수 생성기 (시간을 시드로 사용; 보안성이 크게 필요하지 않은 경우)
            Random rand2 = new Random();

            // 1~52의 값을 가진 트럼프 덱 생성
            int[] deck = new int[52];
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = i + 1;
            }

            // 덱 섞기 (Shuffle)
            for (int i = 0; i < deck.Length * 10; ++i)
            {
                int firstCardIndex = rand2.Next(0, deck.Length);
                int secondCardIndex = rand2.Next(0, deck.Length);

                int temp = deck[firstCardIndex];
                deck[firstCardIndex] = deck[secondCardIndex];
                deck[secondCardIndex] = temp;
            }

            // 카드 번호를 문양과 숫자로 변환하는 함수 호출 후 8장 출력
            for (int i = 0; i < 8; ++i)
            {
                string card = GetCardName(deck[i]);
                Console.WriteLine(card);
            }

        }

        // 카드 번호를 받아서 문양과 숫자(면)를 문자열로 반환하는 함수
        static string GetCardName(int cardNumber)
        {
            string suit = "";
            int rank = ((cardNumber - 1) % 13) + 1; // 순위: 1~13

            // 문양 결정
            if (cardNumber >= 1 && cardNumber <= 13)
            {
                suit = "♥";
            }
            else if (cardNumber >= 14 && cardNumber <= 26)
            {
                suit = "◆";
            }
            else if (cardNumber >= 27 && cardNumber <= 39)
            {
                suit = "♣";
            }
            else if (cardNumber >= 40 && cardNumber <= 52)
            {
                suit = "♠";
            }

            // 숫자(면) 결정: 1=A, 11=J, 12=Q, 13=K, 그 외는 숫자 그대로.
            string rankStr = "";
            switch (rank)
            {
                case 1:
                    rankStr = "A";
                    break;
                case 11:
                    rankStr = "J";
                    break;
                case 12:
                    rankStr = "Q";
                    break;
                case 13:
                    rankStr = "K";
                    break;
                default:
                    rankStr = rank.ToString();
                    break;
            }

            // 예: "Heart A", "Diamond 10" 등
            return suit + " " + rankStr;
        }
    }
}

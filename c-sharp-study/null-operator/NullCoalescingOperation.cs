using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class NullCoalescingOperation
    {
        static void Main(string[] args)
        {
            // useIf(null); //(null) 
            // useIf("밍구"); //밍구
            // useTernaryOperator("밍구");
            // useNullCoalescingOperator("밍구");
            useNullConditionalOprator();
        }
        
        //1-1. if문 사용
        public static void useIf(string name)
        {
            if (name != null)
            {
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("(null)");
            }
        }    
        
        //1-2. 삼항연산자 사용
        public static void useTernaryOperator(string name)
        {
            Console.WriteLine(name == null ? "(null)" : name);
        }
        
        //1-3. ??(null 병합 연산자) 사용
        public static void useNullCoalescingOperator(string name)
        {
            Console.WriteLine(name ?? "(null)");
        }
        
        //2. ??=(null 병합 할당 연산자)
        public static void useNullCoalescingAssignmentOperator()
        {
            List<int> numbers = null;
            int? a = null;

            (numbers ??= new List<int>()).Add(5);
            Console.WriteLine(string.Join(" ", numbers));  // output: 5

            numbers.Add(a ??= 0);
            Console.WriteLine(string.Join(" ", numbers));  // output: 5 0
            Console.WriteLine(a);  // output: 0
        }
        
        //3. ?.(null 조건 연산자) 사용
        public static void useNullConditionalOprator()
        {
            /*
            List<int> list = GetList(); //null을 반환했다면?
            Console.WriteLine(list.Count); //예외 발생!
            Console.WriteLine(list?.Count); //null 반환
            
            //C# 6.0 컴파일러는 다음과 같은 코드로 변환 처리
            Console.WriteLine(list != null ? new int?(list.count) : null);
            */
            
            List<int> list1 = new List<int>();
            List<int> list2 = null;
            Console.WriteLine(list1?.Count); //0

            int? ret = list2?.Count;
            Console.WriteLine(ret == null ? "(null)" : ret.Value.ToString()); //(null)
        }
    }
}
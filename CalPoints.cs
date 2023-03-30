using System.Collections;

// namespace CalPoints
// {
//     class Solution
//     {
//         public int CalPoints(string[] ops)
//         {
//             var opsList = new List<string>();
//             var sum = 0;

//             foreach (var item in ops)
//             {
//                 if (item.Equals("+"))
//                 {
//                     var index = int.Parse(opsList[opsList.Count - 1]) + int.Parse(opsList[opsList.Count - 2]);
//                     opsList.Add(index.ToString());

//                     sum = CalculateSum(opsList);
//                 }
//                 else if (item.Equals("D"))
//                 {
//                     var index = int.Parse(opsList[opsList.Count - 1]) * 2;
//                     opsList.Add(index.ToString());

//                     sum = CalculateSum(opsList);
//                 }
//                 else if (item.Equals("C"))
//                 {
//                     opsList.RemoveAt(opsList.Count - 1);

//                     sum = CalculateSum(opsList);
//                 }
//                 else
//                 {
//                     //An integer was added
//                     opsList.Add(item);

//                     sum = CalculateSum(opsList);
//                 }

//             }

//             return sum;
//         }
//         private int CalculateSum(List<string> opsList)
//         {
//             int sum = 0;

//             foreach (var val in opsList)
//             {
//                 sum += int.Parse(val);
//             }

//             return sum;
//         }
//     }

    // class CalPoints
    // {
        // private static void Main(string[] args)
        // {
        //     ArrayList array = new ArrayList();
        //     int element1 = 7;
        //     int element2;
        //     array.Add(element1);
        //     element2 = (int)array[0];


        //     var solution = new Solution();
        //     var space = new char[] { ' ' };

        //     string[] ops = Console.ReadLine().Split(space);
        //     int output = solution.CalPoints(ops);
        //     Console.Write(output.ToString());
        // }
//     }
// }
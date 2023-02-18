using System;

namespace NCalc.Play
{
    /// <summary>
    /// Summary description for Program.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var expressions = new[]
            {
                "2 * (3 + 5)",
                "2 * (2*(2*(2+1)))",
                "10 % 3",
                "false || not (false and true)",
                "3 > 2 and 1 <= (3-2)",
                "3 % 2 != 10 % 3",
                "'A' = 'A' ? 10 : ('B' = 'B' ? 15 : 20)",
                "if ('A' = 'A', 10, if ('B' = 'B', 15, 20))",
                "1+((((((2)-30)^3)+25000)/499)/6)",
                "1+((((((2)-30)^3)+25000)/499)/6)",
                "0.8+(((((((2-30)^3)+25000)/499)/6)))",
                "(0.85+(((((((2-30)^3)+25000)/499)/6))))*6",
                "(0.9+(((((((2-30)^3)+25000)/499)/6))))*8",
                "(0.95+(((((((2-30)^3)+25000)/499)/6))))*10",
                "52/(1+(((((((2-30)^3)+25000)/499)/6))))",
                "(1+(((((((2-30)^3)+25000)/499)/6))))*1.5",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*23",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*85",
                "(0.8+(((((((2-30)^3)+25000)/499)/50)*100)/12))*8",
                "11/(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*85*6",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*85*5",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*85*8",
                "(1+(((((((2-30)^3)+25000)/499)/6))))*15",
                "(1+(((((((2-30)^3)+25000)/499)/6))))*50",
                "(1+(((((((2-30)^3)+25000)/499)/6))))*10",
                "(1+(((((((2-30)^3)+25000)/499)/6))))*6",
                "50/(1+(((((((2-30)^3)+25000)/499)/6))))+20",
                "41/(1+(((((((2-29)^3)+22333)/444)/10))))+0.8",
                "(2+(((((((2-30)^3)+25000)/499)/6))))*1.5",
                "(0.9+(((((((2-35)^3)+40440)/600)/7.5))))*5",
                "(0.95+(((((((2-30)^3)+25000)/499)/6))))*7.8",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*85*2.5",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*85*2",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*85*3.2",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*85*5",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*85*3",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*45",
                "(1+(((((((2-30)^3)+25000)/499)/6))))*28",
                "(1+(((((((2-30)^3)+25000)/499)/6))))*8",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*15",
                "0.1+(((((((2-47)^3)+120000)/600)/41)))",
                "0.9+(((((((2-30)^3)+25000)/499)/12)))",
                "(1+((((((((2)-30)^3)+25000)/499)/6))))*12",
                "(1+((((((((2)-30)^3)+25000)/499)/6))))*13",
                "(1+((((((((2)-30)^3)+25000)/499)/6))))*14",
                "(1+(((((((2-35)^3)+43000)/499)/50)*100)/12))*85",
                "(0.9+(((((((2-35)^3)+40440)/600)/7.5))))*5",
                "(0.9+(((((((2-35)^3)+40440)/600)/7.5))))*5",
                "(1+(((((((2-30)^3)+25000)/499)/6))))*33.3",
                "(1+(((((((2-30)^3)+25000)/490)/50)*100)/15))*20",
                "3.1+(((((((2-50)^3)+120000)/60)/33)))",
                "((1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*85)/2",
                "((2+((((((((2)-30)^3)+25000)/499)/6))))*12)",
                "((1+((((((((2)-30)^3)+25000)/499)/7.5))))*12)",
                "((1+((((((((2)-30)^3)+25000)/490)/7))))*12)+10",
                "((2+((((((((2)-30)^3)+25000)/499)/6))))*12)",
                "((1+(((((((2-30)^3)+25000)/499)/6))))*9.2)",
                "((1+(((((((2-30)^3)+25000)/499)/6))))*13)",
                "(1+((((((2)-30)^3)+25000)/499)/5.3))-0.07475",
                "(0.9+(((((((2-35)^3)+40440)/600)/7.5))))*4",
                "(0.85+(((((((2-30)^3)+25000)/499)/50)*100)/12))*6",
                "(1+((((((2)-30)^3)+25000)/499)/8))-0.07475",
                "(1+((((((2)-30)^3)+25000)/499)/8))-0.07475",
                "((5+(((2-47)^3)+102000)/860)/2)",
                "(1+(((((((2-30)^3)+25000)/499)/6))))*33.3",
                "(0.8+(((((((2-30)^3)+25000)/499)/50)*100)/12))*8",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*23",
                "(1+(((((((2-30)^3)+25000)/499)/50)*100)/12))*23",
                "(1+((((((2)-30)^3)+25000)/499)/8))-0.07475",
                "((((2-10)^1.3)*5)^1.6)",
                //"if( [age] >= 18, 'majeur', 'mineur')",
                //"CalculateBenefits([user]) * [Taxes]"
            };

            foreach (string expression in expressions)
                Console.WriteLine("{0} = {1}",
                    expression,
                    new Expression(expression).Evaluate());

            Console.ReadKey();
        }
    }
}

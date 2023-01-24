using System.Linq.Expressions;
using System.Transactions;

namespace LinqSnippets
{
    public class Snippets
    {
        static public void BasicLinQ()
        {
            string[] cars =
            {
                "VW Golf",
                "BMW",
                "Honda",
                "Audi A3",
                "Audi A5",
                "Seat Ibiza",
                "Seat Leon"
            };

            //Select * of cars
            var carList = from car in cars select car;

            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }

            //Select WHERE car is AUDI
            var audiList = from car in cars where car.Contains("Audi") select car;

            foreach (var audi in audiList)
            {
                Console.WriteLine(audi);
            }
        }

        static public void LinqNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Each number mulitplied by 3
            //take all numbers, but 9
            // Order numbers by ascending value

            var processedNumberList = numbers.Select(num => num * 3)
                                             .Where(num => num != 9)
                                             .OrderBy(num => num);
        }


        static public void SearchExamples()
        {

            List<string> textList = new List<string>
            {
                "a","b","cj","d","e","f","c"
            };
            //1.First of all elements
            var first = textList.First();

            //2.First element that is "C"
            var cText = textList.First(text => text.Equals("c"));

            //3. First element that contains "j"
            var jText = textList.First(text => text.Contains("j"));

            //4.First element that contains Z or default
            var fistOfDefaultText = textList.FirstOrDefault(text => text.Contains("z"));//"" or element that contains "Z"

            //5.First element that contains Z or default
            var lastOfDefaultText = textList.LastOrDefault(text => text.Contains("z"));

            //6.Single Values
            var uniqueTexts = textList.Single();
            var uniqueorDefaultTexts = textList.SingleOrDefault();

            int[] evenNumbers = { 0, 2, 4, 6, 8 };
            int[] otherEvenNumbers = { 0, 2, 4 };

            //Obtain {4,8}
            var myEvenNumbers = evenNumbers.Except(otherEvenNumbers);//{4,8}

        }

        static public void MultipleSelects()
        {
            //SELECT MANY
            string[] myOpinions =
            {
                "Opinio 1, text 1",
                "Opinio 2, text 2",
                "Opinio 3, text 3",
            };

            var myOpinionSelection = myOpinions.SelectMany(opinion => opinion.Split(","));

            var enterprises = new[]
            {
                new Enterprise()
                {
                    Id = 1,
                    Name= "Enterprise 1",
                    Employees= new[]
                    {
                        new Employee
                        {
                            Id= 1,
                            Name="Martin",
                            Email="martin@imaginagroup.com",
                            Salary = 3000
                        },

                        new Employee
                        {
                            Id= 2,
                            Name="Pepe",
                            Email="pepe@imaginagroup.com",
                            Salary = 1000
                        },
                         new Employee
                        {
                            Id=3,
                            Name="Juanjo",
                            Email="martin@imaginagroup.com",
                            Salary = 2000
                        }
                    }
                },
                new Enterprise()
                {
                   Id = 2,
                   Name = "Enterprise 2",
                   Employees = new[]
                   {
                        new Employee
                        {
                            Id= 3,
                            Name="Ana",
                            Email="ana@imaginagroup.com",
                            Salary = 3000
                        },

                        new Employee
                        {
                            Id= 4,
                            Name="Maria",
                            Email="maria@imaginagroup.com",
                            Salary = 1500
                        },
                         new Employee
                        {
                            Id= 5,
                            Name="Marta",
                            Email="marta@imaginagroup.com",
                            Salary = 2500
                        },
                   }
                }

            };
            //Obtain all employees of all Enterprises
            var employeeList = enterprises.SelectMany(enterprises => enterprises.Employees);

            //Know if a list is empty
            bool hasEnterprises = enterprises.Any(enterprise => enterprise.Employees.Any());

            //All enterprises at least has an employee with more than 1000e of salary
            bool hasEmployeesWithSalaryMoreThan1000 = 
                enterprises.Any(enterprises => enterprises.Employees.Any(Employee => Employee.Salary >=1000));
        }
        static public void linqCollections()
        {
            var firstList = new List<string>() { "a", "b", "c" };
            var secondList = new List<string>() { "a", "c", "d" };

            //INNER JOIN
            var commonResult = from element in firstList
                               join secondElement in secondList
                               on element equals secondElement
                               select new { element, secondElement };


            var commonResult2 = firstList.Join(
                secondList,
                element => element,
                secondElement => secondElement,
                (element, secondElement) => new { element, secondElement}
                );

            //OUTER JOIN -LEFT
            var leftOuterJoin = from element in firstList
                                join secondElement in secondList
                                on element equals secondElement
                                into temporalList
                                from temporalElement in temporalList.DefaultIfEmpty()
                                where element != temporalElement
                                select new { Element = element };

            var leftOuterJoin2 = from element in firstList
                                 from secondElement in secondList.Where(s => s ==element).DefaultIfEmpty()
                                 select new { Element = element, SecondElement = secondElement  };

            //OUTER JOIN -RIGTH
            var rightOuterJoin = from secondElement in secondList
                                 join element in firstList
                                on secondElement equals element
                                into temporalList
                                 from temporalElement in temporalList.DefaultIfEmpty()
                                 where secondElement != temporalElement
                                 select new { Element = secondElement };


            //UNION 
            var  unionList = leftOuterJoin.Union(rightOuterJoin);
        }
        static public void SkipTakeLinq()
        {
            var myList = new[]
            {
                1,2,3,4,5,6,7,8,9,10
            };

            //SKIP
            var skipTwoFirstValues = myList.Skip(2); //{3,4,5,6,7,8,9,10}
            var skipLastTwoValues = myList.Skip(2); //{1,2,3,4,5,6,7,8}
            var skipWhileSmallerThan4 = myList.SkipWhile(num => num < 4); //{5,6,7,8}

           
            //TAKE
            var takeFistValues = myList.Take(2); //{1,2}
            var takeLastTwoValues = myList.Take(2); //{9,10}
           var takeWhileSmallerThan4 =myList.TakeWhile (num => num < 4); //{1,2,3}

        }
    }
}
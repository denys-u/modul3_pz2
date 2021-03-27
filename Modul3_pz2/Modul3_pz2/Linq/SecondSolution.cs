namespace Modul3_pz2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Modul3_pz2.Linq;

    public class SecondSolution
    {
        public string Data { get; set; }

        public void Start()
        {
            var list = new List<User>
            {
                new User { Name = "Dennis", LastName = "Udovik", Age = 23 },
                new User { Name = "Mark", LastName = "Mudovik", Age = 27 },
                new User { Name = "Danil", LastName = "Rudovik", Age = 23 },
                new User { Name = "Alina", LastName = "Kudovik", Age = 24 },
            };

            var first = list.FirstOrDefault(f => f.Name == "Mark");
            Console.WriteLine($"{first.Name} - {first.LastName} - {first.Age}");

            var second = list.Where(w => w.Name.Contains("D"));

            foreach (var item in second)
            {
                Console.WriteLine($"{first.Name} - {first.LastName} - {first.Age}");
            }

            var third = list.Select(s => new SecondSolution { Data = s.Name });
            foreach (var item in third)
            {
                Console.WriteLine($"{item.Data} - {item.GetType()}");
            }

            var fourth = list.OrderBy(o => o.Name).ThenBy(t => t.LastName);

            foreach (var item in fourth)
            {
                Console.WriteLine($"{first.Name} - {first.LastName} - {first.Age}");
            }
        }
    }
}

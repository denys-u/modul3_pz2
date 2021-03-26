namespace Modul3_pz2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Modul3_pz2.Linq;

    public class SecondSolution
    {
        List<User> users = new List<User>
        {
                new User { Name = "Denis", Age = 21 },
                new User { Name = "Maria", Age = 27 },
                new User { Name = "Dima", Age = 21 },
                new User { Name = "Danil", Age = 23 },
        };

        var selectUsers = from user in users
                          where user.Age < 27
                          select user;
    }
}

using System.Collections.Generic;
using People.Models;


namespace People.Data
{
        public class MockPeopleRepo : IPeopleRepo
        {
            public IEnumerable<Command> GetAppCommands()
            {
                var commands = new List<Command>
                {
                    new Command {Id = 0, 
                    name = "Daniel", 
                    frist = "Daniel",   
                    middle = "E ", 
                    last  = "Calderon ", 
                    address  = "123 ", 
                    street   = "Main ",
                    city  = "Andover ", 
                    state  = "Ma ", 
                    zip  = "90290 ", 
                    phone  = "9199900993 ", 

                    type  = "Cell ", 
                    email  = "aol.com "},

                    new Command {Id = 1, 
                    name = "D", 
                    frist = "D",   
                    middle = "E ", 
                    last  = "Calderon ", 
                    address  = "123 ", 
                    street   = "Main ",
                    city  = "Andover ", 
                    state  = "Ma ", 
                    zip  = "90290 ", 
                    phone  = "9199900993 ", 

                    type  = "Cell ", 
                    email  = "aol.com "},

                    new Command {Id = 2, 
                    name = "Ben", 
                    frist = "Ben",   
                    middle = "E ", 
                    last  = "Calderon ", 
                    address  = "123 ", 
                    street   = "Main ",
                    city  = "Andover ", 
                    state  = "Ma ", 
                    zip  = "90290 ", 
                    phone  = "9199900993 ", 

                    type  = "Cell ", 
                    email  = "aol.com "}


                    
                };

return commands;

            }
            public Command GetCommandById(int id)
            {
                return new Command{
                    Id = 0, 
                    name = "Daniel", 
                    frist = "Daniel",   
                    middle = "E ", 
                    last  = "Calderon ", 
                    address  = "123 ", 
                    street   = "Main ",
                    city  = "Andover ", 
                    state  = "Ma ", 
                    zip  = "90290 ", 
                    phone  = "9199900993 ", 

                    type  = "Cell ", 
                    email  = "aol.com "};
            }
        }



}

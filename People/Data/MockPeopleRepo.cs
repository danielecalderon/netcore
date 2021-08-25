using System.Collections.Generic;
using People.Models;


namespace People.Data
{
        public class MockPeopleRepo : IPeopleRepo
        {
            public IEnumerable<Command> GetAppCommands()
            {
                throw new System.NotImplementedException();
            }
            public Command GetCommandById(int id)
            {
                throw new System.NotImplementedException();
            }
        }



}

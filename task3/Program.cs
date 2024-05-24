using task3;
class Program
{
    static void Main(string[] args)
    {

        List<Group> groups = new List<Group>();

        void GetGroups()
        {
            foreach (var group in groups)
            {
                Console.WriteLine(group.Name);
            }
        }
        void AddGroup(List<Group> groupList, Group newGroup)
        {

            foreach (var group in groupList)
            {
                if (group.Name == newGroup.Name)
                {
                    Console.WriteLine($"{newGroup.Name} already exists. ");
                    return;
                }
            }


            groupList.Add(newGroup);
            Console.WriteLine($"{newGroup.Name} added");
        }



        AddGroup(groups, new Group("PB-401"));
        AddGroup(groups, new Group("PB-501"));
        AddGroup(groups, new Group("PB-401")); 

       
        
        GetGroups();
    }
}
